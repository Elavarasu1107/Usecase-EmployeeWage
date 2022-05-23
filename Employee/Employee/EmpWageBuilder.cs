using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class EmpWageBuilderArray
    {
        public const int IS_PART_TIME = 1, IS_FULL_TIME = 2;
        private int numOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void addCompanyEmpWage(string company, int empWagePerHour, int empWorkDaysPerMonth, int maxWorkingHours)
        {
            companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(company, empWagePerHour, empWorkDaysPerMonth, maxWorkingHours);
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for (int i = 0; i < numOfCompany; i++)
            {
                companyEmpWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].toString());
            }
        }
        public int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHours, totalEmpHrs = 0;
            int totalWorkingDays = 0;
            Random value = new Random();

            while (totalEmpHrs <= companyEmpWage.maxWorkingHours && totalWorkingDays < companyEmpWage.empWorkDaysPerMonth)
            {
                totalWorkingDays++;
                int randomCheck = value.Next(3);

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

                totalEmpHrs = empHours + totalEmpHrs;
                Console.WriteLine("Day:" + totalWorkingDays + " Emp Hrs: " + empHours);
            }
            return totalEmpHrs * companyEmpWage.empWagePerHour;
        }
    }
}
