using System;
using System.Xml.Serialization;

namespace A18_Ex03_Guy_203507926_Ben_302823927
{
    [Serializable]
    public class Temperature
    {
        [XmlAttribute("unit")]
        public string UnitType { get; set; }
        [XmlAttribute("value")]
        public double AverageTemperature { get; set; }
    }
}
