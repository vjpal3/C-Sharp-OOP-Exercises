﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class DynamicDie
    {
        public List<int> DieSides = new List<int>();

        public DynamicDie(int sides)
        {
            for (var i = 0; i < sides; i++)
                DieSides.Add(i+1);
        }
        public void RollDie(Random rand)
        {
            RandomExtensions.Shuffle(rand, DieSides);
        }

    }
}
