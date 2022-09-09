using Microsoft.AspNetCore.Mvc;

namespace MuguShop.Controllers
{
    public class ResponseController : Controller
    {
        [HttpGet("response")]
        public IActionResult Index([FromQuery] int status, string responseMessage)
        {
            ViewBag.message = responseMessage;
            ViewBag.statusCode = status;
            return View();
        }
    }
}
