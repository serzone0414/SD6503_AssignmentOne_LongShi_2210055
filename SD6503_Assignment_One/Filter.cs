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
    public class Filter
    {
        public List<Employee> SortAZ(List<Employee> elist)
        {
            elist = elist.OrderBy(x => x.Name).ToList();

            return elist;
        }

        public List<Employee> SortZA(List<Employee> elist)
        {
            elist = (from x in elist
                     orderby x.Name descending
                     select x).ToList();

            return elist;
        }

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

        public bool ValidGender(int genderChosenIndex)
        {
            if (genderChosenIndex == -1)
            {
                MessageBox.Show("Please select gender.");
                return false;
            }
            return true;
        }

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
