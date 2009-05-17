using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCUIHelpers.Sample;
using MVCUIHelpers.Sample.Controllers;

namespace MVCUIHelpers.Sample.Tests.Controllers
{
    [TestClass]
    public class IconsAndButtonsControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            IconsAndButtonsController controller = new IconsAndButtonsController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
     
        [TestMethod]
        public void jQueryUI()
        {
            // Arrange
            IconsAndButtonsController controller = new IconsAndButtonsController();

            // Act
            ViewResult result = controller.jQueryUI() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void jQueryUIAll()
        {
            // Arrange
            IconsAndButtonsController controller = new IconsAndButtonsController();

            // Act
            ViewResult result = controller.jQueryUIAll() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void FamFamSprites()
        {
            // Arrange
            IconsAndButtonsController controller = new IconsAndButtonsController();

            // Act
            ViewResult result = controller.FamFamSprites() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void FamFamSpritesAll()
        {
            // Arrange
            IconsAndButtonsController controller = new IconsAndButtonsController();

            // Act
            ViewResult result = controller.FamFamSpritesAll() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
