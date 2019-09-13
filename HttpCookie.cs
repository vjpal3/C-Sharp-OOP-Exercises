using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Indexers
{

    // HttpCookie class is a wrapper around dictionary, with some added functionality. 
    // It uses dictionary for data storage.
    class HttpCookie
    {
        private readonly Dictionary<string, string> dictionary = new Dictionary<string, string>();
        public DateTime Expiry { get; set; }

        // define indexer
        public string this[string key]
        {
            get { return dictionary[key]; }
            set { dictionary[key] = value;  }
        }
    }
}
