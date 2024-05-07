using System;
using Technical_Example_Questions.Sections;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        static void Main(string[] args)
        {
            InstanceCounter counter = new InstanceCounter();
            counter.LoadSentence("This will be my example sentence, it checks the number of times that a 'word' has been writen!!!" +
                "For example, 'orange, orange, orange' will return 3, right?");
            Console.WriteLine(counter.ReturnCount("orange"));
            Console.WriteLine(counter.ReturnCount("pinapple"));
            Console.WriteLine(counter.ReturnCount("3"));
            Console.WriteLine(counter.ReturnCount("4"));
            Console.WriteLine(counter.ReturnCount(""));
            Console.WriteLine(counter.ReturnCount("example"));
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