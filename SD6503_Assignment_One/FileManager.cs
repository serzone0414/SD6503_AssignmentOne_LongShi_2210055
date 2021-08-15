using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD6503_Assignment_One
{
    public class FileManager
    {
        string fileName = @"C:\Users\serzo\source\repos\SD6503_Assignment_One\SD6503_Assignment_One\bin\Debug\employeeInfo.txt";
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
