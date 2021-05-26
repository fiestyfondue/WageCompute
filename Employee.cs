using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class Employee
    {
        readonly int IS_FULL_TIME = 1;
        readonly int EMP_RATE_PER_HOUR = 20;
        readonly int FULL_DAY_HOUR = 8;

        public void Attendance()
        {
            Random random = new Random();
            int Attendance = random.Next(0, 2);
            if (Attendance == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
                CalculateWage();
            }
            else
            {
                Console.WriteLine("Employee is absent");
                Console.WriteLine("Employee wage is null");

            }
        }

        public void CalculateWage()
        {
            int Wage = FULL_DAY_HOUR * EMP_RATE_PER_HOUR;
            Console.WriteLine("Wage: " + Wage);
            Console.ReadLine();
        }

    }
}
