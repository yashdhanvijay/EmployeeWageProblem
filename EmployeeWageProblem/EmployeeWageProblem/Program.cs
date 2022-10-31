using EmployeeWagesProblem;
using System;

namespace EmployeeWageProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage statement");
            EmpWages emp = new EmpWages();
            emp.WageCal();

            emp.Attendance();
        }
    }
}