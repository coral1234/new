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
    public class CategoriesUnitTest
    {
        [TestMethod]
        public void Index()
        {
            CategoriesController controller = new CategoriesController();
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public void CategoriesDetails()
        {
            CategoriesController controller = new CategoriesController();
            ViewResult result = controller.Details(2) as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CategoriesCreate()
        {
            CategoriesController controller = new CategoriesController();
            ViewResult result = controller.Create() as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]

        public void CategoriesEdit()
        {
            CategoriesController controller = new CategoriesController();
            ViewResult result = controller.Edit(2) as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CategoriesDelete()
        {
            CategoriesController controller = new CategoriesController();
            ViewResult result = controller.Delete(2) as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
