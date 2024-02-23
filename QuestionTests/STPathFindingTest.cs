using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technical_Example_Questions.Sections;
using Xunit;

namespace QuestionTests
{
    public class STPathFindingTest
    {

        //list of tests
        //path less than nearest cinema
        //start at cinema
        //start at 6 and 5 spaces away
        //location that dosn't exist

        [Theory]
        [InlineData("Nope", "There is no town with that name")]
        [InlineData("A1", "There is no town with a cinema within this distance", 1)]
        [InlineData("A2", "There is no town with a cinema within this distance", 4)]
        public void STPathFindingTest_Errorconditions(string startingLocation, string returnResult, int PathLength = 99)
        {
            STPathFinding pf = new STPathFinding();

            string ret = pf.FindNearestCinema(startingLocation, PathLength);
            //does the expected and actual match
            Assert.Equal(returnResult, ret);
        }

        [Theory]
        [InlineData("A1", "Your nearest Cinema is at : B2")]
        [InlineData("B4", "Your nearest Cinema is at : C4")]
        [InlineData("B3", "Your nearest Cinema is at : A3")]
        [InlineData("C1", "Your nearest Cinema is at : B2")]
        [InlineData("C3", "Your nearest Cinema is at : C3")]
        [InlineData("C4", "Your nearest Cinema is at : C4")]
        public void STPathFindingTest_SuccessfulPathing(string startingLocation, string returnResult)
        {
            STPathFinding pf = new STPathFinding();

            string ret = pf.FindNearestCinema(startingLocation);
            //does the expected and actual match
            Assert.Equal(returnResult, ret);
        }
    }
}
