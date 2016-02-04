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
    public class MainController : Controller
    {
        private WebAdressBookEntities db = new WebAdressBookEntities();

        // GET: Main
        public ActionResult Main()
        {
            return View(db.AdressBook.ToList().OrderBy(x => x.Subdivision));
        }

        // GET: Main/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdressBook adressBook = db.AdressBook.Find(id);
            if (adressBook == null)
            {
                return HttpNotFound();
            }
            return View(adressBook);
        }

        // GET: Main/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Main/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FullName,Phone,EMail,Subdivision,StatePosition")] AdressBook adressBook)
        {
            if (ModelState.IsValid)
            {
                db.AdressBook.Add(adressBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adressBook);
        }

        // GET: Main/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdressBook adressBook = db.AdressBook.Find(id);
            if (adressBook == null)
            {
                return HttpNotFound();
            }
            return View(adressBook);
        }


        // POST: Main/Login
        [HttpPost]       
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                if (user.Login == "test1" && user.Password == "test2")
                {
                    return RedirectToAction("Main");
                }                
            }
            return View();
        }

        // POST: Main/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FullName,Phone,EMail,Subdivision,StatePosition")] AdressBook adressBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adressBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adressBook);
        }

        // GET: Main/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AdressBook adressBook = db.AdressBook.Find(id);
            if (adressBook == null)
            {
                return HttpNotFound();
            }
            return View(adressBook);
        }

        // POST: Main/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AdressBook adressBook = db.AdressBook.Find(id);
            db.AdressBook.Remove(adressBook);
            db.SaveChanges();
            return RedirectToAction("Index");
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
