using Models.Gerenciamento;
using Services.Gerenciamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Application.Areas.Gerenciamento.Controllers
{
    [Authorize(Roles = "Administrador, Cliente")]
    public class UsuarioController : Controller
    {
        // GET: Gerenciamento/Usuario
        private SUsuario sUsuario = new SUsuario();

        [AllowAnonymous]
        public ActionResult Create()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MUsuario mUsuario)
        {
            if (mUsuario.Instagram == null)
            {
                mUsuario.Instagram = "";
            }
            mUsuario.IdPerfil = 2;
            return SaveUsuario(mUsuario);
        }

        public ActionResult Details(long id)
        {
            return View(sUsuario.ListUsuario(id));
        }

        public ActionResult Edit(long id)
        {
            return View(sUsuario.ListUsuario(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(MUsuario mUsuario)
        {
            return SaveUsuario(mUsuario);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(MUsuario mUsuario)
        {
            return SaveUsuario(mUsuario);
        }

        private ActionResult SaveUsuario(MUsuario mUsuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    sUsuario.SaveUsuario(mUsuario);
                    if (mUsuario.ID == 0)
                    {
                        return RedirectToAction("Index", "Home", new { Area = "Home" });
                    }
                    else
                    {
                        return RedirectToAction("Details", "Usuario", new { Area = "Gerenciamento", id = mUsuario.ID });
                    }
                }
                return View(mUsuario);
            }
            catch
            {
                return View(mUsuario);
            }
        }
    }
}