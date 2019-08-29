using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX9A
{
    public class Q1
    {
        //Implement bisection algorithm
        //Write a console application implementing the bisection algorithm. 
        //As the initial list, use an integer array from 1 to 10, like this: 
        //int[] list = 1,2,3,4,5,6,7,8,9,10;. As input, have the user 
        //select a number from 1 to 10. Have the application print each 
        //step. Use appropriate exception handling to guard against 
        //invalid input from the user.
        public static List<int> implementBisection(List<int> numsList, int input)
        {
            Console.WriteLine($"int value = {input}");
            showNumsList(numsList);

            int mid = numsList.Count / 2;
 
            if (numsList.Count % 2 == 1)
            {
                if (input == numsList[mid])
                {
                    Console.WriteLine($"The value searched for, {mid}, is the same as that given, {input}");
                    return new List<int> { numsList[mid] };
                }
                else if (input > numsList[mid])
                {
                    Console.WriteLine($"The value is greater than {mid}");
                    numsList.RemoveRange(0, numsList.Count - mid);
                    numsList = implementBisection(numsList, input);
                }
                else if ( input < numsList[mid])
                {
                    Console.WriteLine($"The value is less than {mid}");
                    numsList.RemoveRange(mid, numsList.Count - mid);
                    numsList = implementBisection(numsList, input);
                }
            }
            else
            {
                if (input > numsList[mid - 1])
                {
                    Console.WriteLine($"The value is greater than {numsList[mid - 1]}");
                    numsList.RemoveRange(0, numsList.Count - mid);
                    numsList = implementBisection(numsList, input);
                }
                else if (input < numsList[mid - 1])
                {
                    Console.WriteLine($"The value is less than {numsList[mid]}");
                    numsList.RemoveRange(mid, numsList.Count - 1);
                    numsList = implementBisection(numsList, input);
                }
                else if (input == numsList[mid - 1])
                {
                    Console.WriteLine($"The value is equal to {numsList[mid - 1]}");
                    numsList = new List<int> { numsList[mid - 1] };
                    numsList = implementBisection(numsList, input);
                }
            }
            return new List<int> { numsList[mid] };
        }

        static void showNumsList(List<int> numsList)
        {
            Console.WriteLine("List: ");
            foreach (int num in numsList)
                Console.Write($"{num} ");
            Console.WriteLine();
        }
    }
}