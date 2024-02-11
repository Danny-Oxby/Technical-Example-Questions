using Technical_Example_Questions.Sections;
using Xunit;

namespace QuestionTests
{
    public class FizzBuzzTest
    {
        #region single tests

        [Theory]
        [InlineData(-1, "Unsupported")]
        [InlineData(0, "0")]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void FindOneFizzBuzzTesting_Success(int testnumber, string expectedreturn)
        {
            Assert.Equal(FizzBuzz.FindOneFizzBuzz(testnumber), expectedreturn);
        }

        #endregion

        #region List tests
        //testable paths
        //list of 15
        //negitive
        //zero

        [Fact]
        public void FindFizzBuzzList_ValidInput_15()
        {
            string[] returnlist = { "0", "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" };

            List<string> fbvalues = FizzBuzz.FindFizzBuzzList(15);

            Assert.True(fbvalues.Any(), "Fizzbuzz list returned empty"); // has it returned any values
            Assert.True(fbvalues.Count == 16, "Fizzbuzz list returned with unexpected number of values"); //does it contined 0 to 15

            for(int i = 0;  i < fbvalues.Count; i++)
                Assert.Equal(returnlist[i], fbvalues[i]);
        }

        [Fact]
        public void FindFizzBuzzList_InvalidInput_Negitive()
        {

            List<string> fbvalues = FizzBuzz.FindFizzBuzzList(-1);

            Assert.True(fbvalues.Count == 1, "Fizzbuzz list returned with unexpected number of values");
            if(fbvalues.Count > 0)
                Assert.Equal("Negitive numbers unsupported", fbvalues[0]);
        }

        [Fact]
        public void FindFizzBuzzList_ValidInput_Zero()
        {

            List<string> fbvalues = FizzBuzz.FindFizzBuzzList(0);

            Assert.True(fbvalues.Count == 1, "Fizzbuzz list returned with unexpected number of values");
            if (fbvalues.Count > 0)
                Assert.Equal("0", fbvalues[0]);
        }
        #endregion
    }
}