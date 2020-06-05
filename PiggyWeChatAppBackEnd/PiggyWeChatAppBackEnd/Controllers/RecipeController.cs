using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PiggyWeChatAppBackEnd.Model;

namespace PiggyWeChatAppBackEnd.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Recipe>> GetMenu()
        {
            Menu m = Menu.GetInstance();
            return m.GetRecipes();
        }
    }
}