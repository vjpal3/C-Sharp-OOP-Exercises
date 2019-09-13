using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Property
{
    class Person
    {
        public DateTime Birthdate { get; set; }
        public int Age
        {
            get
            {
                var timespan = DateTime.Today - Birthdate;
                return timespan.Days / 365;
            }
        }
    }
}
