using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDX_OOP_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new TechnicalEmployee("Ashka");
            var employee2 = new TechnicalEmployee("Zamalya");
            var employee3 = new BusinessEmployee("Esther");

            Console.WriteLine(employee1.EmployeeStatus());
            Console.WriteLine(employee2.EmployeeStatus());
            Console.WriteLine(employee3.EmployeeStatus());
        }
    }
}
