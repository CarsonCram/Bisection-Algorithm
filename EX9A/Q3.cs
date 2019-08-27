using System;
using System.Collections.Generic;
using System.Text;

namespace EX9A
{
    //Guess my number, computer plays
    //Implement a version of Guess My Number, where the human chooses a 
    //number between 1 and 100, and the computer guesses the number.The 
    //human should be able to tell the computer whether the computer’s 
    //guess was too high, too low, or was the correct answer.Run this 
    //multiple times and compute the average number of repetitions 
    //necessary for the computer to guess the number. Have the program 
    //print the value, the guess, and the list on each repetition.

       
    class Q3                                                                                 
    {
        static int guess = 50;
        public static void ComputerGuess(int num)
        {
            if (guess == num)
                Console.WriteLine($"The computer guessed {guess}, which is " +
                    $"the right answer!");
            else 
            {
                while (guess != num)
                {
                    Console.WriteLine($"The computer guessed {guess}, " +
                        $"too high or too low?");
                    string input = Console.ReadLine();

                    if (input == "too high")
                    {
                        guess /= 2;
                        ComputerGuess(num);
                    }
                    else
                    {
                        guess += (guess / 2);
                        ComputerGuess(num);
                    }
                }
            }
        }
    }
}
