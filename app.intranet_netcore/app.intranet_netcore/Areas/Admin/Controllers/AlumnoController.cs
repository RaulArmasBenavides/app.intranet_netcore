using app.intranet_netcore.Datos.Data.Repository.IRepository;
using app.intranet_netcore.Models;
using Microsoft.AspNetCore.Mvc;

namespace app.intranet_netcore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AlumnoController : Controller
    {
        private readonly IUnitOfWork _unitofWork;

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create(Alumno alumno)
        {

            if (ModelState.IsValid)
            {
                _unitofWork.Alumnos.Add(alumno);
                _unitofWork.Save();
                return RedirectToAction(nameof(Index));
            }

            return View(alumno);
        }
    }
}
