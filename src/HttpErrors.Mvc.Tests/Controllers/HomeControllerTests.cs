namespace HttpErrors.Mvc.Tests.Controllers
{
    using System;
    using System.Web.Mvc;
    using HttpErrors.Mvc.Controllers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public sealed class HomeControllerTests
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Forbidden()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Forbidden() as HttpStatusCodeResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(403, result.StatusCode);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Other()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            controller.Other();
        }
    }
}
