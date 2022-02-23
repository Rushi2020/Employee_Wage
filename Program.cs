// Employee Wage Problem Using oops concept


using System;
using System.Collections.Generic;

namespace Employee_Wage;

class Program
{
    public static void Main(String[] args)

    {
        Console.WriteLine($"Employee Wage Calculator");
        EmpWage Dmart = new EmpWage("Dmart", 20, 20, 100);
        EmpWage Reliance = new EmpWage("Reliance", 25, 22, 50);

    }
}
