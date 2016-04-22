using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AttributeRouting;
using AttributeRouting.Web.Http;


namespace MvcApplication1.Controllers
{
   // [ApiAuthenticationFilter]
    public class arifController : ApiController
    {
        Inventory_MVC2Entities db;
        public arifController()
        {
            db = new Inventory_MVC2Entities();
        }

        Product[] products = new Product[] 
        { 
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 }, 
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M }, 
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M } ,
              new Product { Id = 4, Name = "saurabh", Category = "singh", Price = 16.99M } 
        };

       // [GET("allproducts")]
      
        public HttpResponseMessage Get()
        {
           

            return Request.CreateResponse(HttpStatusCode.OK, db.nodejs.ToList());
            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Products not found");
        }

  
    
        public HttpResponseMessage Get(int id)
        {
            var product = db.nodejs.Where((p) => p.MOBILENO == id);
            if (product == null)
            {
                var message = string.Format("Product with id = {0} not found", id);
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, message);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, product);
            }
        }

        public HttpResponseMessage Post([FromBody] nodej t1)
        {
            var firstName = t1.FirstName;
            var midileName = t1.MIDILENAME;
            var lastname = t1.LastName;
            var product = db.nodejs.Where((p) => p.MOBILENO == 45);
            return Request.CreateResponse(HttpStatusCode.OK, product);
           // return Request.CreateResponse(HttpStatusCode.OK, db.nodejs.ToList());
         
        }

    }
}
