using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PiggyWeChatAppBackEnd.Model
{
    public class Chat
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}
