using MvcBasic_Clone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_Clone.Controllers
{

    public class FormController : Controller
    {
        private CarContext db = new CarContext();
        // GET: Form
        public ActionResult Index()
        {
            var users = db.Infoes.ToList();
            return View(users);
        }
        [HttpGet]
        public ActionResult UserInfo()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserInfo([Bind(Include = "Id,Name,Phone,Email,Gender")] Info info)
        {
            if (ModelState.IsValid)
            {
                db.Infoes.Add(info);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(info);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserData(string name, string phone, string email, string gender)
        {
            Info info = new Info { Name = name, Phone = phone, Email = email, Gender = gender };
            db.Infoes.Add(info);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}