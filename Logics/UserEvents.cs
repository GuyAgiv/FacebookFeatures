using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace A18_Ex03_Guy_203507926_Ben_302823927
{
    public class UserEvents
    {
        public Dictionary<string, Event> EventList { get; set; }

        public UserEvents()
        {
            EventList = new Dictionary<string, Event>();
        }
    }
}
