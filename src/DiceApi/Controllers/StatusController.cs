using Microsoft.AspNetCore.Mvc;

namespace DiceApi.Controllers
{
    [Route("api/[controller]")]
    public class StatusController : Controller
    {
        public string Get()
        {
            return "OK";
        }
    }
}