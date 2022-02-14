 UC-9
// Compute employee wage using class and methods

 UC-8
// Store daily wage inside directory with day
 master

 UC-7
// Store daily Wage in Arrays Format
 master
 master


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
 UC-9




    public static int GetWorkingHr()
    {
        //constant
        const int ABSENT = 0;
        const int PRESENT = 1;
        const int PART_TIME = 2;
        //declaration and initilization
        int workingHr = 0;




        Random rnd = new Random();
        int present = (rnd.Next(3));
        switch (present)
        {

            case 0:
                workingHr = ABSENT;
                break;
            case PRESENT:
                workingHr = 8;
                break;
            case 2:
                workingHr = PART_TIME;
                break;
            default:
                Console.WriteLine("error");
                break;
        }

        return workingHr;

    }


   UC-8


    public static void Main(String[] args)

    {
        Console.WriteLine($"Employee Wage Calculator");
        //constant
        const int PER_HR_SALARY = 20;
        //declaration and initilization
        int totalSalary = 0;
        int totalHr = 0;
        int[] dailyWageArray = new int[21];

        for (int day = 1; day <= 20; day++)
        {


       UC-7
            int workingHr=GetEmpWage();

                case 0:
                    workingHr = 0;
                    break;
                case 1:
                    workingHr = 8;
                    break;
                case 2:
                    workingHr = 4;
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

            int salary = perHrSalary * workingHr;
            totalSalary = totalSalary + salary;
        UC-6

            totalHr = totalHr + workingHr;
     master
      master

            if (totalHr >= 100)
            {
                break;
            }
            int salary = PER_HR_SALARY * workingHr;
            totalSalary = totalSalary + salary;
            totalHr = totalHr + workingHr;

            dailyWageArray[day] = salary;

      UC-7
        }
            Console.WriteLine($"Total Salary: {totalSalary}");
            Console.WriteLine($"Total working hours: {totalHr}");
            Console.WriteLine(String.Join(" ", dailyWageArray));
        }

    UC-6
    }
    public static void Main(String[] args)
   master



     master

    }
 master
 master
}


