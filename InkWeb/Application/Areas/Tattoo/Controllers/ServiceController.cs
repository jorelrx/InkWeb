using Models.Tattoo;
using Services.Tattoo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Application.Areas.Tattoo.Controllers
{
    [Authorize(Roles ="Administrador, Cliente")]
    public class ServiceController : Controller
    {
        private SServico sServico = new SServico();
        public ActionResult PedidosPendentes()
        {
            return View(sServico.ListServices());
        }

        public ActionResult PedidosConfirmados()
        {
            return View(sServico.ListServices());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MServico mServico)
        {
            return SaveServico(mServico);
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
                MServico mServico = sServico.DeleteService(id);
                TempData["Message"] = "Serviço " + mServico.ID + " foi removido";
                return RedirectToAction("PedidosPendentes");
            }
            catch
            {
                return View();
            }
        }
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
    }
}