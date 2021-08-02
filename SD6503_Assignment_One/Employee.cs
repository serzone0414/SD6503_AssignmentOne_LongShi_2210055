using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD6503_Assignment_One
{
    public class Employee
    {
        //Declare variables for Employee's class.
        private string name;
        private string id;
        private string dateOfBirth;
        private string email;
        private float salary;
        private string gender;

        //Default constructor
        public Employee()
        {
            name = "unknown";
            id = "unknown";
            dateOfBirth = "unknown";
            email = "unknown";
            salary = 0.0f;
            gender = "unknown";
        }

        //Parameterized constructor with all fields inlcuded
        public Employee(string name, string id, string dateOfBirth, string email, float salary, string gender)
        {
            this.name = name;
            this.id = id;
            this.dateOfBirth = dateOfBirth;
            this.email = email;
            this.salary = salary;
            this.gender = gender;
        }

        //Properties for all fields of the class.
        public string Name { get => name; set => name = value; }
        public string Id { get => id; set => id = value; }
        public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string Email { get => email; set => email = value; }
        public float Salary { get => salary; set => salary = value; }
        public string Gender { get => gender; set => gender = value; }


        //Method name: ToString (override)
        //Function: return employee's name instead of the project name.
        public override string ToString()
        {
            return name;
        }

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

        public bool Equals(Employee employee)
        {
            if (employee == null)
            { return false; }
            return (this.Id == employee.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        
    }
}
