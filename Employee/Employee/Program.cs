using System;

namespace Employee
{
    internal class Employee
    {
        public static void Main(String[] args)
        {
            EmpAttendance getMethod = new EmpAttendance();
            Console.WriteLine("Employee Wage for Company A:");
            getMethod.WageForMonth(20, 20, 100);
            Console.WriteLine();
            Console.WriteLine("Employee Wage for Company B:");
            getMethod.WageForMonth(40, 25, 80);
            Console.WriteLine();
            Console.WriteLine("Employee Wage for Company C:");
            getMethod.WageForMonth(60, 15, 90);
        }
    }
}

