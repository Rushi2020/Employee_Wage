
// Store daily Wage in Arrays Format


using System;
using System.Collections.Generic;

namespace Employee_Wage;

class Program
{
    static int calculate_working_hrs()

    {
        Random random = new Random();
        int empCheck = random.Next(0, 3);
        //Veriables
        int WorkingHr = 0;

        //Constants
        const int ABSENT = 0;
        const int FULLTIME = 1;

        switch (empCheck)
        {
            case ABSENT:
                WorkingHr = 0;
                // Console.WriteLine("Employee is Absent");return WorkingHr;
                break;

            case FULLTIME:
                WorkingHr = 8;
                // Console.WriteLine("Employee is Full Time Present");
                break;

            default:
                WorkingHr = 4;
                //Console.WriteLine("Employee is Part Time Present");
                break;

        }
        return WorkingHr;


    }
    public static void Main(string[] args)
    {
        //Constants
        int MAXDAY = 20;
        int TOTALWORKINGHRS = 100;
        int WAGEPERHRS = 20;

        //Veriables
        int day = 0;
        int totalWorkingHrs = 0;
        int empTotalWage = 0;

        Dictionary<int, int> dailywage = new Dictionary<int, int>();

        while (day < MAXDAY && totalWorkingHrs < TOTALWORKINGHRS)
        {

            totalWorkingHrs = totalWorkingHrs + calculate_working_hrs();
            int empDailyWage = WAGEPERHRS * calculate_working_hrs();
            empTotalWage = empTotalWage + empDailyWage;
            dailywage[day] = empDailyWage;
            Console.WriteLine($"DAY {day + 1} Wage is {dailywage[day]}");
            day++;
        }
        Console.WriteLine($"Total Days:{day} , Total Working Hours:{totalWorkingHrs} & Total Employee Wage:{empTotalWage}");

    }
 
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


            int workingHr=GetEmpWage();

            int salary = perHrSalary * workingHr;
            totalSalary = totalSalary + salary;
        

            totalHr = totalHr + workingHr;
     
            if (totalHr >= 100)
            {
                break;
            }
            int salary = PER_HR_SALARY * workingHr;
            totalSalary = totalSalary + salary;
            totalHr = totalHr + workingHr;

            dailyWageArray[day] = salary;

      
        }
            Console.WriteLine($"Total Salary: {totalSalary}");
            Console.WriteLine($"Total working hours: {totalHr}");
            Console.WriteLine(String.Join(" ", dailyWageArray));
        }
 
    }
   }
}


