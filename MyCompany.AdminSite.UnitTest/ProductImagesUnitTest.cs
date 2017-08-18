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
    public class ProductImagesUnitTest
    {

        [TestMethod]
        public void Index()
        {
            ProductImagesController controller = new ProductImagesController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void ProductImagesDetails()
        {
            ProductImagesController controller = new ProductImagesController();
            ViewResult result = controller.Details(2) as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void ProductImagesCreate()
        {
            ProductImagesController controller = new ProductImagesController();
            ViewResult result = controller.Create() as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void ProductImagesEdit()
        {
            ProductImagesController controller = new ProductImagesController();
            ViewResult result = controller.Edit(2) as ViewResult;
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void ProductImagesDelete()
        {
            ProductImagesController controller = new ProductImagesController();
            ViewResult result = controller.Delete(2) as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
