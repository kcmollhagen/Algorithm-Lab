using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_3
{
    class Higher_or_Lower : Guesser
    {
        private int num;
        public Higher_or_Lower() : base()
        {
            Random r = new Random();
            num = r.Next(1, 101);
        }
        public override int Guess(int input)
        {
          
            if (num == input)
            {
                return num;
            }
            else if (num > input)
            {
                num--;
                guessCount++;
            }

            else if (num < input)
            {
                num++;
                guessCount++;
            }
            return Guess(input);

        }
    }
}
