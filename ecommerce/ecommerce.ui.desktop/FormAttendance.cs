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
    public partial class FormAttendance : Form
    {
        public FormAttendance()
        {
            InitializeComponent();
        }

        private void FormAttendance_Load(object sender, EventArgs e)
        {
            //show students list to combo-box
            StudentApp studentApp = new StudentApp();
            DataTable dtStudents = studentApp.GetAllStudents();
            comboBoxStudent.DataSource = dtStudents;
            comboBoxStudent.DisplayMember = "Name";
            comboBoxStudent.ValueMember = "Id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //get values from ui
            string studentId = comboBoxStudent.SelectedValue.ToString();
            DateTime attendanceDate = dateTimePickerAttendanceDate.Value;
            bool isPresent = checkBoxIsPresent.Checked;
            string remarks = textBoxRemarks.Text.Trim();
            //save
            AttendanceApp attendanceApp = new AttendanceApp();
            Attendance a = new Attendance();
            a.StudentId = Convert.ToInt32(studentId);
            a.AttendanceDate = attendanceDate;
            a.IsPresent = isPresent;
            a.Remarks = remarks;
            bool success = attendanceApp.CreateAttendance(a);
            //display message
            if (success == true)
                MessageBox.Show("Save Successful");
            else
                MessageBox.Show("Save failed");
        }
    }
}
