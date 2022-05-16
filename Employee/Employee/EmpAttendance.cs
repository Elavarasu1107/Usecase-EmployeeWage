using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class EmpAttendance
    {
        public void AttendanceCheck()
        {
            Random value=new Random();
            int randomCheck=value.Next(2);

            switch(randomCheck)
            {
                case 0:
                    {
                        Console.WriteLine("Employee is Absent");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Employee is Present");
                        break;
                    }
            }
        }
    }
}
