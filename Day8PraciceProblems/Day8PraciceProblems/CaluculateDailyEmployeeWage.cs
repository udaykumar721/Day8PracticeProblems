﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8PraciceProblems
{
    internal class CaluculateDailyEmployeeWage
    {
        public void CheckEmployeeWageDaily()
        {
            int Is_Full_Time = 1;
            int Emp_Rate_Per_Hour = 20;
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == Is_Full_Time)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Employee Wage : {0}", +empWage);
            Console.ReadLine();
        }
    }
 
}
