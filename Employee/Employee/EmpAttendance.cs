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
            int randomCheck=value.Next(3);
            Console.WriteLine("Generated random value is:" + randomCheck);

            switch(randomCheck)
            {
                case 1:
                    {
                        Console.WriteLine("Employee is working Part Time");
                        empHours = 4;
                        dailyWage = empHours * empWagePerHour;
                        Console.WriteLine("Employee wage is:" + dailyWage);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Employee is working Full Time");
                        empHours = 8;
                        dailyWage = empHours * empWagePerHour;
                        Console.WriteLine("Employee wage is:" + dailyWage);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Employee is Absent");
                        empHours = 0;
                        dailyWage = empHours * empWagePerHour;
                        Console.WriteLine("Employee wage is:" + dailyWage);
                        break;
                    }
            }
        }
    }
}
