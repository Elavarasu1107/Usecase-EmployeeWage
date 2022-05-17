using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class EmpAttendance
    {
        public void WageForMonth()
        {
            int empWagePerHour = 20, empWorkDaysMonth=20, empHours, dailyWage;
            int totalWorkingDays = 0,totalSalary=0,salaryForDay;
            Random value=new Random();

            for(int days=1;days< empWorkDaysMonth; days++)
            {
                int randomCheck = value.Next(3);
               // Console.WriteLine("Generated random value is:" + randomCheck);

                switch (randomCheck)
                {
                    case 1:// For Part Time
                        {
                            empHours = 4;
                            break;
                        }
                    case 2: // For Full Time
                        {
                            empHours = 8;
                            break;
                        }
                    default: // For Absent
                        {
                            empHours = 0;
                            break;
                        }     
                }
                salaryForDay = empHours * empWagePerHour;
                totalSalary = totalSalary + salaryForDay;
            }
                Console.WriteLine("Monthly salary of an Employee is:" + totalSalary);

        }
    }
}
