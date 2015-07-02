using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {

        static void Main(string[] args)
        {
            GuessNum();
        }

        static void GuessNum()
        {
            int numToGuess = 42;
            int userGuess = 0;

            while (userGuess != numToGuess)
            {
                Console.WriteLine("Enter your guess between 1 to 100");

                // checks whether the user enters the numeric value and
                // that number is between 1- 100
                // if not print Incorrect message to the user
                bool validInput = int.TryParse(Console.ReadLine(), out userGuess);
                bool validRange = (0 <= userGuess) && (userGuess <= 100);

                if (!validInput || !validRange || (userGuess != numToGuess))
                {
                    Console.WriteLine("Incorrect");
                }
                else
                {
                    Console.WriteLine("Correct");
                    Environment.Exit(0);
                }
            }
        }
    }
}
