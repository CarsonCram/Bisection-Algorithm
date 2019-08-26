using System;
using System.Linq;

namespace EX9A
{
    class Program
    {
        //Implement bisection algorithm
        //Write a console application implementing the bisection algorithm. 
        //As the initial list, use an integer array from 1 to 10, like this: 
        //int[] list = 1,2,3,4,5,6,7,8,9,10;. As input, have the user 
        //select a number from 1 to 10. Have the application print each 
        //step. Use appropriate exception handling to guard against 
        //invalid input from the user.

        static int implementBisection(int[] nums, int input)
        {
            bool exit = false;

            do
            {
                if (input == nums.Length / 2)
                {
                    return input;
                    exit = true;
                }
                else if (input < nums.Length / 2)
                {
                    for (int i = 0; i < nums.Length / 2; i++)
                    {

                    }
                }
                else if (input > nums.Length / 2)
                {
                    for (int i = (nums.Length / 2) + 1; i < nums.Length - 1; i++)
                    {

                    }
                }
                foreach(int i in nums)
                    Console.WriteLine(i);
            } while (exit == false);
            return input;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("EX9A.Program.Main()");

            Console.WriteLine("Please pick a full number between 1 and 10");
            int input = int.Parse(Console.ReadLine());
            int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(implementBisection(nums, input));
        }
    }
}
