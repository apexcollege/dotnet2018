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
            //handle any logic here

            //student should be active when created
            s.Active = true;

            //enroldate should be today
            s.EnrolDate = DateTime.Now;
            
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
