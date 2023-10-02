using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8PraciceProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EmployeeIsPresentOrNot epom = new EmployeeIsPresentOrNot();
            //epom.EmployeePresentOrAbsent();
            CaluculateDailyEmployeeWage cedw = new CaluculateDailyEmployeeWage();
            cedw.CheckEmployeeWageDaily();
            Console.ReadLine();
        }
    }
}
