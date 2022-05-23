using System;

namespace Employee
{
    internal class Employee
    {
        public static void Main(String[] args)
        {
            EmpWage companyA = new EmpWage("CompanyA",20,20,100);
            EmpWage companyB = new EmpWage("CompanyB", 40, 22, 95);
            companyA.WageForMonth();
            Console.WriteLine(companyA.toString());
            Console.WriteLine();
            companyB.WageForMonth();
            Console.WriteLine(companyB.toString());

        }
    }
}

