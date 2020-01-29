using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Firefox;
//using OpenQA.Selenium.IE;
//using OpenQA.Selenium.Remote;
//using OpenQA.Selenium.PhantomJS;
using Test.FuntionalTestFramework;

namespace SimpleCRM.UnitTests
{

    /// <summary>
    /// Summary description for SeleniumTest
    /// </summary>
    [TestClass]
    public class SeleniumTests
    {

        private string baseURL = "http://localhost:5555/";
        //private RemoteWebDriver driver;
        private string browser;

        //[TestMethod]
        //[TestCategory("Selenium")]
        //[Priority(1)]
        //[Owner("FireFox")]
        //public void Go_To_HomePage()
        //{
        //    // Arange and Act
        //    Pages.HomePage.GoTo();
        //    Assert.IsTrue(Pages.HomePage.IsAt());
        //}

        [TestMethod]
        [TestCategory("Selenium")]
        [Priority(1)]
        [Owner("FireFox")]
//        [Ignore]
        public void RegisterUser_Any()
        {
           
            // Arrange
            Pages.RegistrationPage.GoTo();

            // Act
            Pages.RegistrationPage.RegisterUser("Ron Vincent");

            // Assert
            Assert.IsTrue(Pages.RegistrationPage.IsAt());
         
        }

        [TestCleanup()]
        public void MyTestCleanup()
        {
            Browser.Close();
            //if (driver != null)
            //    driver.Quit();
        }

        [TestInitialize()]
        public void MyTestInitialize()
        {
        }

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
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion


    }
}
