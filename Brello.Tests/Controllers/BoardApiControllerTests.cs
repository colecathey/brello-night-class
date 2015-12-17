using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Brello.Controllers;
using System.Web.Mvc;
using System.Web.Http.Results;

namespace Brello.Tests.Controllers
{
    [TestClass]
    public class BoardApiControllerTests
    {
        [TestMethod]
        public void BoardApiEnsureICanCallGetMethod()
        {
            // Arrange
            BoardApiController my_controller = new BoardApiController();
            string expected_output = "Hello, is it me you're looking for?";
            // Act
            string actual_output = my_controller.Get();
            // Assert
            Assert.AreEqual(expected_output, actual_output);
        }
    }
}
