using DailyInfoCenter.Models.SMHI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyInfoCenter.Models.SMHI
{
    public class APIParameter
    {
        public class Rootobject
        {
            public Parameter[] parameter { get; set; }
        }

        public class Parameter
        {
            public string name { get; set; }
            public string levelType { get; set; }
            public int level { get; set; }
            public string unit { get; set; }
        }

    }
}
