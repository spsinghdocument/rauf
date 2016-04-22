using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPISample.Models;

namespace WebAPISample.Controllers
{
    public class BooksController : ApiController
    {
        // GET api/values
        public IEnumerable<Book> Get()
        {
            using (SampleDbEntities entities = new SampleDbEntities())
            {
                return entities.Books.ToList<Book>();
            }
        }

        // GET api/values/5
        public Book Get(int id)
        {
            using (SampleDbEntities entities = new SampleDbEntities())
            {
                return entities.Books.SingleOrDefault<Book>(b => b.ID == id);
            }
        }

        // POST api/values
        public HttpResponseMessage Post(Book value)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (SampleDbEntities entities = new SampleDbEntities())
                    {
                        entities.Books.AddObject(value);
                        entities.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK);
                    }
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, "Model state is invalid");
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        // PUT api/values/5
        public HttpResponseMessage Put(int id, Book value)
        {
            try
            {
                using (SampleDbEntities entities = new SampleDbEntities())
                {
                    Book foundBook = entities.Books.SingleOrDefault<Book>(b => b.ID == id);
                    foundBook.BookName = value.BookName;
                    entities.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        // DELETE api/values/5
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (SampleDbEntities entities = new SampleDbEntities())
                {
                    Book foundBook = entities.Books.SingleOrDefault<Book>(b => b.ID == id);
                    entities.Books.DeleteObject(foundBook);
                    entities.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}