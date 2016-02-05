using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebAdressBook.Models;

namespace WebAdressBook.Controllers
{
    public class AdressBooksWebApiController : ApiController
    {
        private AdressModel db = new AdressModel();

        // GET: api/AdressBooksWebApi/5
        [ResponseType(typeof(AdressBook))]
        public IHttpActionResult GetAdressBook(int id)
        {
            AdressBook adressBook = db.AdressBooks.Find(id);
            if (adressBook == null)
            {
                return NotFound();
            }
            return Ok(adressBook);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AdressBookExists(int id)
        {
            return db.AdressBooks.Count(e => e.Id == id) > 0;
        }
    }
}