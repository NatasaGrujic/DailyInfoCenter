using System;

namespace DailyInfoCenter.Models.SMHI
{
    public class Timesery
        {
            public DateTime validTime { get; set; }
            public Parameter[] parameters { get; set; }
        }
}
