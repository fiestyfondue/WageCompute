using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class Employee
    {
        public const int  IS_FULL_TIME = 1;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int FULL_DAY_HOUR = 8;
        public const int IS_PART_TIME = 2;
        int Emphrs = 0;
        int Wage = 0;


        public void Attendance()
        {
            Random random = new Random();
            int Attendance = random.Next(0, 3);
            switch (Attendance)
            {
                case IS_PART_TIME:
                    Emphrs = 4;
                    break;
                case IS_FULL_TIME:
                    Emphrs = 8;
                    break;
                default:
                    Emphrs = 0;
                    break;
            }
            Wage = Emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Wage: " + Wage);
            Console.ReadLine();
        }
    }
}
