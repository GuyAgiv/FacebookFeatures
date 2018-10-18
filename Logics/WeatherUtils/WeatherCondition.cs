using System;
using System.Xml.Serialization;

namespace A18_Ex03_Guy_203507926_Ben_302823927
{
    [Serializable]
    public class WeatherCondition
    {
        [XmlAttribute("name")]
        public string WeatherDescription { get; set; }
        [XmlAttribute("var")]
        public string WeatherCode { get; set; }
    }
}