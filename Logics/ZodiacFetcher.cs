using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;

namespace A18_Ex03_Guy_203507926_Ben_302823927
{
    public class ZodiacFetcher
    {
        public string GetHoroscope(DateTime i_DateToCheck)
        {
            string sign = findZodiacSign(i_DateToCheck);
            return getHoroscopeWithSign(sign);
        }

        private string findZodiacSign(DateTime i_DateToCheck)
        {
            string result = string.Empty;
            int month = i_DateToCheck.Month;
            int day = i_DateToCheck.Day;

            switch (month)
            {
                case 1:
                    result = (day <= 19) ? "Capricorn" : "Aquarius";
                    break;
                case 2:
                    result = (day <= 18) ? "Aquarius" : "Pisces";
                    break;
                case 3:
                    result = (day <= 20) ? "Pisces" : "Aries";
                    break;
                case 4:
                    result = (day <= 19) ? "Aries" : "Taurus";
                    break;
                case 5:
                    result = (day <= 20) ? "Taurus" : "Gemini";
                    break;
                case 6:
                    result = (day <= 20) ? "Gemini" : "Cancer";
                    break;
                case 7:
                    result = (day <= 22) ? "Cancer" : "Leo";
                    break;
                case 8:
                    result = (day <= 22) ? "Leo" : "Virgo";
                    break;
                case 9:
                    result = (day <= 22) ? "Virgo" : "Libra";
                    break;
                case 10:
                    result = (day <= 22) ? "Libra" : "Scorpio";
                    break;
                case 11:
                    result = (day <= 21) ? "Scorpio" : "Sagittarius";
                    break;
                case 12:
                    result = (day <= 21) ? "Sagittarius" : "Capricorn";
                    break;
            }

            return result;
        }

        private string getHoroscopeWithSign(string i_Sign)
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Horoscope));
            string zodiacDetails = string.Empty;
            string url = string.Format(@"http://horoscope-api.herokuapp.com/horoscope/today/{0}", i_Sign);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            {
                Horoscope parsedZodiac = (Horoscope)ser.ReadObject(stream);
                return parsedZodiac.HoroscopeDescription;
            }
        }
    }
}
