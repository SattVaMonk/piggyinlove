using Microsoft.AspNetCore.Mvc;
using PiggyWeChatAppBackEnd.Model;
using System.Collections.Generic;

namespace PiggyWeChatAppBackEnd.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TripHistoryController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Trip>> GetTripList()
        {
            TripHistory th = TripHistory.GetInstance();
            return th.GetTripList();
        }
        
        [HttpGet]
        public ActionResult<int> GetTripCount()
        {
            TripHistory th = TripHistory.GetInstance();
            return th.GetTripCount();
        }

        [HttpPost]
        public ActionResult<bool> AddTrip(string location, string date, string feeling)
        {
            return TripHistory.GetInstance().AddTrip(location,date,feeling);
        }
    }
}