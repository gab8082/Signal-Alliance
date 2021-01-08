using System;

namespace SignalAlliance.Controllers
{




    public class iincontrol
    {

        public class coutry
        {
            public string name { get; internal set; }
            public string currency { get; internal set; }
        }

        public class banking
        {
            public string name { get; internal set; }
            public string url { get; internal set; }
            public string phone { get; internal set; }
            public string city { get; internal set; }

        }
        
        public string scheme { get; internal set; }
        public string type { get; internal set; }
        public string brand { get; internal set; }
        public string prepaid { get; internal set; }
        public coutry country { get; internal set; }
        public banking bank { get; internal set; }


}
}