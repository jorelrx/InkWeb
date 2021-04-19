using Services.Gerenciamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Application.Areas.Gerenciamento.Controllers
{
    public class ClienteController : Controller
    {
        private SUsuario sUSuario = new SUsuario();
        public ActionResult PedidosPendentes(long id)
        {
            return View(sUSuario.ListServicesP(id));
        }
        public ActionResult PedidosConfirmados(long id)
        {
            return View(sUSuario.ListServicesP(id));
        }
    }
}