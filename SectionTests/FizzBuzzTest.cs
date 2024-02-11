using Xunit;

namespace SectionTests
{
    public class FizzBuzzTest
    {
        [Theory]
        [InlineData(-1, "Unsupported")]
        [InlineData(0, "0")]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void TestMethod1(int testnumber, string expectedreturn)
        {
            //FizzBuzz fb = new FizzBuzz();
            //Assert.Equal()
        }
    }
}
