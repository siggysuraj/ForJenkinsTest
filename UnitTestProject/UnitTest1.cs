using ForJenkins.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = "Hello world";
            Assert.AreEqual("Hello world", result);

        }
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
