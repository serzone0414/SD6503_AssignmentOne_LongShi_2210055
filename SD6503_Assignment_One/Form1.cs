using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SD6503_Assignment_One
{
    public partial class Form1 : Form
    {
        FileManager fm = new FileManager();
        List<Employee> employees = new List<Employee>();
        Filter filter = new Filter();

        public Form1()
        {
            InitializeComponent();
            employees = fm.LoadEmployee();
        }


        //Method name: btnDisplay_Click
        //Function: When the display button is clicked, if the listbox is empty, load information from employeeInfo.txt file.
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            employees.Clear();
            employees = fm.LoadEmployee();

            if (employees == null)
            { MessageBox.Show("Eoor loading Employee info", "File IO Error"); }

            else
            {
                lsbEmployee.Items.Clear();
                lsbEmployee.Items.AddRange(employees.ToArray());
            }

        }

        //Method name: listBox1_SelectedIndexChanged
        //Function: Selected employee from listbox will be displayed for details on other labels.
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbEmployee.SelectedIndex != -1)
            {
                try
                {
                    //Get the selected employee from list
                    Employee selectedEmployee = (Employee)lsbEmployee.SelectedItem;

                    //Display selected employee's info
                    textBoxStaffIdDisplay.Text = selectedEmployee.Id;
                    textBoxDateOfBirthDisplay.Text = selectedEmployee.DateOfBirth;
                    textBoxEmailDisplay.Text = selectedEmployee.Email;
                    textBoxSalaryDisplay.Text = "$ " + selectedEmployee.Salary.ToString();
                    textBoxGenderDisplay.Text = selectedEmployee.Gender;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }

            }
        }

        //Method Nanme: btnAdd_Click
        //Function: Going through all the inputs for creating a new employee by using methods from Filter.cs.
        //          if all methods came back true values, then using those inputs values to create a employee
        //          and adding the new employee to the txt file by calling AddEmployee() then reload the employee
        //          list for the listBox1.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (filter.ValidEmailAddress(textBoxEmail.Text) == true
                && filter.ValidName(textBoxName.Text) == true
                && filter.ValidSalary(textBoxSalary.Text) == true
                && filter.ValidID(employees,textBoxID.Text) == true
                && filter.ValidGender(comboBoxGender.SelectedIndex) == true
                && filter.ValidDateOfBirth(textBoxDateOfBirth.Text) == true
                )
            {
                Employee emp = new Employee(textBoxName.Text, textBoxID.Text, textBoxDateOfBirth.Text, textBoxEmail.Text, float.Parse(textBoxSalary.Text), comboBoxGender.SelectedItem.ToString());
                if (fm.AddEmployee(emp))
                {

                    employees.Clear();
                    employees = fm.LoadEmployee();

                    if (employees == null)
                    { MessageBox.Show("Error loading Employee info", "File IO Error"); }

                    else
                    {
                        lsbEmployee.Items.Clear();
                        lsbEmployee.Items.AddRange(employees.ToArray());
                    }
                }
            }


        }
        //Method name: btnAZ_Click
        //Function: Sort the employees' name in the list from A-Z
        private void btnAZ_Click(object sender, EventArgs e)
        {
            Filter eFilter = new Filter();

            employees = eFilter.SortAZ(employees);

            lsbEmployee.Items.Clear();
            lsbEmployee.Items.AddRange(employees.ToArray());
        }

        //Method name: btnZA_Click
        //Function: Sort the employees' name in the list from Z-A
        private void btnZA_Click(object sender, EventArgs e)
        {
            Filter eFilter = new Filter();

            employees = eFilter.SortZA(employees);

            lsbEmployee.Items.Clear();
            lsbEmployee.Items.AddRange(employees.ToArray());
        }

        //Method name: btnDelete_Click
        //Function: Confirming and delete the selected employee in the ListBox1 from the txt file
        //          And Reload the ListBox1
        private void btnDelete_Click(object sender, EventArgs e)
        {         
            if (lsbEmployee.SelectedItem == null)
            {
                MessageBox.Show("Please select an employee.");
            }
            else
            {
                DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                    Employee selectedEmployee = (Employee)lsbEmployee.SelectedItem;
                    FileManager fm = new FileManager();
                    fm.DeleteEmployee(selectedEmployee);

                    employees.Clear();
                    employees = fm.LoadEmployee();
                    lsbEmployee.Items.Clear();
                    lsbEmployee.Items.AddRange(employees.ToArray());
                }
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length == 0)
            {
                labelNameReminder.ForeColor = Color.Red;
                labelNameReminder.Text = "Name cannot be empty";
            }
            else
            {
                labelNameReminder.ForeColor = Color.Green;
                labelNameReminder.Text = "e.g. Bob Smith";
            }
        }

        private void textBoxID_Leave(object sender, EventArgs e)
        {
            if (textBoxID.Text.Length == 0)
            {
                labelIDReminder.ForeColor = Color.Red;
                labelIDReminder.Text = "ID cannot be empty";
            }
            else 
            { 
                labelIDReminder.ForeColor = Color.Green;
                labelIDReminder.Text = "Staff ID need to be unique";
            }
        }

        private void textBoxDateOfBirth_Leave(object sender, EventArgs e)
        {
            if (textBoxDateOfBirth.Text.Length == 0)
            {
                labelDateOfBirthReminder.ForeColor = Color.Red;
                labelDateOfBirthReminder.Text = "Date of birth cannot be empty";
            }
            else
            {
                labelDateOfBirthReminder.ForeColor = Color.Green;
                labelDateOfBirthReminder.Text = "e.g. 14/03/1970";
            }
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text.Length == 0)
            {
                labelEmailReminder.ForeColor = Color.Red;
                labelEmailReminder.Text = "Email cannot be empty";
            }
            else
            {
                labelEmailReminder.ForeColor = Color.Green;
                labelEmailReminder.Text = "e.g. abc@xtra.co.nz";
            }
        }

        private void textBoxSalary_Leave(object sender, EventArgs e)
        {
            if (textBoxSalary.Text.Length == 0)
            {
                labelSalaryReminder.ForeColor = Color.Red;
                labelSalaryReminder.Text = "Salary cannot be empty";
            }
            else
            {
                labelSalaryReminder.ForeColor = Color.Green;
                labelSalaryReminder.Text = "enter number only";
            }
        }

        private void comboBoxGender_Leave(object sender, EventArgs e)
        {
            if (comboBoxGender.SelectedIndex == -1)
            {
                labelGenderReminder.ForeColor = Color.Red;
            }
            else
            {
                labelGenderReminder.ForeColor = Color.Green;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            List<Employee> results = new List<Employee>();
            Filter eFilter = new Filter();

            string terms = textBoxSearch.Text;

            results = eFilter.Search(employees, terms);

            lsbEmployee.Items.Clear();
            lsbEmployee.Items.AddRange(results.ToArray());
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.Font = new Font(btnDelete.Font, FontStyle.Bold);
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.Font = new Font(btnDelete.Font, FontStyle.Regular);
        }

        private void btnAZ_MouseEnter(object sender, EventArgs e)
        {
            btnAZ.Font = new Font(btnDelete.Font, FontStyle.Bold);
        }

        private void btnAZ_MouseLeave(object sender, EventArgs e)
        {
            btnAZ.Font = new Font(btnDelete.Font, FontStyle.Regular);
        }

        private void btnZA_MouseEnter(object sender, EventArgs e)
        {
            btnZA.Font = new Font(btnDelete.Font, FontStyle.Bold);
        }

        private void btnZA_MouseLeave(object sender, EventArgs e)
        {
            btnZA.Font = new Font(btnDelete.Font, FontStyle.Regular);
        }

        private void btnDisplay_MouseEnter(object sender, EventArgs e)
        {
            btnDisplay.Font = new Font(btnDelete.Font, FontStyle.Bold);
        }

        private void btnDisplay_MouseLeave(object sender, EventArgs e)
        {
            btnDisplay.Font = new Font(btnDelete.Font, FontStyle.Regular);
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            btnAdd.Font = new Font(btnDelete.Font, FontStyle.Bold);
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.Font = new Font(btnDelete.Font, FontStyle.Regular);
        }

        private void labelSalaryReminder_Click(object sender, EventArgs e)
        {

        }
    }
}
