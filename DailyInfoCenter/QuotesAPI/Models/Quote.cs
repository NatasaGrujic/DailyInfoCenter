using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyInfoCenter.QuotesAPI.Models
{
    public class Quote
    {
        public string dayName { get; set; }
        public int weekNo { get; set; }
        public string message { get; set; }
    }
}
