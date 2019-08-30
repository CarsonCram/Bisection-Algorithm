using System;
using System.Collections.Generic;
using System.Linq;

namespace EX9A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EX9A.Program.Main()");

            Console.WriteLine("Please pick a full number between 1 and 10");
            int input = int.Parse(Console.ReadLine());
            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Q1.implementBisection(nums, input);

            int guess = 10001;

            while (guess > 1000)
            {
                Console.WriteLine("Please Enter a number between 1 and 1000");
                guess = int.Parse(Console.ReadLine());
                Q2.HumanGuess(guess);
            }

            int num = 101;
            var numbers = Enumerable.Range(1, 100).ToList();

            while (num > 100)
            {
                Console.WriteLine("Please choose a number between 1 and 100.");
                num = int.Parse(Console.ReadLine());

                Q3.ComputerGuess(num);
            }
        }
    }
}
