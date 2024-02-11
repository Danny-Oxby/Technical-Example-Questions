using System;
using Technical_Example_Questions.Sections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FizzBuzz.FindOneFizzBuzz(15));
            Console.WriteLine("-----------------------------");
            foreach (string item in FizzBuzz.FindFizzBuzzList(15))
            {
                Console.Write(item + ", ");
            }
        }
    }
}