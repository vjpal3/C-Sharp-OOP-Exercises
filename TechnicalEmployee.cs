using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDX_OOP_Exercises
{
    class TechnicalEmployee : Employee
    {
        public int successfulCheckIns = 5;
        public TechnicalEmployee(string name) : base(name, 75000)
        {
            
        }

        public override string EmployeeStatus()
        {
            return this.ToString() + " has " + this.successfulCheckIns + " successful check ins";
        }

    }
}
