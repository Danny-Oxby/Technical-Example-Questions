using Technical_Example_Questions.Sections;
using Xunit;

namespace QuestionTests
{
    public class InstanceCounterTest
    {

        [Theory] // this can also be tested using a collection, but for small sets I prefer inline
        [InlineData(" ", "spacing check   ")]
        [InlineData(".", "full stop. . .")]
        [InlineData(",", "comma, ooou, ou, ouuuu, , , ")]
        [InlineData("!", "exclamation!!! ! ")]
        [InlineData("?", "question? who dun it? ? ? ")]
        [InlineData("/", "front/slash / ")]
        [InlineData("\\", "back\\slash \\ ")]
        [InlineData("\"", "\"quotation\" \" ")]
        [InlineData("\'", "apostrophe' '  ' ")]
        //check that all expected types of punctuation are being correctly caught
        public void InstanceCounter_PunctuationCheck(string punctionation, string search)
        {
            InstanceCounter punctuationCounter = new InstanceCounter(search);

            Assert.Equal(0, punctuationCounter.ReturnCount(punctionation));
        }

        [Fact]
        //check that new sentences clears the array and that the method works as intended using the default ctor
        public void InstanceCounter_NewSentenceCheck() 
        {
            InstanceCounter punctuationCounter = new InstanceCounter();
            punctuationCounter.LoadSentence("First Sentence.");

            Assert.Equal(1, punctuationCounter.ReturnCount("first")); //ensure the mwthods properly read the stirng
            Assert.Equal(1, punctuationCounter.ReturnCount("Sentence"));

            punctuationCounter.LoadSentence("Second Sentence.");
            Assert.Equal(0, punctuationCounter.ReturnCount("first")); // ensure origonal string is gone
            Assert.Equal(1, punctuationCounter.ReturnCount("second")); // ensure new word added
            Assert.Equal(1, punctuationCounter.ReturnCount("Sentence")); // ensure old word has correct count
        }

        [Fact]
        //check that the method can handle enpty strings
        public void InstanceCounter_EmptyStr()
        {
            //check how the class works with no loaded string
            InstanceCounter punctuationCounter = new InstanceCounter();
            Assert.Equal(0, punctuationCounter.ReturnCount(""));
            Assert.Equal(0, punctuationCounter.ReturnCount("a"));

            //check how an empty string works
            punctuationCounter.LoadSentence("");
            Assert.Equal(0, punctuationCounter.ReturnCount(""));
            Assert.Equal(0, punctuationCounter.ReturnCount("a"));
        }

        [Fact]
        public void InstanceCounter_CapsCheck()
        {
            InstanceCounter punctuationCounter = new InstanceCounter("Word, word, WoRd, WORd, wORD");
            Assert.Equal(5, punctuationCounter.ReturnCount("Word"));
            Assert.Equal(5, punctuationCounter.ReturnCount("word"));
        }
    }
}
