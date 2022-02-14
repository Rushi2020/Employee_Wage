// Compute employee wage using class and methods


using System;
using System.Collections.Generic;

namespace wageCalculator;

class Program
{
    public static void Main(String[] args)

    {
        Console.WriteLine($"Employee Wage Calculator");
        GetEmployeeWage getEmployeeWage = new GetEmployeeWage();
        getEmployeeWage.EmployeeWage();
    }
}


