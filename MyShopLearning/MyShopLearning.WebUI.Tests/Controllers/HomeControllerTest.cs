using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyShopLearning.Core.Contracts;
using MyShopLearning.Core.Models;
using MyShopLearning.Core.ViewModels;
using MyShopLearning.WebUI.Controllers;
using System.Linq;
using System.Web.Mvc;

namespace MyShopLearning.WebUI.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void IndexPageDoesReturnProducts()
        {
            IRepository<Product> productContext = new Mocks.MockContext<Product>();
            IRepository<ProductCategory> productCategroyContext = new Mocks.MockContext<ProductCategory>();
            HomeController controller = new HomeController(productContext, productCategroyContext);

            var result = controller.Index() as ViewResult;
            var viewModle = (ProductListViewModel)result.ViewData.Model;

            Assert.AreEqual(1, viewModle.Products.Count());
        }
    }
}
