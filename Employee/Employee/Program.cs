using System;

namespace Employee
{
    internal class Employee
    {
        public static void Main(String[] args)
        {
            EmpWageBuilder empWageBuilder = new EmpWageBuilder();
            empWageBuilder.addCompanyEmpWage("CompanyA", 20, 30, 100);
            empWageBuilder.addCompanyEmpWage("CompanyB", 25, 25, 90);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total wage for CompanyA: " + empWageBuilder.getTotalWage("CompanyA"));
        }
    }
}

