using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //add so you dont have to write console.writeline

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 1;
            int max = 11;
            int guess;

            const int MAX_TRIES = 3;
            int counter = 1;


            Random ranNumberGenerator = new Random();
            int randomNumber;

            randomNumber = ranNumberGenerator.Next(min, max);

            //Write("Guess a number between {0} and {1} >> ", min, max - 1);
            //guess = Convert.ToInt32(ReadLine());

            //WriteLine(" The secret number was {0} ", randomNumber);

            while (counter <= MAX_TRIES)
            {
                Write("Guess a number between {0} and {1} >> ", min, max - 1);
                guess = Convert.ToInt32(ReadLine());

                if (guess < randomNumber)
                {                  

                    WriteLine(" Your guess was too low ");
                }
                else if (guess > randomNumber)
                {
                    WriteLine(" your guess is too high ");
                }
                else
                {
                    WriteLine(" your guess was correct ");
                    break;

                }

               

                counter++;
            }
            ReadKey();
        }
    }
}
