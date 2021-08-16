using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Diagnostics;

namespace AutoTestProject
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
        public void TestToFindDisplayButton()
        {
            autoTestSession.FindElementByAccessibilityId("btnDisplay");
        }

        [TestMethod]
        public void TestToFindAZButton()
        {
            autoTestSession.FindElementByAccessibilityId("btnAZ");
        }

        [TestMethod]
        public void TestToFindZAButton()
        {
            autoTestSession.FindElementByAccessibilityId("btnZA");
        }

        [TestMethod]
        public void TestToFindAddButton()
        {
            autoTestSession.FindElementByAccessibilityId("btnAdd");
        }

        [TestMethod]
        public void TestToFindTextFieldsandComboBox()
        {
            autoTestSession.FindElementByAccessibilityId("textBoxName");
            autoTestSession.FindElementByAccessibilityId("textBoxID");
            autoTestSession.FindElementByAccessibilityId("textBoxEmail");
            autoTestSession.FindElementByAccessibilityId("textBoxDateOfBirth");
            autoTestSession.FindElementByAccessibilityId("textBoxSalary");
            autoTestSession.FindElementByAccessibilityId("comboBoxGender"); 
        }

        [TestMethod]
        public void TestToFindSearchTextFiels()
        {
            autoTestSession.FindElementByAccessibilityId("textBoxSearch");
        }

        [TestMethod]
        public void TestToFindListBox()
        {
            autoTestSession.FindElementByAccessibilityId("lsbEmployee");
        }

  
        [TestMethod]
        public void AutomationOfTheApp()
        {
            //Automation on display buttons.
            autoTestSession.FindElementByAccessibilityId("btnDisplay").Click();
            autoTestSession.FindElementByAccessibilityId("btnAZ").Click();
            autoTestSession.FindElementByAccessibilityId("btnZA").Click();

            //Automation on creating new employee.
            autoTestSession.FindElementByAccessibilityId("textBoxName").SendKeys("Panda Miniso");
            autoTestSession.FindElementByAccessibilityId("textBoxID").SendKeys("PM999");
            autoTestSession.FindElementByAccessibilityId("textBoxEmail").SendKeys("PandaMiniso@demo.com");
            autoTestSession.FindElementByAccessibilityId("textBoxDateOfBirth").SendKeys("15/12/1989");
            autoTestSession.FindElementByAccessibilityId("textBoxSalary").SendKeys("65000");
            autoTestSession.FindElementByAccessibilityId("comboBoxGender").Click();
            autoTestSession.FindElementByAccessibilityId("comboBoxGender").FindElementByName("Male").Click();
            autoTestSession.FindElementByAccessibilityId("btnAdd").Click();
            autoTestSession.FindElementByName("OK").Click();

            //Automation on deleting that employee.
            autoTestSession.FindElementByAccessibilityId("textBoxSearch").SendKeys("Panda Miniso");
            autoTestSession.FindElementByAccessibilityId("lsbEmployee").FindElementByName("Panda Miniso").Click();
            autoTestSession.FindElementByAccessibilityId("btnDelete").Click();
            autoTestSession.FindElementByName("OK").Click();

        }
    }
}
