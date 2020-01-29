using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.PhantomJS;

namespace Test.FuntionalTestFramework
{
    public static class Browser
    {
        static IWebDriver webDriver = null;

        public static void Init()
        {
            //string geckoDriver = Environment.GetEnvironmentVariable("GeckoWebDriver");

            //if (geckoDriver == null)
                webDriver = new FirefoxDriver();
           // else
            //    webDriver = new FirefoxDriver(geckoDriver);

        }
        public static void GoTo(string url)
        {
            webDriver.Url = url;
        }
        public static ISearchContext Driver
        {
            get { return webDriver;  }
        }

        public static void Close()
        {
            webDriver.Close();
        }

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static void FillElement(string elementName, string fillText)
        {
            webDriver.FindElement(By.Id(elementName)).Clear();
            webDriver.FindElement(By.Id(elementName)).SendKeys(fillText);

        }

        public static void ExecuteElement(string elementName)
        {
            webDriver.FindElement(By.Id(elementName)).Click();
        }
    }
}
