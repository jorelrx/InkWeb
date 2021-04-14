using Models.Gerenciamento;
using Services.Gerenciamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Application.Areas.Gerenciamento.Controllers
{
    public class RoleController : Controller
    {
        private SRole sRole = new SRole();
        public ActionResult Index()
        {
            return View(sRole.ListRoles());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MRole mRole)
        {
            return SaveRole(mRole);
        }

        public ActionResult Details(long id)
        {
            return GetViewRoleToID(id);
        }

        public ActionResult Edit(long id)
        {
            return View(sRole.ListRole(id));
        }

        public ActionResult Delete(long? id)
        {
            return GetViewRoleToID(id);
        }
        // POST: Servico/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id)
        {
            try
            {
                MRole mRole = sRole.DeleteRole(id);
                TempData["Message"] = "Serviço " + mRole.Nome + " foi removido";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        private ActionResult SaveRole(MRole mRole)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    sRole.SaveRole(mRole);
                    return RedirectToAction("Index", "Home");
                }
                return View(mRole);
            }
            catch
            {
                return View(mRole);
            }
        }
        private ActionResult GetViewRoleToID(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MRole mRole = sRole.ListRole((long)id);
            if (mRole == null)
            {
                return HttpNotFound();
            }
            return View(mRole);
        }
    }
}