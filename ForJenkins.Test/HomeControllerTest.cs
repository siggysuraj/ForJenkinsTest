using ForJenkins.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            ViewResult result = controller.Index() as ViewResult;

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
