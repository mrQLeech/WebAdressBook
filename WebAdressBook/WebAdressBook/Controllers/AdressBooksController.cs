using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
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
            return View(db.AdressBooks.OrderBy(i => i.Subdivision).ToList<AdressBook>());
        }


        public ActionResult Login(User us)
        {     
            if (us.Login == "test1" && us.Password == "test2")
            {
                return RedirectToAction("Main", "AdressBooks");
            }

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
