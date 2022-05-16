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
            int empWagePerHour = 20, empHours, dailyWage;
            Random value=new Random();
            int randomCheck=value.Next(2);

            switch(randomCheck)
            {
                case 0:
                    {
                        Console.WriteLine("Employee is Absent");
                        empHours = 0;
                        dailyWage = empHours * empWagePerHour;
                        Console.WriteLine("Employee dailywage is:" + dailyWage);
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Employee is Present");
                        empHours = 8;
                        dailyWage = empHours * empWagePerHour;
                        Console.WriteLine("Employee dailywage is:" + dailyWage);
                        break;
                    }
            }
        }
    }
}
