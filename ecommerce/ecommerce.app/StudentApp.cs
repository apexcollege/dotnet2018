using ecommerce.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.app
{
    public class StudentApp
    {
        StudentDbHelper helper = new StudentDbHelper();
        public DataTable GetAllStudents()
        {
            return helper.Select();
        }
        public bool CreateStudent(Student s)
        {
            s.Active = true; //student should be active when created
            s.EnrolDate = DateTime.Now; //enroldate should be today
            return helper.Insert(s);
        }
        public bool UpdateStudent(Student s)
        {
            return helper.Update(s);
        }
        public bool DeleteStudent(Student s)
        {
            return helper.Delete(s);
        }
    }
}
