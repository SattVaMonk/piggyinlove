using Microsoft.AspNetCore.Mvc;
using PiggyWeChatAppBackEnd.Model;
using System.Collections.Generic;

namespace PiggyWeChatAppBackEnd.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PiggyController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Chat>> GetChats()
        {
            ChatHistory ch = ChatHistory.GetInstance();
            return ch.GetChats();
        }

    }
}