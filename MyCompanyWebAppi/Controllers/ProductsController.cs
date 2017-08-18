using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using MyCompanyWebAppi.Models;

namespace MyCompanyWebAppi.Controllers
{
    public class ProductsController : ApiController
    {
        // GET: Products
        private MyCompanyEntities1 db = new MyCompanyEntities1();
        public IEnumerable<Product> Get()
        {
            var products = db.Products.AsEnumerable();
            return products.ToList();
        }
    }
}