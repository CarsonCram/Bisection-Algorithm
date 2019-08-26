using System;
using System.Collections.Generic;
using System.Text;

namespace EX9A
{
    class Q2
    {
        //Guess my number, human plays
        //Implement a version of Guess My Number, where the 
        //computer randomly chooses a number between 1 and 1000, 
        //and the human guesses the number.In this case, the 
        //program should print a hint with each repetition, 
        //either<Your guess was too high>, <Your guess was too 
        //low>, or<You guessed the number>.The human should then 
        //input the next guess. Run this multiple times and 
        //compute the average number of repetitions necessary for 
        //you to guess the number.
        
        public static int HumanGuess()
        {
            int r = new Random().Next(1, 1001);
            int guess = 1001;

            while (guess > 1000)
            {
                Console.WriteLine("Please Enter a number between 1 and 1000");
                guess = int.Parse(Console.ReadLine());
            }

            while (guess != r)
            {
                if (guess == r)
                {
                    Console.WriteLine("You guessed the number!");
                    return guess;
                }
                else if (guess > r)
                {
                    Console.WriteLine($"{guess} is too high, please try again.");
                    guess = int.Parse(Console.ReadLine());
                }
                else 
                {
                    Console.WriteLine($"{guess} is too low, please try again.");
                    guess = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
