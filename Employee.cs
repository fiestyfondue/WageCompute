using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    class Employee
    {
        readonly int IS_FULL_TIME = 1;
        
        public void Attendance()
        {
            Random random = new Random();
            int Attendance= random.Next(0, 2);
            if (Attendance == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
           
        }
    }
}
