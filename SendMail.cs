using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class SendMail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Mail Sent.");
        }
    }
}
