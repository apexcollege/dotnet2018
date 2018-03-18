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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            FormStudent formStudent = new FormStudent();
            formStudent.Show();
        }

        private void buttonAttendance_Click(object sender, EventArgs e)
        {
            FormAttendance formAttendance = new FormAttendance();
            formAttendance.Show();
        }
    }
}
