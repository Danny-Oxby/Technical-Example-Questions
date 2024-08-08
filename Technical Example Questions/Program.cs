using System;
using System.Diagnostics;
using Technical_Example_Questions.Sections;
using Technical_Example_Questions.SupportingMethods;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GeneratePeople.PrintReturnedPerson(
            //    DataSearchingWithLinq.FindOldestPerson(
            //        GeneratePeople.GenerateClass()));

            var t = DataSearchingWithLinq.FindMostCommonName(GeneratePeople.GenerateCrowd());
        }

        private static void StringIntersectionCheck()
        {
            IntersectingArray.FindIntersectionNoLinq(new string[] { "1, 3, 4, 7, 13", "1, 2, 4, 13, 15" });
            IntersectingArray.FindIntersection(new string[] { "1, 3, 4, 7, 13", "1, 2, 4, 13, 15" });
        }

        private static void UsernameValidation()
        {
            Console.WriteLine(UserValidator.CodelandUsernameValidation("aa_"));
            Console.WriteLine(UserValidator.CodelandUsernameValidation("12345678901234567890123456"));
            Console.WriteLine(UserValidator.CodelandUsernameValidation("1_xcvd"));
            Console.WriteLine(UserValidator.CodelandUsernameValidation("1234567_"));
            Console.WriteLine(UserValidator.CodelandUsernameValidation("valid"));
        }

        private static void SymetricalTrees()
        {
            GenerateBinaryTrees Trees = new GenerateBinaryTrees();

            Console.WriteLine(TreeSymmetry.IsTreeSymmetrical(Trees.GenerateSymetricalTree()));
            Console.WriteLine(TreeSymmetry.IsTreeSymmetrical(Trees.GenerateNonSymetricalTree()));
        }

        private static void Number_CountAndSay()
        {
            Console.WriteLine(CountAndSaySequence.CountAndSay(5));
            Console.WriteLine(CountAndSaySequence.CountAndSay(7));
        }

        private static void InstanceCounter()
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

        //curretn test is linmited by the length of string find longer annogram before testing again
        private static void AnnogramCheckerSpeedComparason()
        {
            Stopwatch sw = new(); // used to check

            long[,] timervalues = new long[2, 10];

            for (int index = 0; index < 10; index++)
            {
                sw = Stopwatch.StartNew();

                AnnogramChecker.AnnogramComparason("aab", "abc");
                AnnogramChecker.AnnogramComparason("sdfgh", "123");
                AnnogramChecker.AnnogramComparason("little", "ltitle");

                timervalues [0, index] = sw.ElapsedMilliseconds;
            }

            for (int index = 0; index < 10; index++)
            {
                sw = Stopwatch.StartNew();

                AnnogramChecker.AnnogramComparason_DirVer("aab", "abc");
                AnnogramChecker.AnnogramComparason_DirVer("sdfgh", "123");
                AnnogramChecker.AnnogramComparason_DirVer("little", "ltitle");

                timervalues[1, index] = sw.ElapsedMilliseconds;
            }

            sw.Stop();

            timervalues.ToString();
        }

        private static void AnnogramCheckerMethodCall()
        {
            Console.WriteLine(AnnogramChecker.AnnogramComparason("aab", "abc"));
            Console.WriteLine(AnnogramChecker.AnnogramComparason("sdfgh", "123"));
            Console.WriteLine(AnnogramChecker.AnnogramComparason("little", "ltitle"));
        }

        private static void AnnogramCheckerDirMethodCall()
        {
            Console.WriteLine(AnnogramChecker.AnnogramComparason_DirVer("aab", "abc"));
            Console.WriteLine(AnnogramChecker.AnnogramComparason_DirVer("sdfgh", "123"));
            Console.WriteLine(AnnogramChecker.AnnogramComparason_DirVer("little", "ltitle"));
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