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
        private SUsuario sUSuario = new SUsuario();
        public ActionResult PedidosPendentes()
        {
            return View(sUSuario.ListServices());
        }

        public ActionResult PedidosConfirmados()
        {
            return View(sUSuario.ListServices());
        }

        public ActionResult GerenciarClientes()
        {
            return View(sUSuario.ListarUsuarios());
        }
    }
}