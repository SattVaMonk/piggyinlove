using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PiggyWeChatAppBackEnd.Model
{
    public class Recipe
    {
        public string Name { get; set; }
        public List<string> Img { get; set; }
        public List<MaterialItem> Materials { get; set; }
        public string Description { get; set; }
        public List<string> Steps { get; set; }
    }
}
