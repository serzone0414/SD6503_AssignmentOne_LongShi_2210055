using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace AutoTesting
{
    [TestClass]

    public class ApplicationTests
    {
        static WindowsDriver<WindowsElement> autoTestSession;

        [ClassInitialize]

        public static void PrepareForTestingTheApp(TestContext testContext)
        {
            Debug.WriteLine("Class Initialize");

            AppiumOptions appium = new AppiumOptions();
            appium.AddAdditionalCapability("app", @"C:\Users\serzo\source\repos\SD6503_Assignment_One\SD6503_Assignment_One\bin\Debug\SD6503_Assignment_One.exe");
            autoTestSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), appium);

        }

        [ClassCleanup]

        public static void CleanUpAfterTests()
        {
            Debug.WriteLine("Class Cleanup");
            if (autoTestSession != null)
            {
                autoTestSession.Quit();
            }
        }

        [TestMethod]
            public void TestDisplayButton()
            {
                autoTestSession.FindElementByAccessibilityId("btnDisplay").Click();
                //autoTestSession.FindElementByAccessibilityId("btnAZ").Click();
                //autoTestSession.FindElementByAccessibilityId("btnZA").Click();

        }


        }
}
