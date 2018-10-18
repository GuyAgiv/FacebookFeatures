using System;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using System.Globalization;
using System.Linq;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Net;
using FacebookWrapper.ObjectModel;

namespace A18_Ex03_Guy_203507926_Ben_302823927
{
    public class WeatherRepository
    {
        private const string k_defaultCity = "Tel Aviv";
        private const string k_defaultCountry = "Israel";
        private const string k_WarmWeather = "Warm";
        private const string k_ColdWeather = "Cold";
        private const string k_HotWeather = "Hot";
        private const int k_HotTempature = 27;
        private const int k_ColdTempature = 20;
        private const int k_MinDaysToFetchEvents = 0;
        private const int k_MaxDaysToFetchEvents = 4;
        private Dictionary<string, string> m_TempInfo = new Dictionary<string, string>();

        public Dictionary<string, string> WeatherNotes { get; private set; }

        public FBAuthenticator Authenticator { get; set; }

        public UserEvents UserEvents { get; private set; }

        public WeatherRepository()
        {
            UserEvents = new UserEvents();
            setWeatherNotesList();
        }

        public string DefaultCity
        {
            get
            {
                return k_defaultCity;
            }
        }

        public string DefaultCountry
        {
            get
            {
                return k_defaultCountry;
            }
        }

        public string WarmWeather
        {
            get
            {
                return k_WarmWeather;
            }
        }

        public string ColdWeather
        {
            get
            {
                return k_ColdWeather;
            }
        }

        public string HotWeather
        {
            get
            {
                return k_HotWeather;
            }
        }

        public int HotTempature
        {
            get
            {
                return k_HotTempature;
            }
        }

        public int ColdTempature
        {
            get
            {
                return k_ColdTempature;
            }
        }

        public int MinDaysToFetchEvents
        {
            get
            {
                return k_MinDaysToFetchEvents;
            }
        }

        public int MaxDaysToFetchEvents
        {
            get
            {
                return k_MaxDaysToFetchEvents;
            }
        }

        public virtual WeatherNodes GetXMLForWeather(WeatherLocation i_Location)
        {
            bool foundWeather = false;
            XmlReader reader = null;
            XmlSerializer serializerObj = null;
            WeatherNodes loadedObj = null;
            ///Try with the event location first,if not found get the default
            while (foundWeather == false)
            {
                string url = string.Format(@"http://api.openweathermap.org/data/2.5/forecast?q={0},{1}&units=metric&mode=xml&appid=d6c795304f427b8b78559ab660464d80", i_Location.City, i_Location.CountryIsoCode);
                try
                {
                    reader = XmlReader.Create(url);
                    foundWeather = true;
                    serializerObj = new XmlSerializer(typeof(WeatherNodes));
                    loadedObj = (WeatherNodes)serializerObj.Deserialize(reader);
                }
                catch (Exception ex)
                {
                    ////Handle case for city not found from this API:                    
                    if (ex is WebException)
                    {
                        WebException webExp = ex as WebException;

                        if (!(webExp == null) && ((WebException)ex).Status == WebExceptionStatus.ProtocolError)
                        {
                            HttpWebResponse resp = webExp.Response as HttpWebResponse;

                            if (resp != null && resp.StatusCode == HttpStatusCode.NotFound)
                            {
                                throw new WeatherException(string.Format("Could not find selected event location! setting to default values({0}, {1}", DefaultCity, DefaultCountry));
                            }
                        }
                    }
                    else
                    {
                        throw ex;
                    }
                }
                finally
                {
                    if (reader != null)
                    {
                        reader.Close();
                    }
                }
            }

            return loadedObj;
        }

        public RegionInfo GetCountryIso(string i_Country)
        {
            IEnumerable<RegionInfo> regions = CultureInfo.GetCultures(CultureTypes.SpecificCultures).Select(x => new RegionInfo(x.LCID));
            RegionInfo countryIsoCode = regions.FirstOrDefault(region => region.EnglishName.Contains(i_Country));
            return countryIsoCode;
        }

        private void setWeatherNotesList()
        {
            WeatherNotes = new Dictionary<string, string>();
            WeatherNotes.Add(k_HotWeather, "Going to be hot that day! might want to go light on the clothes");
            WeatherNotes.Add(k_ColdWeather, "Going to be cold outside! better bring something warm");
            WeatherNotes.Add(k_WarmWeather, "Going to be warm outside! have fun!");
        }

        public int FetchFutureEvents()
        {
            UserEvents.EventList.Clear();
            try
            {
                foreach (Event eve in Authenticator.LoggedInUser.Events)
                {
                    double daysDifference = (eve.StartTime - DateTime.Now).Value.TotalDays;
                    if (daysDifference >= MinDaysToFetchEvents && daysDifference <= MaxDaysToFetchEvents)
                    {
                        UserEvents.EventList.Add(eve.Name, eve);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex is NullReferenceException)
                {
                    MessageBox.Show("Something bad happend..");
                }
                else
                {
                    throw ex;
                }
            }

            return UserEvents.EventList.Count;
        }
    
        public Dictionary<string, string> GetWeatherForEvent(Event io_SelectedEvent, bool i_IsDefaultLocation)
        {
            WeatherLocation location;
            m_TempInfo.Clear();
            if (i_IsDefaultLocation)
            {
                location = getDefaultLocation();
            }
            else
            {
                getLocationForWeather(io_SelectedEvent, out location);
            }
            
            WeatherNodes loadedObj = GetXMLForWeather(location);

            Weather eventWeather = findEventDetails(loadedObj, io_SelectedEvent);
            recommendForWeather(eventWeather);
            return m_TempInfo;
        }

        private WeatherLocation getDefaultLocation()
        {
            WeatherLocation location = new WeatherLocation();
            location.City = DefaultCity;
            location.Country = DefaultCountry;
            location.CountryIsoCode = GetCountryIso(DefaultCountry);

            return location;
        }

        private Weather findEventDetails(WeatherNodes i_LoadedObj, Event i_SelectedEvent)
        {
            Weather eventWeather = null;

            foreach (Weather obj in i_LoadedObj.WeatherList)
            {
                if (i_SelectedEvent.StartTime >= obj.FromTime && i_SelectedEvent.StartTime <= obj.ToTime)
                {
                    eventWeather = obj;
                }
            }

            m_TempInfo.Add("WeatherCode", string.Format("http://openweathermap.org/img/w/{0}.png", eventWeather.WeatherSymbol.WeatherCode));

            return eventWeather;
        }

        private void getLocationForWeather(Event i_SelectedEvent, out WeatherLocation i_Location)
        {            
            i_Location = new WeatherLocation();
            if (i_SelectedEvent.Place.Location != null)
            {
                i_Location.City = i_SelectedEvent.Place.Location.City;
                i_Location.Country = i_SelectedEvent.Place.Location.Country;
                try
                {
                    i_Location.CountryIsoCode = GetCountryIso(i_Location.Country);
                }
                catch (Exception)
                {
                    throw new WeatherException(string.Format("Could not find selected event location! setting to default values({0}, {1}", DefaultCity, DefaultCountry));
                }
            } 
            else
            {
                throw new Exception("Missing location for the event!");
            }               
        }

        private void recommendForWeather(Weather i_EventWeather)
        {
            string heat = WarmWeather;
            string temperatureNote = WeatherNotes[WarmWeather];
            double tempature = i_EventWeather.Temperature.AverageTemperature;

            if (tempature >= HotTempature)
            {
                heat = HotWeather;
                temperatureNote = WeatherNotes[HotWeather];
            }
            else if (tempature <= ColdTempature)
            {
                heat = ColdWeather;
                temperatureNote = WeatherNotes[ColdWeather];
            }

            m_TempInfo.Add("Heat", heat);
            m_TempInfo.Add("TemperatureDescription", string.Format("Temperature: {0} {1}\n{2}\n", tempature, i_EventWeather.Temperature.UnitType, temperatureNote));
            m_TempInfo.Add("WeatherDescription", string.Format("Weather: {0}", i_EventWeather.WeatherSymbol.WeatherDescription));
        }
    }
}
