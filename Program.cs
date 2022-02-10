using System;
//employee present or absent
namespace EmployeeWage
{
    class program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == 0)
            {
                Console.WriteLine("employee is present");
            }
            else
            {
                Console.WriteLine("employee is absent");
            }

        }
    }
}
