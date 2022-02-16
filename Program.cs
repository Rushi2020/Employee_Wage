

using System;
//Employee Daily Wage
namespace EmployeeWage
{
    class program
    {
        public static void Main(string[] args)
        {
            int WorkingHr = 0;
            int perHrSalary = 20;

            Random rnd = new Random();
            int present = (rnd.Next(0 , 3));

            switch (present)
            {
                case 0:
                    Console.WriteLine("employee  is Absent");
                    WorkingHr = 0;
                    break;

                case 1:
                    Console.WriteLine("employee  is Present");
                    WorkingHr = 8;
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }

            int salary = WorkingHr * perHrSalary;
            Console.WriteLine($"Salary {salary}");
        }
    }
}
