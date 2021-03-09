using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyInfoCenter.Models.SwedishRadio
{

    public class SRTrafficInfo
    {
        public string copyright { get; set; }
        public Message[] messages { get; set; }
        public Pagination pagination { get; set; }
    }

    public class Pagination
    {
        public int page { get; set; }
        public int size { get; set; }
        public int totalhits { get; set; }
        public int totalpages { get; set; }
        public string nextpage { get; set; }
    }

    public class Message
    {
        public int id { get; set; }
        public int priority { get; set; }
        public string createddate { get; set; }
        public string title { get; set; }
        public string exactlocation { get; set; }
        public string description { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public int category { get; set; }
        public string subcategory { get; set; }
    }

}
