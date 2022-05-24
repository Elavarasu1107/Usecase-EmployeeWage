using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int empWagePerHour, int empWorkDaysPerMonth, int maxWorkingHours);
        public void computeEmpWage();
        public int getTotalWage(string company);
    }
    public class CompanyEmpWage
    {
        public string company;
        public int empWagePerHour, empWorkDaysPerMonth, maxWorkingHours, totalSalary;

        public CompanyEmpWage(string company, int empWagePerHour, int empWorkDaysPerMonth, int maxWorkingHours)
        {
            this.company = company;
            this.empWagePerHour = empWagePerHour;
            this.empWorkDaysPerMonth = empWorkDaysPerMonth;
            this.maxWorkingHours = maxWorkingHours;
            this.totalSalary = 0;
        }
        public void setTotalEmpWage(int totalSalary)
        {
            this.totalSalary = totalSalary;
        }
        public string toString()
        {
            return "Monthly salary of an Employee in " + this.company + " is " + this.totalSalary;
        }
    }
}
