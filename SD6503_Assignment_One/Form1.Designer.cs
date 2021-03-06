
namespace SD6503_Assignment_One
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lsbEmployee = new System.Windows.Forms.ListBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnZA = new System.Windows.Forms.Button();
            this.btnAZ = new System.Windows.Forms.Button();
            this.textBoxGenderDisplay = new System.Windows.Forms.TextBox();
            this.textBoxSalaryDisplay = new System.Windows.Forms.TextBox();
            this.textBoxEmailDisplay = new System.Windows.Forms.TextBox();
            this.textBoxDateOfBirthDisplay = new System.Windows.Forms.TextBox();
            this.textBoxStaffIdDisplay = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelGenderReminder = new System.Windows.Forms.Label();
            this.labelSalaryReminder = new System.Windows.Forms.Label();
            this.labelEmailReminder = new System.Windows.Forms.Label();
            this.labelDateOfBirthReminder = new System.Windows.Forms.Label();
            this.labelIDReminder = new System.Windows.Forms.Label();
            this.labelNameReminder = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ttpToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDisplay.BackgroundImage")));
            this.btnDisplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDisplay.Location = new System.Drawing.Point(28, 47);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(84, 36);
            this.btnDisplay.TabIndex = 8;
            this.btnDisplay.Text = "Display";
            this.ttpToolTip.SetToolTip(this.btnDisplay, "Displays all employees");
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            this.btnDisplay.MouseEnter += new System.EventHandler(this.btnDisplay_MouseEnter);
            this.btnDisplay.MouseLeave += new System.EventHandler(this.btnDisplay_MouseLeave);
            // 
            // lsbEmployee
            // 
            this.lsbEmployee.FormattingEnabled = true;
            this.lsbEmployee.Location = new System.Drawing.Point(28, 97);
            this.lsbEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lsbEmployee.Name = "lsbEmployee";
            this.lsbEmployee.Size = new System.Drawing.Size(260, 290);
            this.lsbEmployee.TabIndex = 1;
            this.ttpToolTip.SetToolTip(this.lsbEmployee, "Displays a list of employees");
            this.lsbEmployee.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(50, 83);
            this.labelID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(43, 13);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "Staff ID";
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(26, 136);
            this.labelDateOfBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(68, 13);
            this.labelDateOfBirth.TabIndex = 3;
            this.labelDateOfBirth.Text = "Date Of Birth";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(62, 183);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(58, 232);
            this.labelSalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(36, 13);
            this.labelSalary.TabIndex = 5;
            this.labelSalary.Text = "Salary";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(52, 291);
            this.labelGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(42, 13);
            this.labelGender.TabIndex = 6;
            this.labelGender.Text = "Gender";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxSearch);
            this.groupBox1.Controls.Add(this.btnZA);
            this.groupBox1.Controls.Add(this.btnAZ);
            this.groupBox1.Controls.Add(this.lsbEmployee);
            this.groupBox1.Controls.Add(this.btnDisplay);
            this.groupBox1.Location = new System.Drawing.Point(342, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(310, 478);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee list";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 411);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Search: ";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(92, 409);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(174, 20);
            this.textBoxSearch.TabIndex = 10;
            this.ttpToolTip.SetToolTip(this.textBoxSearch, "Enter the search name ");
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // btnZA
            // 
            this.btnZA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZA.BackgroundImage")));
            this.btnZA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZA.Location = new System.Drawing.Point(202, 47);
            this.btnZA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZA.Name = "btnZA";
            this.btnZA.Size = new System.Drawing.Size(84, 36);
            this.btnZA.TabIndex = 8;
            this.btnZA.Text = "Z-A";
            this.ttpToolTip.SetToolTip(this.btnZA, "Sort employees name Z-A");
            this.btnZA.UseVisualStyleBackColor = true;
            this.btnZA.Click += new System.EventHandler(this.btnZA_Click);
            this.btnZA.MouseEnter += new System.EventHandler(this.btnZA_MouseEnter);
            this.btnZA.MouseLeave += new System.EventHandler(this.btnZA_MouseLeave);
            // 
            // btnAZ
            // 
            this.btnAZ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAZ.BackgroundImage")));
            this.btnAZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAZ.Location = new System.Drawing.Point(114, 47);
            this.btnAZ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAZ.Name = "btnAZ";
            this.btnAZ.Size = new System.Drawing.Size(84, 36);
            this.btnAZ.TabIndex = 7;
            this.btnAZ.Text = "A-Z";
            this.ttpToolTip.SetToolTip(this.btnAZ, "Sort employees name A-Z");
            this.btnAZ.UseVisualStyleBackColor = true;
            this.btnAZ.Click += new System.EventHandler(this.btnAZ_Click);
            this.btnAZ.MouseEnter += new System.EventHandler(this.btnAZ_MouseEnter);
            this.btnAZ.MouseLeave += new System.EventHandler(this.btnAZ_MouseLeave);
            // 
            // textBoxGenderDisplay
            // 
            this.textBoxGenderDisplay.Location = new System.Drawing.Point(98, 287);
            this.textBoxGenderDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxGenderDisplay.Name = "textBoxGenderDisplay";
            this.textBoxGenderDisplay.ReadOnly = true;
            this.textBoxGenderDisplay.Size = new System.Drawing.Size(134, 20);
            this.textBoxGenderDisplay.TabIndex = 15;
            this.ttpToolTip.SetToolTip(this.textBoxGenderDisplay, "Displays employee\'s  gender");
            // 
            // textBoxSalaryDisplay
            // 
            this.textBoxSalaryDisplay.Location = new System.Drawing.Point(98, 232);
            this.textBoxSalaryDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSalaryDisplay.Name = "textBoxSalaryDisplay";
            this.textBoxSalaryDisplay.ReadOnly = true;
            this.textBoxSalaryDisplay.Size = new System.Drawing.Size(134, 20);
            this.textBoxSalaryDisplay.TabIndex = 14;
            this.ttpToolTip.SetToolTip(this.textBoxSalaryDisplay, "Displays employee\'s salary");
            // 
            // textBoxEmailDisplay
            // 
            this.textBoxEmailDisplay.Location = new System.Drawing.Point(98, 181);
            this.textBoxEmailDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEmailDisplay.Name = "textBoxEmailDisplay";
            this.textBoxEmailDisplay.ReadOnly = true;
            this.textBoxEmailDisplay.Size = new System.Drawing.Size(134, 20);
            this.textBoxEmailDisplay.TabIndex = 13;
            this.ttpToolTip.SetToolTip(this.textBoxEmailDisplay, "Displays employee\'s email address");
            // 
            // textBoxDateOfBirthDisplay
            // 
            this.textBoxDateOfBirthDisplay.Location = new System.Drawing.Point(98, 133);
            this.textBoxDateOfBirthDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDateOfBirthDisplay.Name = "textBoxDateOfBirthDisplay";
            this.textBoxDateOfBirthDisplay.ReadOnly = true;
            this.textBoxDateOfBirthDisplay.Size = new System.Drawing.Size(134, 20);
            this.textBoxDateOfBirthDisplay.TabIndex = 12;
            this.ttpToolTip.SetToolTip(this.textBoxDateOfBirthDisplay, "Displays employee\'s date of birth");
            // 
            // textBoxStaffIdDisplay
            // 
            this.textBoxStaffIdDisplay.Location = new System.Drawing.Point(98, 83);
            this.textBoxStaffIdDisplay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxStaffIdDisplay.Name = "textBoxStaffIdDisplay";
            this.textBoxStaffIdDisplay.ReadOnly = true;
            this.textBoxStaffIdDisplay.Size = new System.Drawing.Size(134, 20);
            this.textBoxStaffIdDisplay.TabIndex = 11;
            this.ttpToolTip.SetToolTip(this.textBoxStaffIdDisplay, "Displays employee\'s staff ID");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelGenderReminder);
            this.groupBox2.Controls.Add(this.labelSalaryReminder);
            this.groupBox2.Controls.Add(this.labelEmailReminder);
            this.groupBox2.Controls.Add(this.labelDateOfBirthReminder);
            this.groupBox2.Controls.Add(this.labelIDReminder);
            this.groupBox2.Controls.Add(this.labelNameReminder);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.comboBoxGender);
            this.groupBox2.Controls.Add(this.textBoxSalary);
            this.groupBox2.Controls.Add(this.textBoxEmail);
            this.groupBox2.Controls.Add(this.textBoxDateOfBirth);
            this.groupBox2.Controls.Add(this.textBoxID);
            this.groupBox2.Controls.Add(this.textBoxName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(34, 31);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(278, 478);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "New employee";
            // 
            // labelGenderReminder
            // 
            this.labelGenderReminder.AutoSize = true;
            this.labelGenderReminder.Location = new System.Drawing.Point(106, 330);
            this.labelGenderReminder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGenderReminder.Name = "labelGenderReminder";
            this.labelGenderReminder.Size = new System.Drawing.Size(106, 13);
            this.labelGenderReminder.TabIndex = 18;
            this.labelGenderReminder.Text = "Please select gender";
            // 
            // labelSalaryReminder
            // 
            this.labelSalaryReminder.AutoSize = true;
            this.labelSalaryReminder.Location = new System.Drawing.Point(106, 277);
            this.labelSalaryReminder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSalaryReminder.Name = "labelSalaryReminder";
            this.labelSalaryReminder.Size = new System.Drawing.Size(91, 13);
            this.labelSalaryReminder.TabIndex = 17;
            this.labelSalaryReminder.Text = "enter number only";
            this.labelSalaryReminder.Click += new System.EventHandler(this.labelSalaryReminder_Click);
            // 
            // labelEmailReminder
            // 
            this.labelEmailReminder.AutoSize = true;
            this.labelEmailReminder.Location = new System.Drawing.Point(106, 226);
            this.labelEmailReminder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmailReminder.Name = "labelEmailReminder";
            this.labelEmailReminder.Size = new System.Drawing.Size(103, 13);
            this.labelEmailReminder.TabIndex = 16;
            this.labelEmailReminder.Text = "e.g. abc@xtra.co.nz";
            // 
            // labelDateOfBirthReminder
            // 
            this.labelDateOfBirthReminder.AutoSize = true;
            this.labelDateOfBirthReminder.Location = new System.Drawing.Point(106, 181);
            this.labelDateOfBirthReminder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateOfBirthReminder.Name = "labelDateOfBirthReminder";
            this.labelDateOfBirthReminder.Size = new System.Drawing.Size(86, 13);
            this.labelDateOfBirthReminder.TabIndex = 15;
            this.labelDateOfBirthReminder.Text = "e.g. 14/03/1970";
            // 
            // labelIDReminder
            // 
            this.labelIDReminder.AutoSize = true;
            this.labelIDReminder.Location = new System.Drawing.Point(106, 133);
            this.labelIDReminder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIDReminder.Name = "labelIDReminder";
            this.labelIDReminder.Size = new System.Drawing.Size(132, 13);
            this.labelIDReminder.TabIndex = 14;
            this.labelIDReminder.Text = "Staff ID need to be unique";
            // 
            // labelNameReminder
            // 
            this.labelNameReminder.AutoSize = true;
            this.labelNameReminder.Location = new System.Drawing.Point(106, 77);
            this.labelNameReminder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNameReminder.Name = "labelNameReminder";
            this.labelNameReminder.Size = new System.Drawing.Size(76, 13);
            this.labelNameReminder.TabIndex = 13;
            this.labelNameReminder.Text = "e.g. Bob Smith";
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Location = new System.Drawing.Point(108, 377);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 36);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.ttpToolTip.SetToolTip(this.btnAdd, "Add new employee");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.comboBoxGender.Location = new System.Drawing.Point(102, 309);
            this.comboBoxGender.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(140, 21);
            this.comboBoxGender.TabIndex = 11;
            this.ttpToolTip.SetToolTip(this.comboBoxGender, "Select gender");
            this.comboBoxGender.Leave += new System.EventHandler(this.comboBoxGender_Leave);
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(102, 258);
            this.textBoxSalary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(140, 20);
            this.textBoxSalary.TabIndex = 10;
            this.ttpToolTip.SetToolTip(this.textBoxSalary, "Enter number");
            this.textBoxSalary.Leave += new System.EventHandler(this.textBoxSalary_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(102, 207);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(140, 20);
            this.textBoxEmail.TabIndex = 9;
            this.ttpToolTip.SetToolTip(this.textBoxEmail, "Enter email adress");
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(102, 155);
            this.textBoxDateOfBirth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(140, 20);
            this.textBoxDateOfBirth.TabIndex = 8;
            this.ttpToolTip.SetToolTip(this.textBoxDateOfBirth, "Format: dd/MMYYYY");
            this.textBoxDateOfBirth.Leave += new System.EventHandler(this.textBoxDateOfBirth_Leave);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(102, 105);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(140, 20);
            this.textBoxID.TabIndex = 7;
            this.ttpToolTip.SetToolTip(this.textBoxID, "Staff ID has to be unique");
            this.textBoxID.Leave += new System.EventHandler(this.textBoxID_Leave);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(102, 52);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(140, 20);
            this.textBoxName.TabIndex = 6;
            this.ttpToolTip.SetToolTip(this.textBoxName, "Enter full name");
            this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 315);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 258);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 207);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date Of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Staff ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.textBoxGenderDisplay);
            this.groupBox3.Controls.Add(this.textBoxStaffIdDisplay);
            this.groupBox3.Controls.Add(this.textBoxSalaryDisplay);
            this.groupBox3.Controls.Add(this.labelID);
            this.groupBox3.Controls.Add(this.labelGender);
            this.groupBox3.Controls.Add(this.textBoxEmailDisplay);
            this.groupBox3.Controls.Add(this.textBoxDateOfBirthDisplay);
            this.groupBox3.Controls.Add(this.labelDateOfBirth);
            this.groupBox3.Controls.Add(this.labelSalary);
            this.groupBox3.Controls.Add(this.labelEmail);
            this.groupBox3.Location = new System.Drawing.Point(676, 31);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(282, 478);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Staff Info";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(90, 358);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 30);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.ttpToolTip.SetToolTip(this.btnDelete, "Delete select employee");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseEnter += new System.EventHandler(this.btnDelete_MouseEnter);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(983, 544);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ListBox lsbEmployee;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxDateOfBirth;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnZA;
        private System.Windows.Forms.Button btnAZ;
        private System.Windows.Forms.TextBox textBoxGenderDisplay;
        private System.Windows.Forms.TextBox textBoxSalaryDisplay;
        private System.Windows.Forms.TextBox textBoxEmailDisplay;
        private System.Windows.Forms.TextBox textBoxDateOfBirthDisplay;
        private System.Windows.Forms.TextBox textBoxStaffIdDisplay;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolTip ttpToolTip;
        private System.Windows.Forms.Label labelDateOfBirthReminder;
        private System.Windows.Forms.Label labelIDReminder;
        private System.Windows.Forms.Label labelNameReminder;
        private System.Windows.Forms.Label labelEmailReminder;
        private System.Windows.Forms.Label labelGenderReminder;
        private System.Windows.Forms.Label labelSalaryReminder;
        private System.Windows.Forms.Label label7;
    }
}