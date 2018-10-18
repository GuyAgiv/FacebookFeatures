using System.Runtime.Serialization;

namespace A18_Ex03_Guy_203507926_Ben_302823927
{
    [DataContract]
    public class Horoscope
    {
        [DataMember(Name = "date")]
        public string Date { get; set; }
        [DataMember(Name = "horoscope")]
        public string HoroscopeDescription { get; set; }
        [DataMember(Name = "sunsign")]
        public string SunSign { get; set; }
    }
}
