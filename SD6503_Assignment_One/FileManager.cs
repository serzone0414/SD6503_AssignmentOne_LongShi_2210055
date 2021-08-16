using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD6503_Assignment_One
{
    /// <summary>
    /// FileManager class is for helping the application to read, write delete the employee's information from txt file.
    /// </summary>
    public class FileManager
    {
        /// <summary>
        /// the string fileName is the local path of employeeInfo.txt file, it is created for automation testing using.
        /// </summary>
        string fileName = @"C:\Users\serzo\source\repos\SD6503_Assignment_One\SD6503_Assignment_One\bin\Debug\employeeInfo.txt";

        /// <summary>
        /// LoadEmployee method reads the data from emoloyeeInfo.txt file and pass those values into a list of employee.
        /// </summary>
        /// <returns>A list of employee objects</returns>
        public List<Employee> LoadEmployee()
        {
            try
            {
                List<Employee> employeeList = new List<Employee>();

                StreamReader sr = new StreamReader(fileName);
                //StreamReader sr = new StreamReader("employeeInfo.txt");

                while (!sr.EndOfStream)
                {
                    string[] info = sr.ReadLine().Replace(", ", ",").Split(',');
                    Employee e = new Employee(info[0], info[1], info[2], info[3], float.Parse(info[4]), info[5]);
                    employeeList.Add(e);

                }
                sr.Close();
                return employeeList;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// AddEmployee is to add new employee into the employeeInfo.txt file in the proper format.
        /// </summary>
        /// <param name="e">This object is the new employee which contains all the information needed for creating the new employee.</param>
        /// <returns>Bool value: It returns true if successfully added the new employee, returns false if it is failed.</returns>
        public bool AddEmployee(Employee e)
        {
            try
            {
                //StreamWriter sw = File.AppendText("employeeInfo.txt");
                StreamWriter sw = File.AppendText(fileName);

                sw.WriteLine((e.Name + ", " + e.Id + ", " + e.DateOfBirth + ", " +
                           e.Email + ", " + e.Salary.ToString() + ", " + e.Gender));

                sw.Close();
                MessageBox.Show("New employee added");
                return true;
            }

            catch (Exception)
            {
                MessageBox.Show("Adding new employee failed");
                return false;
            }
                
        }

        /// <summary>
        /// DeleteEmployee is to remove any selected emloyee from the emloyeeInfo.txt file.
        /// It uses selcted employee's ID as primary key to determin which line to delete.
        /// The logic of this method is getting a copy of whole employee list but not included the one needs to be deleted.
        /// Then re-write the employeeInfo.txt file from the copy, thus the new copy would not have that employee anymore.
        /// </summary>
        /// <param name="selectedEmployee">The chosen employee which is going to be deleted.</param>
        public void DeleteEmployee(Employee selectedEmployee)
        {
                try
                {
                    List<Employee> employeeList = new List<Employee>();
                    StreamReader sr = new StreamReader(fileName);
                    //StreamReader sr = new StreamReader("employeeInfo.txt");
                    string employeeID = selectedEmployee.Id;

                    while (!sr.EndOfStream)
                    {
                        string[] info = sr.ReadLine().Replace(", ", ",").Split(',');

                        if (info[1] != employeeID)
                        {
                            Employee emp = new Employee(info[0], info[1], info[2], info[3], float.Parse(info[4]), info[5]);
                            employeeList.Add(emp);
                        }

                    }
                    sr.Close();


                    // File.WriteAllText("employeeInfo.txt", string.Empty);
                    File.WriteAllText(fileName, string.Empty);

                    //StreamWriter sw = File.AppendText("employeeInfo.txt");
                    StreamWriter sw = File.AppendText(fileName);
                    for (int i = 0; i < employeeList.Count; i++)
                    {
                        sw.WriteLine((employeeList[i].Name + ", " + employeeList[i].Id + ", " + employeeList[i].DateOfBirth + ", "
                              + employeeList[i].Email + ", " + employeeList[i].Salary.ToString() + ", " + employeeList[i].Gender));

                    }
                    sw.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Need to select a employee to delete....");
                }
            
        }


    }
}
