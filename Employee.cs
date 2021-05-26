﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class WageCondition
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;


        public void EmpWage()
        {
            int empHrs = 0, totalempHrs = 0, totalWorkingDays = 0;
            while (totalempHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalempHrs += empHrs;
                Console.WriteLine("Number of days :" + totalWorkingDays + "Employee hours :" + empHrs);
            }
            int totalEmpWage = totalempHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total emp Wage: " + totalEmpWage);
        }
    }
}
