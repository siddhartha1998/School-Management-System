using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using System.Xml.Linq;

namespace MuguShop.Controllers
{
    [AllowAnonymous]
    public class PaymentController : Controller
    {
        [HttpGet("Payment")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("OneTimePayment")]
        public IActionResult AddPayment()
        {
            return View();
        }
    }
}
