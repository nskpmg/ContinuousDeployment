using ContinuousDeployment.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CDUnitTestProject1
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void AboutPageTest()
        {
            var homeController = new HomeController();
            var result = homeController.About();
        }
    }

}
