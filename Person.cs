using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Property
{
    class Person
    {
        public DateTime Birthdate { get; private set; }
        public int Age
        {
            // Not an auto implemented property.
            // Age is calulated and returned.
            // no set accessor method defined so the person object is always in a valid state.
            get
            {
                var timespan = DateTime.Today - Birthdate;
                return timespan.Days / 365;
            }
        }

        public Person(DateTime birthdate)
        {
            // Set Birthdate only once here so the person object is always in a valid state.
            Birthdate = birthdate;
        }
    }
}
