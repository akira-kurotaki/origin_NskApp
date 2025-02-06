using Microsoft.AspNetCore.Mvc;

namespace BaseReportDriver.Controllers
{
    public class ErrorController : Controller
    {
        [Route("/Error")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
