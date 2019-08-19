using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Die
    {
        public int[] sides = new int[] { 1, 2, 3, 4, 5, 6 };

        public void RollDie(Random rand)
        {
            RandomExtensions.Shuffle(rand, sides);         
        }
    }
}
