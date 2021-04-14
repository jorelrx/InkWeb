using Services.Gerenciamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Application.Areas.Gerenciamento.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class AdminController : Controller
    {
        private SUsuario sUsuario = new SUsuario();
        // GET: Admin
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home", new { area = "" });
        }

        // GET: Admin/GerenciarClientes
        public ActionResult GerenciarClientes()
        {
            return View(sUsuario.ListarUsuarios());
        }
    }
}