using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class EmpWageBuilder : IComputeEmpWage
    {
        public const int IS_PART_TIME = 1, IS_FULL_TIME = 2;
        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

        public EmpWageBuilder()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }

        public void addCompanyEmpWage(string company, int empWagePerHour, int empWorkDaysPerMonth, int maxWorkingHours)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empWagePerHour, empWorkDaysPerMonth, maxWorkingHours);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);

        }
        public void computeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
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

        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalSalary;
        }
    }
}
