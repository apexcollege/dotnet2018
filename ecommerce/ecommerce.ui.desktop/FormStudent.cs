using ecommerce.app;
using ecommerce.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ecommerce.ui.desktop
{
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Get value from UI
            string name = textBoxName.Text.Trim();
            string rollno = textBoxRollNo.Text.Trim();
            string grade = comboBoxGrade.SelectedItem.ToString();
            DateTime enrolDate = dateTimePickerEnrolDate.Value;
            bool isActive = checkBoxIsActive.Checked;

            //Save to database
            Student s = new Student();
            s.Name = name;
            s.RollNo = Convert.ToInt32(rollno);
            s.Grade = grade;
            s.EnrolDate = enrolDate;
            s.Active = isActive;

            StudentApp app = new StudentApp();
            bool success = app.CreateStudent(s);

            //Show the result
            if (success == true)
                MessageBox.Show("Save succesful");
            else
                MessageBox.Show("Save failed");
        }
    }
}
