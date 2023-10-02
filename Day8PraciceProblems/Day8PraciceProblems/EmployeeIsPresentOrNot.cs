using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8PraciceProblems
{
    internal class EmployeeIsPresentOrNot
    {
        public void EmployeePresentOrAbsent()
        {
            //constants
            int Is_Full_Time = 1;
            Random rnd = new Random();
            //Computation
            int empCheck = rnd.Next(0, 2);
            if (empCheck == Is_Full_Time)
            {
                Console.WriteLine("Employee Is Present");
            }
            else
            {
                Console.WriteLine("Employee Is Not Present");
            }
            Console.ReadLine();
        }
    }
}
