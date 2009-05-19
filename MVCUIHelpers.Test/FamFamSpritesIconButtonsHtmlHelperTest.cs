using MVCUIHelpers.IconsAndButtons.FamFamSprites;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using System.Web.Routing;
using MVCUIHelpers;
using System;

namespace MVCUIHelpers.Tests
{


    /// <summary>
    ///This is a test class for FamFamSpritesIconButtonsHtmlHelperTest and is intended
    ///to contain all FamFamSpritesIconButtonsHtmlHelperTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FamFamSpritesIconButtonsHtmlHelperTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for mFamFamSpritesAndButtonsRepository
        ///</summary>
        [TestMethod()]
        [DeploymentItem("MVCUIHelpers.dll")]
        public void mFamFamSpritesAndButtonsRepositoryTest()
        {
            // Creation of the private accessor for 'Microsoft.VisualStudio.TestTools.TypesAndSymbols.Assembly' failed
            Assert.Inconclusive("Creation of the private accessor for \'Microsoft.VisualStudio.TestTools.TypesAndSy" +
                    "mbols.Assembly\' failed");
        }

        /// <summary>
        ///A test for FamFamSpritesLink
        ///</summary>
        [TestMethod()]
        public void FamFamSpritesLinkTest4()
        {
            HtmlHelper helper = null; // TODO: Initialize to an appropriate value
            string inText = string.Empty; // TODO: Initialize to an appropriate value
            FamFamSpritesEnum inIcon = new FamFamSpritesEnum(); // TODO: Initialize to an appropriate value
            string inUrl = string.Empty; // TODO: Initialize to an appropriate value
            object htmlAttributes = null; // TODO: Initialize to an appropriate value
            object innerSpanHtmlAttributes = null; // TODO: Initialize to an appropriate value
            object innerIconHtmlAttributes = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = FamFamSpritesIconButtonsHtmlHelper.FamFamSpritesLink(helper, inText, inIcon, inUrl, htmlAttributes, innerSpanHtmlAttributes, innerIconHtmlAttributes);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FamFamSpritesLink
        ///</summary>
        [TestMethod()]
        public void FamFamSpritesLinkTest3()
        {
            HtmlHelper helper = null; // TODO: Initialize to an appropriate value
            string inText = string.Empty; // TODO: Initialize to an appropriate value
            FamFamSpritesEnum inIcon = new FamFamSpritesEnum(); // TODO: Initialize to an appropriate value
            string inUrl = string.Empty; // TODO: Initialize to an appropriate value
            RouteValueDictionary htmlAttributes = null; // TODO: Initialize to an appropriate value
            RouteValueDictionary innerSpanHtmlAttributes = null; // TODO: Initialize to an appropriate value
            RouteValueDictionary innerIconHtmlAttributes = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = FamFamSpritesIconButtonsHtmlHelper.FamFamSpritesLink(helper, inText, inIcon, inUrl, htmlAttributes, innerSpanHtmlAttributes, innerIconHtmlAttributes);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FamFamSpritesLink
        ///</summary>
        [TestMethod()]
        public void FamFamSpritesLinkTest2()
        {
            HtmlHelper helper = null; // TODO: Initialize to an appropriate value
            string inText = string.Empty; // TODO: Initialize to an appropriate value
            FamFamSpritesEnum inIcon = new FamFamSpritesEnum(); // TODO: Initialize to an appropriate value
            string inUrl = string.Empty; // TODO: Initialize to an appropriate value
            object htmlAttributes = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = FamFamSpritesIconButtonsHtmlHelper.FamFamSpritesLink(helper, inText, inIcon, inUrl, htmlAttributes);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FamFamSpritesLink
        ///</summary>
        [TestMethod()]
        public void FamFamSpritesLinkTest1()
        {
            HtmlHelper helper = null; // TODO: Initialize to an appropriate value
            string inText = string.Empty; // TODO: Initialize to an appropriate value
            FamFamSpritesEnum inIcon = new FamFamSpritesEnum(); // TODO: Initialize to an appropriate value
            string inUrl = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = FamFamSpritesIconButtonsHtmlHelper.FamFamSpritesLink(helper, inText, inIcon, inUrl);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FamFamSpritesLink
        ///</summary>
        [TestMethod()]
        public void FamFamSpritesLinkTest()
        {
            HtmlHelper helper = null; // TODO: Initialize to an appropriate value
            string inText = string.Empty; // TODO: Initialize to an appropriate value
            FamFamSpritesEnum inIcon = new FamFamSpritesEnum(); // TODO: Initialize to an appropriate value
            string inUrl = string.Empty; // TODO: Initialize to an appropriate value
            Shared.Direction inDirection = new Shared.Direction(); // TODO: Initialize to an appropriate value
            object htmlAttributes = null; // TODO: Initialize to an appropriate value
            object innerSpanHtmlAttributes = null; // TODO: Initialize to an appropriate value
            object innerIconHtmlAttributes = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = FamFamSpritesIconButtonsHtmlHelper.FamFamSpritesLink(helper, inText, inIcon, inUrl, inDirection, htmlAttributes, innerSpanHtmlAttributes, innerIconHtmlAttributes);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FamFamSpritesForElement
        ///</summary>
        [TestMethod()]
        public void FamFamSpritesForElementTestAllParamsWithRouteValueDictionaries()
        {
            //Arrange
            HtmlHelper helper = null; 
            string inText = string.Empty; 
            FamFamSpritesEnum inIcon = new FamFamSpritesEnum(); 
            string inElement = "a";
            RouteValueDictionary htmlAttributes = new RouteValueDictionary(new { htmlAttrib = "htmlAttrib" });
            RouteValueDictionary innerSpanHtmlAttributes = null; // TODO: Initialize to an appropriate value
            RouteValueDictionary innerIconHtmlAttributes = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = FamFamSpritesIconButtonsHtmlHelper.FamFamSpritesForElement(helper, inText, inIcon, inElement, htmlAttributes, innerSpanHtmlAttributes, innerIconHtmlAttributes);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FamFamSpritesForElement
        ///</summary>
        [TestMethod()]
        public void FamFamSpritesForElementTestInnerSpanHtmlAndInnerIconHtmlAttributes()
        {
            //Arrange
            HtmlHelper helper = null; 
            string inText = string.Empty; 
            FamFamSpritesEnum inIcon = new FamFamSpritesEnum(); 
            string inElement = "a";
            object htmlAttributes = null;
            object innerSpanHtmlAttributes = new { id = "innerSpanHtmlAttributesID" };
            object innerIconHtmlAttributes = new { id = "innerIconHtmlAttributesID" };
            string expectedSpanID = "id=\"innerSpanHtmlAttributesID\"";
            string expectedIconID = "id=\"innerIconHtmlAttributesID\""; 
            
            //Act
            string actual = FamFamSpritesIconButtonsHtmlHelper.FamFamSpritesForElement(helper, inText, inIcon, inElement, htmlAttributes, innerSpanHtmlAttributes, innerIconHtmlAttributes);
            
            //Assert
            Assert.IsTrue(actual.Contains(expectedSpanID));
            Assert.IsTrue(actual.Contains(expectedIconID));
        }

        /// <summary>
        ///A test for FamFamSpritesForElement
        ///</summary>
        [TestMethod()]
        public void FamFamSpritesForElementTestHtmlAttributesObject()
        {
            //Arrange
            HtmlHelper helper = null;
            string inText = string.Empty; 
            FamFamSpritesEnum inIcon = new FamFamSpritesEnum(); 
            string inElement = "a"; 
            object htmlAttributes = new { id = "testID" };
            string expected = "id=\"testID\"";
            
            //Act
            string actual = FamFamSpritesIconButtonsHtmlHelper.FamFamSpritesForElement(helper, inText, inIcon, inElement, htmlAttributes);
            
            //Assert
            Assert.IsTrue(actual.Contains(expected));
        }

        /// <summary>
        ///A test for FamFamSpritesForElement
        ///</summary>
        [TestMethod()]
        public void FamFamSpritesForElementTestWithA()
        {
            //Arrange
            HtmlHelper helper = null; 
            string inText = string.Empty;
            FamFamSpritesEnum inIcon = new FamFamSpritesEnum();
            string inElement = "a";
            string expectedStart = "<a";
            string expectedEnd = "</a>";

            //Act
            string actual = FamFamSpritesIconButtonsHtmlHelper.FamFamSpritesForElement(helper, inText, inIcon, inElement);
            
            //Assert
            Assert.IsTrue(actual.StartsWith(expectedStart));
            Assert.IsTrue(actual.EndsWith(expectedEnd));
        }

        /// <summary>
        ///A test for FamFamSpritesForElement
        ///</summary>
        [TestMethod()]
        public void FamFamSpritesForElementTestWithEmptyElement()
        {
            //Arrange
            HtmlHelper helper = null;
            string inText = string.Empty;
            FamFamSpritesEnum inIcon = new FamFamSpritesEnum();
            string inElement = string.Empty;
            bool failed = false;

            //Act
            try
            {
                string actual = FamFamSpritesIconButtonsHtmlHelper.FamFamSpritesForElement(helper, inText, inIcon, inElement);
            }
            catch (Exception)
            {
                failed = true;

            }

            //Assert
            Assert.IsTrue(failed);
        }

        /// <summary>
        ///A test for FamFamSpritesButton
        ///</summary>
        [TestMethod()]
        public void FamFamSpritesButtonTestPassedHtmlAttributes()
        {
            //Arrange
            HtmlHelper helper = null;
            string inText = string.Empty;
            FamFamSpritesEnum inIcon = new FamFamSpritesEnum();
            object htmlAttributes = new { id = "testID" };
            string expected = "id=\"testID\"";

            //Act
            string actual = FamFamSpritesIconButtonsHtmlHelper.FamFamSpritesButton(helper, inText, inIcon, htmlAttributes);

            //Assert
            Assert.IsTrue(actual.Contains(expected));
        }

        /// <summary>
        ///A test for FamFamSpritesButton
        ///</summary>
        [TestMethod()]
        public void FamFamSpritesButtonTestPassedButtonText()
        {
            //Arrange
            HtmlHelper helper = null;
            string inText = "Button Text";
            FamFamSpritesEnum inIcon = new FamFamSpritesEnum();
            string expected = string.Format(">{0}</span>", inText);
            //Act
            string actual = FamFamSpritesIconButtonsHtmlHelper.FamFamSpritesButton(helper, inText, inIcon);

            //Assert
            Assert.IsTrue(actual.Contains(expected));
        }

        /// <summary>
        ///A test for FamFamSpritesButton
        ///</summary>
        [TestMethod()]
        public void FamFamSpritesButtonTestPassedAttributesObjectsForInnerSpan()
        {
            //Arrange
            HtmlHelper helper = null;
            string inText = string.Empty;
            FamFamSpritesEnum inIcon = new FamFamSpritesEnum();
            Shared.ButtonType inButtonType = new Shared.ButtonType();
            Shared.Direction inDirection = new Shared.Direction();
            object htmlAttributes = null;
            object innerSpanHtmlAttributes = new { id = "idTest" };
            string expected = "id=\"idTest\"";

            //Act
            string actual = FamFamSpritesIconButtonsHtmlHelper.FamFamSpritesButton(helper,
                inText, inIcon, inButtonType, inDirection, htmlAttributes, innerSpanHtmlAttributes);

            //Assert
            Assert.IsTrue(actual.Contains(expected));
        }

        /// <summary>
        ///A test for FamFamSprites
        ///</summary>
        [TestMethod()]
        public void FamFamSpritesTestBasic()
        {
            //Arrange
            HtmlHelper helper = null;
            FamFamSpritesEnum inIcon = FamFamSpritesEnum.accept;
            string expected = MVCUIHelpers.Shared.GetDescription<FamFamSpritesEnum>(inIcon);

            //Act
            string actual = FamFamSpritesIconButtonsHtmlHelper.FamFamSprites(helper, inIcon);

            //Assert
            Assert.IsTrue(actual.Contains(expected));
        }

        /// <summary>
        ///A test for FamFamSprites
        ///</summary>
        [TestMethod()]
        public void FamFamSpritesTestPassedHtmlAttributes()
        {
            //Arrange
            HtmlHelper helper = null;
            FamFamSpritesEnum inIcon = new FamFamSpritesEnum();
            object htmlAttributes = new { id = "idTest" }; // TODO: Initialize to an appropriate value
            string expected = "id=\"idTest\"";

            //Act
            string actual = FamFamSpritesIconButtonsHtmlHelper.FamFamSprites(helper, inIcon, htmlAttributes);

            //Assert
            Assert.IsTrue(actual.Contains(expected));
        }

        /// <summary>
        ///A test for FamFamSprites
        ///</summary>
        [TestMethod()]
        public void FamFamSpritesTestRouteValueDictionaryParameter()
        {
            //Arrange
            HtmlHelper helper = null;
            FamFamSpritesEnum inIcon = new FamFamSpritesEnum(); // TODO: Initialize to an appropriate value
            RouteValueDictionary htmlAttributes = new RouteValueDictionary(new { id = "testID" }); // TODO: Initialize to an appropriate value
            string expected = "id=\"testID\"";

            //Act
            string actual = FamFamSpritesIconButtonsHtmlHelper.FamFamSprites(helper, inIcon, htmlAttributes);

            //Assert
            Assert.IsTrue(actual.Contains(expected));
        }
    }
}
