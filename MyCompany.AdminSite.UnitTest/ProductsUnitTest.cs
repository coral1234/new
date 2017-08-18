using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCompany.AdminSite;
using MyCompany.AdminSite.Controllers;
using MyCompany.AdminSite.Models;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyCompany.AdminSite.UnitTest
{
    [TestClass]
    public class ProductsUnitTest
    {
        [TestMethod]
        public void Index()
        {
            ProductsController controller = new ProductsController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void ProductsDetails()
        {
            ProductsController controller = new ProductsController();
            ViewResult result = controller.Details(2) as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductsCreate()
        {
            ProductsController controller = new ProductsController();
            ViewResult result = controller.Create() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductsEdit()
        {
            ProductsController controller = new ProductsController();
            ViewResult result = controller.Edit(2) as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ProductsDelete()
        {
            ProductsController controller = new ProductsController();
            ViewResult result = controller.Delete(2) as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
