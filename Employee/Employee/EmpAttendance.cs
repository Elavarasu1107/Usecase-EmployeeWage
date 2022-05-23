using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class EmpAttendance
    {
        public void WageForMonth(int empWagePerHour, int empWorkDaysPerMonth, int maxWorkingHours)
        {
            int empHours, salaryForDay;
            int totalWorkingDays = 0, totalSalary = 0, totalWorkingHours = 0;
            Random value = new Random();

            for (int i = totalWorkingDays; i < empWorkDaysPerMonth; i++)
            {
                if (i < empWorkDaysPerMonth && totalWorkingHours < maxWorkingHours)
                {
                    int randomCheck = value.Next(3);
                    //Console.WriteLine("Generated random value is:" + randomCheck);

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
                    totalWorkingDays = i + 1;
                    salaryForDay = empHours * empWagePerHour;
                    totalSalary = totalSalary + salaryForDay;
                    totalWorkingHours = totalWorkingHours + empHours;
                }
            }
            Console.WriteLine("Total Working Days of an Employee is:" + totalWorkingDays);
            Console.WriteLine("Total Working Hours of an Employee is:" + totalWorkingHours);
            Console.WriteLine("Monthly salary of an Employee is:" + totalSalary);
        }
    }
}
