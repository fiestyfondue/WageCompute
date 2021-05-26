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
        readonly int IS_PART_TIME = 2;
        int Emphrs = 0;

        public void Attendance()
        {
            Random random = new Random();
            int Attendance = random.Next(0, 3);
            if (Attendance == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present and full time.");
                Emphrs = 8;
                CalculateWage();
            }
            else if (Attendance == IS_PART_TIME)
            {
                Console.WriteLine("Employee is part time");
                Emphrs = 4;
                CalculateWage();
            }
            else
            {
                Console.WriteLine("Employee is absent");
                Console.WriteLine("Employee Wage is Null");
            }
        }


        public void CalculateWage()
        {
                int Wage = Emphrs * EMP_RATE_PER_HOUR;
                Console.WriteLine("Wage: " + Wage);
                Console.ReadLine();
            }

        }        
}
