using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_3
{
    class Rando : Guesser
    {
        public override int Guess(int input)
        {
            Random r = new Random();
            int randomNumber = 0;

            while (input != randomNumber)
            {
                randomNumber = r.Next(1, 101);
                guessCount++;
            }
            return guessCount;
        }
    }
}
