using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class EmpWage
    {
        public const int IS_PART_TIME = 1, IS_FULL_TIME = 2;

        private string company;
        private int empWagePerHour, empWorkDaysPerMonth, maxWorkingHours, totalSalary;

        public EmpWage(string company, int empWagePerHour, int empWorkDaysPerMonth, int maxWorkingHours)
        {
            this.company = company;
            this.empWagePerHour = empWagePerHour;
            this.empWorkDaysPerMonth = empWorkDaysPerMonth;
            this.maxWorkingHours = maxWorkingHours;
        }
        public void WageForMonth()
        {
            int empHours, salaryForDay;
            int totalWorkingDays = 0, totalWorkingHours = 0;
            Random value = new Random();

            for (int i = totalWorkingDays; i < empWorkDaysPerMonth; i++)
            {
                if (i < this.empWorkDaysPerMonth && totalWorkingHours < this.maxWorkingHours)
                {
                    int randomCheck = value.Next(3);
                    //Console.WriteLine("Generated random value is:" + randomCheck);

                    switch (randomCheck)
                    {
                        case IS_PART_TIME:// For Part Time
                            {
                                empHours = 4;
                                break;
                            }
                        case IS_FULL_TIME: // For Full Time
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
            //Console.WriteLine("Monthly salary of an Employee in "+company+" is " + totalSalary);
        }
        public string toString()
        {
            return "Monthly salary of an Employee in "+this.company+" is " + this.totalSalary;
        }
    }
}
