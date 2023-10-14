﻿using app.intranet_netcore.Datos.Data.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace app.intranet_netcore.Areas.Admin.Controllers
{
    //[Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class UsuariosController : Controller
    {
        private readonly IUnitOfWork _contenedorTrabajo;

        public UsuariosController(IUnitOfWork contenedorTrabajo)
        {
            _contenedorTrabajo = contenedorTrabajo;

        }

        [HttpGet]
        public IActionResult Index()
        {
            //Opción 1: Obtener todos los usuarios
            //return View(_contenedorTrabajo.Usuario.GetAll());

            //Opción 2: Obtener todos los usuarios menos el que esté logueado, para no bloquearse el mismo
            var claimsIdentity = (ClaimsIdentity)this.User.Identity;
            var usuarioActual = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            return View(_contenedorTrabajo.Usuario.GetAll(u => u.Id != usuarioActual.Value));
        }

        [HttpGet]
        public IActionResult Bloquear(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            _contenedorTrabajo.Usuario.BloquearUsuario(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Desbloquear(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            _contenedorTrabajo.Usuario.DesbloquearUsuario(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
