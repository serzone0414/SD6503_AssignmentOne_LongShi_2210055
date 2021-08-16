using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD6503_Assignment_One
{
    /// <summary>
    /// This class is for sorting the employee list, supporting searching name in the list.
    /// Also this class have methods to do the input validations for creating new employee.
    /// </summary>
    public class Filter
    {
        /// <summary>
        /// This class reads the employee list and re-arrange the list in A-Z alphabetical order.
        /// </summary>
        /// <param name="elist">list of Employee objects</param>
        /// <returns>the list with same objects but in A-Z alphabetical order.</returns>
        public List<Employee> SortAZ(List<Employee> elist)
        {
            elist = elist.OrderBy(x => x.Name).ToList();

            return elist;
        }

        /// <summary>
        /// This class reads the employee list and re-arrange the list in Z-A alphabetical order.
        /// </summary>
        /// <param name="elist">list of Employee objects</param>
        /// <returns>the list with same objects but in A-Z alphabetical order.</returns>
        public List<Employee> SortZA(List<Employee> elist)
        {
            elist = (from x in elist
                     orderby x.Name descending
                     select x).ToList();

            return elist;
        }

        /// <summary>
        /// It reads a list of Employee objects and a keyword which is the one user is searching for.
        /// It will go thr the list and looking for matching result for that word.
        /// any objects containing and keyword will be returned as a list of Employee objects.
        /// </summary>
        /// <param name="clist">list of Employee objects.</param>
        /// <param name="term">the word is searching for.</param>
        /// <returns>The list of employee which has containing searching keyword</returns>
        public List<Employee> Search(List<Employee> clist, string term)
        {
            List<Employee> results = new List<Employee>();
            foreach (Employee e in clist)
            {
                if (e.Name.ToLower().Contains(term.ToLower()))
                {
                    results.Add(e);
                }
            }
            return results;
        }

        /// <summary>
        /// Input validation method for email address.
        /// It checks the input is not empty, also the input must have "@" which is before ".".
        /// If not meet the requirements of the input, it opens up a message box as reminder, and return a false value.
        /// </summary>
        /// <param name="emailAddress">String value which has the employee's email address input</param>
        /// <returns>Bool value, true if it meets the requirements, false if it does not meet the requirements.</returns>
        public bool ValidEmailAddress(string emailAddress)
        {
            if (emailAddress.Length == 0)
            {
                MessageBox.Show("Email can not be empty.");
                return false;
            }
            if (emailAddress.IndexOf("@") > -1)
            {
                if (emailAddress.IndexOf(".", emailAddress.IndexOf("@")) > emailAddress.IndexOf("@"))
                {
                    return true;
                }
            }

            MessageBox.Show("email address format is incorrect.");
            return false;
        }

        /// <summary>
        /// Input validation for employee's name
        /// It checks the input is not empty and not having numbers.
        /// If not meet the requirements of the input, it opens up a message box as reminder, and return a false value.
        /// </summary>
        /// <param name="name">String value which has the employee's name</param>
        /// <returns>Bool value, true if it meets the requirements, false if it does not meet the requirements.</returns>
        public bool ValidName(string name)
        {
            if (name.Length == 0)
            {
                MessageBox.Show("Name can not be empty.");
                return false;
            }
            if (name.All(char.IsDigit))
            {
                MessageBox.Show("Name can not include number.");
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Input validation for employee's salary
        /// Such input should not be empty or having and letter inside.
        /// If not meet the requirements of the input, it opens up a message box as reminder, and return a false value.
        /// </summary>
        /// <param name="Salary">String value that has the employee' salary amount</param>
        /// <returns>Bool value, true if it meets the requirements, false if it does not meet the requirements.</returns>
        public bool ValidSalary(string Salary)
        {
            if (Salary.Length == 0)
            {
                MessageBox.Show("Salary can not be empty.");
                return false;
            }
            foreach(char c in Salary)
            {
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("Salary needs to be numbers only.");
                    return false;
                }     
            }
            return true;        
        }

        /// <summary>
        /// Input validation for employee's ID.
        /// It reads entire list of employee and the new ID.
        /// This is to check that input is not empty, and it is also not used by other emplyee in the list because ID should be 
        /// a unique value.
        /// If the input does not meet the requirements, it opens up a message box as reminder, and return a false value.
        /// </summary>
        /// <param name="clist">list of Employee objects</param>
        /// <param name="ID">String value of Staff ID</param>
        /// <returns>Bool value, true if it meets the requirements, false if it does not meet the requirements.</returns>
        public bool ValidID(List<Employee> clist, string ID)
        {
            if (ID.Length == 0)
            {
                MessageBox.Show("ID can not be empty.");
                return false;
            }
            foreach (Employee e in clist)
            {
                if (e.Id.ToLower().Contains(ID.ToLower()))
                {
                    MessageBox.Show("ID can not be the same as other staff.");
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Input validation for gender choice.
        /// It checks the choice is valid in the combo box.
        /// If nothing has been chosen in the combo box, the value will be -1, thus the value should not be -1.
        /// </summary>
        /// <param name="genderChosenIndex">The index of choice from the combo box</param>
        /// <returns>Bool value, true if it meets the requirement, false if it does not meet the requirement.</returns>
        public bool ValidGender(int genderChosenIndex)
        {
            if (genderChosenIndex == -1)
            {
                MessageBox.Show("Please select gender.");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Input validation for date of birth
        /// such input can not be empty and the format has to be :dd/mm/yyyy
        /// If the input does not meet the requirements, it opens up a message box as reminder, and return a false value.
        /// </summary>
        /// <param name="dateOfBirth">string of the date of birth input</param>
        /// <returns>Bool value, true if it meets the requirement, false if it does not meet the requirement.</returns>
        public bool ValidDateOfBirth(String dateOfBirth)
        {
            if (dateOfBirth.Length == 0)
            {
                MessageBox.Show("Date of birth can not be empty.");
                return false;
            }

            DateTime d;
            string[] formats = { "dd/MM/yyyy", "dd/M/yyyy", "d/M/yyyy", "d/MM/yyyy"};
            bool dateFormat = DateTime.TryParseExact(
            dateOfBirth,
            formats,
            CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out d);

            if (dateFormat == true)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Date of birth format needs to be: dd/MM/yyyy");
                return false;
            }
        }
    }
}
