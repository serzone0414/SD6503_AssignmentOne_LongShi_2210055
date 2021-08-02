using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SD6503_Assignment_One;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

namespace AssignmentOneUnitTests
{
    [TestClass]
    public class EmployeeUnitTests
    {
        /*
         * Test to ensure that Name has been set up correctly for Employee class data fields.
         */
         
        [TestMethod]
        public void TestEmployeeName()
        {
            Employee employee = new Employee();
            employee.Name = "Bob";
            Assert.AreEqual("Bob", employee.Name);
        }

        /*
         * Test to ensure that Id has been set up correctly for Employee class data fields.
         */
        [TestMethod]
        public void TestEmployeeId()
        {
            Employee employee = new Employee();
            employee.Id = "Bb";
            Assert.AreEqual("Bb", employee.Id);
        }

        /*
         * Test to ensure that Date of Birth has been set up correctly for Employee class data fields.
         */
        [TestMethod]
        public void TestEmployeeDateOfBirth()
        {
            Employee employee = new Employee();
            employee.DateOfBirth = "19/2/1970";
            Assert.AreEqual("19/2/1970", employee.DateOfBirth);
        }

        /*
         * Test to ensure that Email has been set up correctly for Employee class data fields.
         */
        [TestMethod]
        public void TestEmployeeEmail()
        {
            Employee employee = new Employee();
            employee.Email = "Bob@demo.co.nz";
            Assert.AreEqual("Bob@demo.co.nz", employee.Email);
        }

        /*
         * Test to ensure that Salary has been set up correctly for Employee class data fields.
         */
        [TestMethod]
        public void TestEmployeeSalary()
        {
            Employee employee = new Employee();
            employee.Salary = 60000;
            Assert.AreEqual(60000, employee.Salary);
        }

        /*
         * Test to ensure that Gender has been set up correctly for Employee class data fields.
         */
        [TestMethod]
        public void TestEmployeeGender()
        {
            Employee employee = new Employee();
            employee.Gender = "Male";
            Assert.AreEqual("Male", employee.Gender);
        }

        /*
         * Test to ensure that default constructor has been set up correctly for Employee class.
         */
        [TestMethod]
        public void TestEmployeeDefaultConstructor()
        {
            Employee employee = new Employee();
            Assert.AreEqual("unknown", employee.Name, "Name Fail");
            Assert.AreEqual("unknown", employee.Id, "Id Fail");
            Assert.AreEqual("unknown", employee.DateOfBirth, "DateOfBirth Fail");
            Assert.AreEqual("unknown", employee.Email, "Email Fail");
            Assert.AreEqual(0, employee.Salary, "Salary Fail");
            Assert.AreEqual("unknown", employee.Gender, "Gender Fail");
        }


        /*
         * Test to ensure that parameterized constructor has been set up correctly for Employee class.
         */
        [TestMethod]
        public void TestEmployeeParameterizedConstructor()
        {
            Employee employee = new Employee("Bob", "Bb", "13/4/1970", "Bob@demo.co.nz", 70000, "Male");
            Assert.AreEqual("Bob", employee.Name, "Name Fail");
            Assert.AreEqual("Bb", employee.Id, "Id Fail");
            Assert.AreEqual("13/4/1970", employee.DateOfBirth, "DateOfBirth Fail");
            Assert.AreEqual("Bob@demo.co.nz", employee.Email, "Email Fail");
            Assert.AreEqual(70000, employee.Salary, "Salary Fail");
            Assert.AreEqual("Male", employee.Gender, "Gender Fail");
        }

        /*
         * Test to ensure that overide method 'ToString' is working as expected in Employee class.
         */
        [TestMethod]
        public void TestEmployeeToString()
        {
            Employee employee = new Employee();
            employee.Name = "Bob";
            Assert.AreEqual("Bob", employee.ToString());
        }
    }

    [TestClass]
    public class FilterUnitTests
    {
        /*
         * Test to ensure that sorting Names A to Z returns the result in the correct order.
         */
        [TestMethod]
        public void TestFilterSortAZ()
        {
            Employee e1 = new Employee();
            e1.Name = "e1";
            Employee e2 = new Employee();
            e2.Name = "e2";
            Employee e3 = new Employee();
            e3.Name = "e3";
            Employee e4 = new Employee();
            e4.Name = "e4";

            List<Employee> eListExpected = new List<Employee>();
            eListExpected.Add(e1);
            eListExpected.Add(e2);
            eListExpected.Add(e3);
            eListExpected.Add(e4);

            List<Employee> eList = new List<Employee>();
            eList.Add(e2);
            eList.Add(e1);
            eList.Add(e4);
            eList.Add(e3);

            Filter f = new Filter();
            eList = f.SortAZ(eList);
            CollectionAssert.AreEqual(eListExpected, eList);
        }

        /*
         * Test to ensure that sorting Names Z to A returns the result in the correct order.
         */
        [TestMethod]
        public void TestFilterSortZA()
        {
            Employee e1 = new Employee();
            e1.Name = "e1";
            Employee e2 = new Employee();
            e2.Name = "e2";
            Employee e3 = new Employee();
            e3.Name = "e3";
            Employee e4 = new Employee();
            e4.Name = "e4";

            List<Employee> eListExpected = new List<Employee>();
            eListExpected.Add(e4);
            eListExpected.Add(e3);
            eListExpected.Add(e2);
            eListExpected.Add(e1);

            List<Employee> eList = new List<Employee>();
            eList.Add(e2);
            eList.Add(e1);
            eList.Add(e4);
            eList.Add(e3);

            Filter f = new Filter();
            eList = f.SortZA(eList);
            CollectionAssert.AreEqual(eListExpected, eList);
        }

        /*
         * Test to ensure that searching the particular name returns the correct result.
         */
        [TestMethod]
        public void TestFilterSearch()
        {
            Employee e1 = new Employee();
            e1.Name = "e1";
            Employee e2 = new Employee();
            e2.Name = "e2";
            Employee e3 = new Employee();
            e3.Name = "e3";
            Employee e4 = new Employee();
            e4.Name = "e4";

            List<Employee> eListExpected = new List<Employee>();
            eListExpected.Add(e1);

            List<Employee> eList = new List<Employee>();
            eList.Add(e2);
            eList.Add(e1);
            eList.Add(e4);
            eList.Add(e3);

            Filter f = new Filter();
            eList = f.Search(eList, "1");
            CollectionAssert.AreEqual(eListExpected, eList);
        }

        /*
         * Test to ensure that Valid Name Method is able to screen out the wrong inputs for name values.
         */
        [TestMethod]
        public void TestValidNameMethod()
        {
            string emptyString = "";
            string numberString = "123";
            string letterString = "Bob";
            bool Result;

            Filter f = new Filter();
            Result = f.ValidName(emptyString);
            Assert.IsFalse(Result);
            Result = f.ValidName(numberString);
            Assert.IsFalse(Result);
            Result = f.ValidName(letterString);
            Assert.IsTrue(Result);
        }

        /*
         * Test to ensure that Valid Salary Method is able to screen out the wrong inputs for salary values.
         */
        [TestMethod]
        public void TestValidSalaryMethod()
        {
            string emptyString = "";
            string numberString = "123";
            string letterString = "Bob";
            bool Result;

            Filter f = new Filter();
            Result = f.ValidSalary(emptyString);
            Assert.IsFalse(Result);
            Result = f.ValidSalary(numberString);
            Assert.IsTrue(Result);
            Result = f.ValidSalary(letterString);
            Assert.IsFalse(Result);
        }

        /*
         * Test to ensure that Valid ID Method is able to screen out the wrong inputs for ID values.
         */
        [TestMethod]
        public void TestValidIDMethod()
        {
            string emptyString = "";
            string usedIdString = "ID1";
            string uniqueIdString = "ID888";
            bool Result;

            Employee e1 = new Employee();
            e1.Id = "ID1";
            Employee e2 = new Employee();
            e2.Id = "ID2";
            Employee e3 = new Employee();
            e3.Id = "ID3";
            Employee e4 = new Employee();
            e4.Id = "ID4";

            List<Employee> eList = new List<Employee>();
            eList.Add(e2);
            eList.Add(e1);
            eList.Add(e4);
            eList.Add(e3);

            Filter f = new Filter();
            Result = f.ValidID(eList, emptyString);
            Assert.IsFalse(Result);
            Result = f.ValidID(eList, usedIdString);
            Assert.IsFalse(Result);
            Result = f.ValidID(eList, uniqueIdString);
            Assert.IsTrue(Result);
        }

        /*
         * Test to ensure that Valid Gender Method is able to screen out the wrong choice.
         */
        [TestMethod]
        public void TestValidGenderMethod()
        {
            int emptyChoiceInput = -1;
            int correcChoicetInput = 1;
            bool Result;

            Filter f = new Filter();
            Result = f.ValidGender(emptyChoiceInput);
            Assert.IsFalse(Result);
            Result = f.ValidGender(correcChoicetInput);
            Assert.IsTrue(Result);
        }

        /*
         * Test to ensure that Valid Date Of Birth Method is able to screen out the wrong inputs and things are in the right format.
         */
        [TestMethod]
        public void TestValidDateOfBirthMethod()
        {
            string emptyString = "";
            string incorrectDateInputOne = "abcdefg";
            string incorrectDateInputTwo = "1-1-1980";
            string incorrectDateInputThree = "1970/1/3";
            string correctDateInput = "14/3/1965";
            bool Result;

            Filter f = new Filter();
            Result = f.ValidDateOfBirth(emptyString);
            Assert.IsFalse(Result);
            Result = f.ValidDateOfBirth(incorrectDateInputOne);
            Assert.IsFalse(Result);
            Result = f.ValidDateOfBirth(incorrectDateInputTwo);
            Assert.IsFalse(Result);
            Result = f.ValidDateOfBirth(incorrectDateInputThree);
            Assert.IsFalse(Result);
            Result = f.ValidDateOfBirth(correctDateInput);
            Assert.IsTrue(Result);
        }

        /*
         * Test to ensure that Valid Email Method is able to screen out the wrong inputs for email address.
         */
        [TestMethod]
        public void TestValidEmailMethod()
        {
            string emptyString = "";
            string incorrectEmailInputOne = "abcdefg";
            string incorrectEmailInputTwo = "bob.com@a";
            string correctEmailInput = "bob@demo.com";
            bool Result;

            Filter f = new Filter();
            Result = f.ValidEmailAddress(emptyString);
            Assert.IsFalse(Result);
            Result = f.ValidEmailAddress(incorrectEmailInputOne);
            Assert.IsFalse(Result);
            Result = f.ValidEmailAddress(incorrectEmailInputTwo);
            Assert.IsFalse(Result);
            Result = f.ValidEmailAddress(correctEmailInput);
            Assert.IsTrue(Result);
        }
    }

    [TestClass]
    public class FileManagerUnitTests
    {
        /*
         * Test to ensure that Load Employee Method return values for a list of employees.
         */
        [TestMethod]
        public void TestLoadEmployeeMethod()
        {
            FileManager fileManager = new FileManager();
            List<Employee> eListExpected = fileManager.LoadEmployee();
            Employee e = eListExpected[0];
            CollectionAssert.Contains(eListExpected,e);
        }

        /*
         * Test to ensure that Add employee method can add a new employee into the txt file correctly.
         */
        [TestMethod]
        public void TestAddEmployeeMethod()
        {
            Employee e = new Employee("bob","Bb","13/2/1980","bb@demo.co.nz",70000,"Male");
            Employee e2 = new Employee();
            FileManager fileManager = new FileManager();
            fileManager.AddEmployee(e);
            List<Employee> newList = fileManager.LoadEmployee();
            e2 = newList[newList.Count-1];

            Assert.AreEqual(e.Id, e2.Id);
            CollectionAssert.Contains(newList, e);     
        }

        /*
         * Test to ensure that Delete employee method can delete the selected employee from the list.
         */
        [TestMethod]
        public void TestDeleteEmployeeMethod()
        {
            FileManager fileManager = new FileManager();
            List<Employee> eListExpected = fileManager.LoadEmployee();
            Employee e = eListExpected[0];
            fileManager.DeleteEmployee(e);
            eListExpected = fileManager.LoadEmployee();
            CollectionAssert.DoesNotContain(eListExpected, e);
        }
    }
}





