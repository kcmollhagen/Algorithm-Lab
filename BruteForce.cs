﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_3
{
    class BruteForce : Guesser
    {
       
        public override int Guess(int input)
        {
            while(input != guessCount)
            { 
                guessCount++;
            }
            return guessCount;
        }
    }
}
