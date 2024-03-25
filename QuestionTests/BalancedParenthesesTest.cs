using Technical_Example_Questions.Sections;
using Xunit;

namespace QuestionTests
{
    public class BalancedParenthesesTest
    {
        [Theory]
        [InlineData("{[]}()", true)]
        [InlineData("{[()()(()())()(())]}", true)]
        [InlineData("{(})[]", false)]
        [InlineData("", false)]
        [InlineData("a", false)]
        [InlineData("{}[", false)]
        public void BalancedParentheses_CompareExpected(string checkValue, bool expectedRet)
        {
            bool ret = BalancedParentheses.BalanceChecker(checkValue);
            //does the expected and actual match
            Assert.Equal(expectedRet, ret);
        }
    }
}
