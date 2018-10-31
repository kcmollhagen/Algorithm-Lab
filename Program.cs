using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_3
{
    class Program
    {
        static void Main(string[] args)
        {  
            GuessingGameApp ga = new GuessingGameApp();

            Guesser brute = new BruteForce();
            Console.WriteLine();

            int code = ga.num;
            int guess = brute.Guess(code);
            brute.PrintGuesses();

            Guesser rando = new Rando();
            Console.ReadLine();
            Console.WriteLine();
            guess = rando.Guess(code);
            rando.PrintGuesses();
            Console.ReadLine();

            Guesser higherorlower = new Higher_or_Lower();
            Console.ReadLine();
            Console.WriteLine();
            guess = higherorlower.Guess(code);
            higherorlower.PrintGuesses();
            Console.ReadLine();

        }
    }
}
