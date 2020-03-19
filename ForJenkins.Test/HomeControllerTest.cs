using ForJenkins.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;

namespace ForJenkins.Test
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Employees()
        {
            // Arrange
           HomeController controller = new HomeController();

            // Act
            System.Web.Mvc.ViewResult result = controller.Index() as System.Web.Mvc.ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
        [TestMethod]
        public void sayHello()
        {
            var res = "sayHello";
            Assert.AreEqual("sayHello", res);

        }
    }
}
