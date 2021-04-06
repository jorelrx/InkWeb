using Application.Models;
using Models.Pessoa;
using Services.Pessoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Application.Controllers
{
    public class AccountController : Controller
    {
        private SUsuario sUsuario = new SUsuario();
        private ActionResult SaveUsuario(MUsuario mUsuario)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    sUsuario.SaveUsuario(mUsuario);
                    return RedirectToAction("Index", "Home");
                }
                return View(mUsuario);
            }
            catch
            {
                return View(mUsuario);
            }
        }
        public ActionResult Login()
        {
            //ViewBag.returnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel loginViewModel, string returnURL)
        {
            if (ModelState.IsValid)
            {

            }
            else
            { 
                return View(loginViewModel); 
            }

            var achou = (loginViewModel.Username == "joel" && loginViewModel.Senha == "123");

            if (achou)
            {
                FormsAuthentication.SetAuthCookie(loginViewModel.Username, false);
                    if (Url.IsLocalUrl(returnURL))
                    {
                        return Redirect(returnURL);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home");
                    }
            }
            else
            {
                ModelState.AddModelError("", "Login Inválido.");
            }
            return View(loginViewModel);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult NewAccount()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NewAccount(MUsuario mUsuario)
        {
            return SaveUsuario(mUsuario);
        }
    }
}