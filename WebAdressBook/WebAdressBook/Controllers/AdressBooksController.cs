using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebAdressBook.Models;

namespace WebAdressBook.Controllers
{
    public class AdressBooksController : Controller
    {
        private AdressModel db = new AdressModel();

        // GET: AdressBooks
        public ActionResult Main()
        {
            return View(db.AdressBooks.OrderBy(i => i.Subdivision).ThenBy(n => n.FullName).ToList<AdressBook>());
        }


        public ActionResult Login(User us)
        {
            ViewBag.error = "";

            if (us.Login == null && us.Password == null) return View();           
            
            if (us.Login == "test1" && us.Password == "test2")
            {
                return RedirectToAction("Main", "AdressBooks");
            }

            if (us.Password != "" && us.Login != "")
            {
                ViewBag.error = "Неверная комбинация логина и пароля";
            }

            return View();
        }

        public ActionResult AbID()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetAdressBookItem(AbID abID)
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


    }
}
