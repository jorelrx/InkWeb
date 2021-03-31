using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Models;
using Services.Servico;

namespace Application.Controllers
{
    public class ClienteController : Controller
    {
        private SServico sServico = new SServico();
        private ActionResult SaveServico(MServico mServico)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    sServico.SaveService(mServico);
                    return RedirectToAction("Index", "Home");
                }
                return View(mServico);
            }
            catch
            {
                return View(mServico);
            }
        }
        private ActionResult GetViewServiceToID(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MServico mServico = sServico.ListService((long)id);
            if (mServico == null)
            {
                return HttpNotFound();
            }
            return View(mServico);
        }

        public ActionResult PedidosPendentes()
        {
            return View(sServico.ListServices());
        }

        public ActionResult PedidosConfirmados()
        {
            return View(sServico.ListServices());
        }

        public ActionResult Details(long id)
        {
            return GetViewServiceToID(id);
        }

        public ActionResult Edit(long id)
        {
            return View(sServico.ListService(id));
        }

        public ActionResult Delete(long? id)
        {
            return GetViewServiceToID(id);
        }
        // POST: Servico/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            try
            {
                MServico mServico = sServico.DeleteSerice(id);
                TempData["Message"] = "Serviço " + mServico.ID + " foi removido";
                return RedirectToAction("PedidosPendentes");
            }
            catch
            {
                return View();
            }
        }
    }
}