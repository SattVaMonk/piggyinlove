using Newtonsoft.Json;
using PiggyWeChatAppBackEnd.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PiggyWeChatAppBackEnd.Util
{
    public class DataHelper
    {
        public static T GetFromJSon<T>(string filePath)
        {
            using (StreamReader sr = File.OpenText(filePath))
            {
                string json = sr.ReadToEnd();
                return JsonConvert.DeserializeObject<T>(json, new JsonSerializerSettings() { Culture = new System.Globalization.CultureInfo("zh-Hans") });
            }
        }

        public static bool WriteToJson(string filePath, dynamic target)
        {
            try
            {
                string output = JsonConvert.SerializeObject(target);
                File.WriteAllText(filePath, output);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
