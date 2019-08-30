using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDX_OOP_Exercises
{
    abstract class Employee
    {
        private string employeeName;
        private double employeeSalary;
        private int employeeId;
        private static int employeeCount = 1;

        public string Name
        {
            get
            {
                return employeeName;
            } 
            set
            {
                employeeName = value;
            }
        }

        public double BaseSalary
        {
            get
            {
                return employeeSalary;
            }
            set
            {
                employeeSalary = value;
            }
        }

        public int ID
        {
            get
            {
                return employeeId;
            }
            set
            {
                employeeId = value;
            }
        }

        public Employee (string name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
        }

        public string getName()
        {
            return this.Name;
        }
        public double getBaseSalary()
        {
            return this.BaseSalary;
        }

        public String ToString()
        {
            return this.ID + " " + this.Name;
        }

        //public virtual string EmployeeStatus()
        //{
        //    return ToString() + " is in the company's system.";
        //}

        public abstract string EmployeeStatus();
    }
}
