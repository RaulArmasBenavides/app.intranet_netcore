using Microsoft.AspNetCore.Mvc;

namespace app.intranet_netcore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AlumnoController : Controller
    {


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
