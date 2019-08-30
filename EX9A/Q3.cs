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
        public static int ComputerGuess(int answer)
        {
            int max = 100;
            int min = 0;
            int mid = (max + min) / 2;
            bool exit = false;

            while (exit == false)
            {
                if (answer == mid)
                {
                    Console.WriteLine("The computer guessed {0}, which is " +
                        "the same as the answer {1}!", mid, answer);
                    exit = true;
                }
                else
                {
                    Console.WriteLine($"The computer guessed {mid}, too high or too low?");
                    string direction = Console.ReadLine();

                    if (direction == "too high")
                    {
                        max = mid;
                        mid = (max + min) / 2;
                    }
                    else
                    {
                        min = mid;
                        mid = (max + min) / 2;
                    }
                }
            }
            return mid;
        }
    }
}