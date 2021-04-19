using Models.Gerenciamento;
using Services.Gerenciamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Application.Areas.Gerenciamento.Controllers
{
    public class AccountController : Controller
    {
        private SUsuario sUsuario = new SUsuario();
        private SRole sRole = new SRole();
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
                MUsuario user = sUsuario.ValidarUsuario(loginViewModel.Username, loginViewModel.Senha);
                if (user == null)
                {
                    ModelState.AddModelError("", "Nome ou senha inválido(s).");
                }
                else
                {
                    var ticket = FormsAuthentication.Encrypt(new FormsAuthenticationTicket(1, user.ToString(), DateTime.Now, DateTime.Now.AddHours(12), false, sRole.ListRole(user.IdPerfil).Nome));
                    var cookie = new HttpCookie(FormsAuthentication.FormsCookieName, ticket);
                    Response.Cookies.Add(cookie);
                    if (Url.IsLocalUrl(returnURL))
                    {
                        return Redirect(returnURL);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home", new { Area = "Home", id = user.ID });
                    }
                }
            }
            return View(loginViewModel);
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home", new { Area = "Home" });
        }
    }
}