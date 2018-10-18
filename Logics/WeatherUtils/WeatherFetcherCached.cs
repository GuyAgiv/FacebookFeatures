using System.Collections.Generic;

namespace A18_Ex03_Guy_203507926_Ben_302823927
{
    public class WeatherFetcherCached : WeatherRepository
    {
        ////Will be the cache, if the user checks for weather fo city X next time he needs weather for it we wont need new XML from server =]
        private Dictionary<string, WeatherNodes> WeatherCache = new Dictionary<string, WeatherNodes>();

        public override WeatherNodes GetXMLForWeather(WeatherLocation i_Location)
        {
            if (!WeatherCache.ContainsKey(i_Location.City))
            {
                WeatherCache.Add(i_Location.City, base.GetXMLForWeather(i_Location));
            }

            return WeatherCache[i_Location.City];
        }        
    }
}
