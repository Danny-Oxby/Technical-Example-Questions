using System;
using Technical_Example_Questions.Sections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            STPathFinding roadMap = new STPathFinding();
            Console.Write(roadMap.FindNearestCinema("A2"));
        }

        private static void RunningTotalMethodCall()
        {
            double[] inputArray = new double[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            foreach (double value in RunningTotal.FindRunningTotal(inputArray))
                Console.WriteLine(value.ToString(), ", ");
        }

        private static void FizzbuzzMethodCall()
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