using PiggyWeChatAppBackEnd.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PiggyWeChatAppBackEnd.Model
{
    public class Menu
    {
        private List<Recipe> _recipes;
        private static Menu _instance;
        private static readonly object o = new object();

        public Menu(List<Recipe> recipes) { _recipes = recipes; }

        public static Menu GetInstance()
        {
            lock (o)
            {
                if (_instance == null)
                    _instance = DataHelper.GetFromJSon<Menu>("./wwwroot/Data/RecipeTest.json");
            }

            return _instance;
        }

        public List<Recipe> GetRecipes()
        {
            return _recipes;
        }

        public static bool SaveMenuToFile()
        {
            return DataHelper.WriteToJson("./wwwroot/Data/RecipeTest.json", _instance);
        }

        ~Menu()
        {
            lock (o)
            {
                SaveMenuToFile();
            }
        }
    }
}
