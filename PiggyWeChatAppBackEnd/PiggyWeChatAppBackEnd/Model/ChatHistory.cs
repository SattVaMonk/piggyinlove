using PiggyWeChatAppBackEnd.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PiggyWeChatAppBackEnd.Model
{
    public class ChatHistory
    {
        private readonly List<Chat> _chatList;
        public static ChatHistory _instance;
        private static readonly object o = new object();

        public ChatHistory(List<Chat> cList)
        {
            _chatList = cList;
        }

        public List<Chat> GetChats()
        {
            return _chatList;
        }

        public static ChatHistory GetInstance()
        {
            lock (o)
            {
                if (_instance == null)
                    _instance = DataHelper.GetFromJSon<ChatHistory>("./wwwroot/Data/ChatTest.json");
            }

            return _instance;
        }

        public static bool SaveToFile()
        {
            return DataHelper.WriteToJson("./wwwroot/Data/ChatTest.json", _instance);
        }

        ~ChatHistory()
        {
            lock (o)
            {
                SaveToFile();
            }
        }
    }
}
