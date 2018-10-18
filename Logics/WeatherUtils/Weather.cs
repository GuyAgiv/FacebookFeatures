using System;
using System.Xml.Serialization;

namespace A18_Ex03_Guy_203507926_Ben_302823927
{
    [Serializable]
    [XmlRoot("forecast")]
    public class Weather
    {
        [XmlAttribute("from")]
        public DateTime FromTime { get; set; }
        [XmlAttribute("to")]
        public DateTime ToTime { get; set; }

        [XmlElement("temperature", typeof(Temperature))]
        public Temperature Temperature { get; set; }
        [XmlElement("symbol", typeof(WeatherCondition))]
        public WeatherCondition WeatherSymbol { get; set; }
    }
}