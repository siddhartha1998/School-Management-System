using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MuguShop.Controllers
{
    [AllowAnonymous]
    public class ConnectIPSPaymentController : Controller
    {
        [HttpGet("ConnectIPS")]
        public IActionResult ConnectIPSPayment()
        {
            return View();
        }

        [HttpGet("ConnectIPSResponse")]
        public IActionResult ConnectIPSResponse([FromQuery] string TXNAMT, string ClientTXNId, string REFID)
        {
            ViewBag.TXNAMT = TXNAMT;
            ViewBag.ClientTXNId = ClientTXNId;
            ViewBag.REFID = REFID;
            return View();
        }
    }
}
