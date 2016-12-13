using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;

namespace DENETİM.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        //public ActionResult Index()
        //{
        //    return View();
        //}
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(KULLANICI k)
        {
            if (ModelState.IsValid)
            {
                using (DENETİMEntities1 de = new DENETİMEntities1())
                {
                    var v = de.KULLANICI.Where(a=> a.KULLANICI_TC.Equals(k.KULLANICI_TC) && a.KULLANICI_SIFRE.Equals(k.KULLANICI_SIFRE)).FirstOrDefault();
                    if (v != null)
                    {
                        Session["KullanıcıID"]=v.ID.ToString();
                        Session["KullanıcıAdı"]=v.KULLANICI_AD.ToString();
                        return RedirectToAction("AfterLogin");
                    }
                }
            }
            return View(k);
        }
        public ActionResult AfterLogin()
        {
            if (Session["KullanıcıAdı"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
