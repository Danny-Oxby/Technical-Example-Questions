using System;
using Technical_Example_Questions.Sections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ParenthesesMethodCall();
        }

        private static void ParenthesesMethodCall()
        {
            Console.WriteLine(BalancedParentheses.BalanceChecker("aa"));
            Console.WriteLine(BalancedParentheses.BalanceChecker("{[]}()"));
            Console.WriteLine(BalancedParentheses.BalanceChecker("{()})("));
            Console.WriteLine(BalancedParentheses.BalanceChecker("{(})[]"));
            Console.WriteLine(BalancedParentheses.BalanceChecker("{[()()(()())()(())]}"));
        }

        private static void AnnogramCheckerMethodCall()
        {
            Console.WriteLine(AnnogramChecker.AnnogramComparason("aab", "abc"));
            Console.WriteLine(AnnogramChecker.AnnogramComparason("sdfgh", "123"));
            Console.WriteLine(AnnogramChecker.AnnogramComparason("little", "ltitle"));
        }

        private static void PathFindingMethodCall()
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