namespace HttpErrors.Mvc.Tests.Controllers
{
    using System;
    using System.Web.Mvc;
    using HttpErrors.Mvc.Controllers;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Moq;

    [TestClass]
    public sealed class ErrorsControllerTests
    {
        [TestMethod]
        public void Forbidden()
        {
            // Arrange
            var context = new Mock<ControllerContext>();
            context.Setup(x => x.HttpContext.Response.StatusCode).Verifiable();

            using (var controller = new ErrorsController())
            {
                controller.ControllerContext = context.Object;

                // Act
                var result = controller.Forbidden() as ViewResult;

                // Assert
                Assert.IsNotNull(result);
                context.VerifySet(x => x.HttpContext.Response.StatusCode = 403);
            }
        }

        [TestMethod]
        public void NotFound()
        {
            // Arrange
            var context = new Mock<ControllerContext>();
            context.Setup(x => x.HttpContext.Response.StatusCode).Verifiable();

            using (var controller = new ErrorsController())
            {
                controller.ControllerContext = context.Object;

                // Act
                var result = controller.NotFound() as ViewResult;

                // Assert
                Assert.IsNotNull(result);
                context.VerifySet(x => x.HttpContext.Response.StatusCode = 404);
            }
        }

        [TestMethod]
        public void Other()
        {
            // Arrange
            var context = new Mock<ControllerContext>();
            context.Setup(x => x.HttpContext.Response.StatusCode).Verifiable();

            using (var controller = new ErrorsController())
            {
                controller.ControllerContext = context.Object;

                // Act
                var result = controller.Other(null) as ViewResult;

                // Assert
                Assert.IsNotNull(result);
                context.VerifySet(x => x.HttpContext.Response.StatusCode = 500);
            }
        }

        [TestMethod]
        public void ErrorController_Other_Code()
        {
            // Arrange
            var context = new Mock<ControllerContext>();
            context.Setup(x => x.HttpContext.Response.StatusCode).Verifiable();

            using (var controller = new ErrorsController())
            {
                controller.ControllerContext = context.Object;

                // Act
                var result = controller.Other(400) as ViewResult;

                // Assert
                Assert.IsNotNull(result);
                context.VerifySet(x => x.HttpContext.Response.StatusCode = 400);
            }
        }
    }
}
