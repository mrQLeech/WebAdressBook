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
        public HttpResponseMessage GetAdressBook(int id)
        {
            AdressBook adressBook = db.AdressBooks.Find(id);
            if (adressBook == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Item not found");
            }
            return Request.CreateResponse(HttpStatusCode.OK, adressBook);
        }

        [HttpPost]
        public HttpResponseMessage GetAdressBookItem(AbID abID)
        {
            AdressBook adressBook = db.AdressBooks.Find(abID.abID);
            if (adressBook == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, new KeyNotFoundException("Item with id = " + abID.abID + " not found"));
            }
            return Request.CreateResponse(HttpStatusCode.OK, adressBook);
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