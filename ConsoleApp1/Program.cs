using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var num = Enumerable.Range(0, 200).ToList();

            Console.WriteLine(num.Count);
            Console.WriteLine(num[num.Count - 1]);
            
        }

    }
}
