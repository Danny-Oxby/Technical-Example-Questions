using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technical_Example_Questions.Sections;
using Xunit;

namespace QuestionTests
{
    public class AnnogramCheckerTest
    {
        /* Test
         * capital check
         * empty string 
         * duplicate letters
         * extra letters in str 2
         * same word
         * proper annogram
         */


        [Theory]
        [InlineData(" ", "", false)]
        [InlineData("abs", "aabbcc", false)]
        [InlineData("", "", true)]
        [InlineData("123456789", "123456789", true)]
        [InlineData("Tab", "Bat", true)]
        public void AnnogramChecker_CompareExpected(string word1, string word2, bool expectedRet)
        {
            bool ret = AnnogramChecker.AnnogramComparason(word1, word2);
            //does the expected and actual match
            Assert.Equal(expectedRet, ret);
        }
    }
}
