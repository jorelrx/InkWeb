using Services.Servico;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;

namespace Application.Controllers
{
    public class HomeController : Controller
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
        // GET: Home            
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Agendamento(long? id)
        {
            if (id != null)
            {
                MServico mServico = sServico.ListService((long)id);
                return View(mServico);
            }
            else
            {
                MServico mServico = new MServico();
                return View(mServico);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Agendamento(MServico mServico)
        {
            return SaveServico(mServico);
        }
    }
}