using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PiggyWeChatAppBackEnd.Model
{
    public class Trip
    {
        public string ID { get; set; }
        public string Location { get; set; }
        public string Date { get; set; }
        public string Feeling { get; set; }
        public List<Activity> Activities { get; set; }

    }
}
