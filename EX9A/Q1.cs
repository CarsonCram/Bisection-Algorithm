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
            Console.WriteLine($"int[] list = {numsList}");

            List<int> answer = new List<int>();

            if (input == numsList.Count / 2)
            {
                Console.WriteLine($"value is {input}");
                answer.Add(input);
                return answer;
            }
            else if (input < numsList.Count / 2)
            {
                Console.WriteLine($"value is < {numsList.Count / 2}");

                numsList.RemoveRange(numsList.Count / 2, numsList.Count - 1);
                numsList = implementBisection(numsList, input);
            }
            else if (input > numsList.Count / 2)
            {
                Console.WriteLine($"Value is > {numsList.Count / 2}");

                numsList.RemoveRange(0, numsList.Count / 2);
                numsList = implementBisection(numsList, input);
            }
            return answer;
        }
    }
}
