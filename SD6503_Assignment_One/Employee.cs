using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD6503_Assignment_One
{
    /// <summary>
    /// This class is for creating a object type to manage all the employee's informations.
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Declare variables for Employee's class.
        /// </summary>
        private string name;
        private string id;
        private string dateOfBirth;
        private string email;
        private float salary;
        private string gender;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Employee()
        {
            name = "unknown";
            id = "unknown";
            dateOfBirth = "unknown";
            email = "unknown";
            salary = 0.0f;
            gender = "unknown";
        }

        /// <summary>
        /// Parameterized constructor with all fields inlcuded
        /// </summary>
        /// <param name="name"></param>Employee's name
        /// <param name="id"></param>Employee's Staff ID
        /// <param name="dateOfBirth"></param> Employee's date of birth
        /// <param name="email"></param> Employee's email address
        /// <param name="salary"></param> Employee's salary amount
        /// <param name="gender"></param> Employee's gender
        public Employee(string name, string id, string dateOfBirth, string email, float salary, string gender)
        {
            this.name = name;
            this.id = id;
            this.dateOfBirth = dateOfBirth;
            this.email = email;
            this.salary = salary;
            this.gender = gender;
        }

        /// <summary>
        /// Properties for all fields of the class. Entire data fields are having public set and get functions.
        /// </summary>
        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Email { get => email; set => email = value; }
        public float Salary { get => salary; set => salary = value; }
        public string Gender { get => gender; set => gender = value; }


        /// <summary>
        /// To change the employee's name instead of the project name for ToString method for this class.
        /// </summary>
        /// <returns>A string contains the employee's name</returns>
        public override string ToString()
        {
            return name;
        }

        /// <summary>
        /// To override the Equals definition to:
        /// if object is empty, result is false
        /// if the object is not empty, call another method Equals() by passing the object. 
        /// get the returning value from that function.
        /// </summary>
        /// <param name="obj">the object is going to be compared with.</param>
        /// <returns>Bool value depends on the compared result.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Employee employee = obj as Employee;

            if (employee == null)
            {
                return false;
            }
            else {
                return Equals(employee);
            }
        }

        /// <summary>
        /// Compare two employee objects are the same or not based on thier Id.
        /// </summary>
        /// <param name="employee">the employee object is going to be compared with. </param>
        /// <returns>Bool value depends on two employees' Id comparision result. </returns>
        public bool Equals(Employee employee)
        {
            if (employee == null)
            { return false; }
            return (this.Id == employee.Id);
        }

        /// <summary>
        /// Override GetHashCode method for this class.
        /// let the object determinded by ID which is the unique value for employees.
        /// </summary>
        /// <returns>Int value contains the Id information.</returns>
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        
    }
}
