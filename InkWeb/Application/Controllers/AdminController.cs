using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Pessoa;
using Services.Pessoa;

namespace Application.Controllers
{
    public class AdminController : Controller
    {
        private SUsuario sUsuario = new SUsuario();
        // GET: Admin
        [Authorize]
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home", new { area = "" });
        }

        // GET: Admin/GerenciarClientes

        [Authorize]
        public ActionResult GerenciarClientes()
        {
            return View(sUsuario.ListarUsuarios());
        }

        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
