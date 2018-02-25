using ecommerce.data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.app
{
    public class AttendanceApp
    {
        AttendanceDbHelper helper = new AttendanceDbHelper();
        public DataTable GetAllAttendances()
        {
            return helper.Select();
        }
        public bool CreateAttendance(Attendance a)
        {
            return helper.Insert(a);
        }
        public bool UpdateAttendance(Attendance a)
        {
            return helper.Update(a);
        }
        public bool DeleteAttendance(Attendance a)
        {
            return helper.Delete(a);
        }
    }
}
