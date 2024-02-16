using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technical_Example_Questions.Sections;
using Xunit;

namespace QuestionTests
{
    public class RunningTotalTest
    {
        //test
        //list of 0
        //list of 1
        //long list
        //decimal list
        //max int?

        [Theory]
        [InlineData(new double[] { 5,5,5,5,5,5,5,5,5,5,5,5,5,5,5 }, 
            new double[] { 5,10,15,20,25,30,35,40,45,50,55,60,65,70,75 })]
        [InlineData(new double[] { 1,2,3,4,5,6,7,8,9,10 },
            new double[] { 1,3,6,10,15,21,28,36,45,55 })]
        [InlineData(new double[] { .5, .4, .3, .2, .1 },
            new double[] { .5, .9, 1.2, 1.4, 1.5 })]
        [InlineData(new double[] { },
            new double[] { 0 })]
        [InlineData(new double[] { 100 },
            new double[] { 100 })]
        public void FindRunningTotal_CompareExpected(double[] inputList, double[] expectedReturn)
        {
            double[] ret = RunningTotal.FindRunningTotal(inputList);
            //dose the expected and catual match
            Assert.Equal(expectedReturn, ret);
        }

    }
}
