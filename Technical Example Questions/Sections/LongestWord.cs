namespace Technical_Example_Questions.Sections
{
    /// <summary>
    /// Have the function LongestWord(sen) take the sen parameter being passed and return the longest word in the string. 
    /// If there are two or more words that are the same length, return the first word from the string with that length. 
    /// Ignore punctuation and assume sen will not be empty. 
    /// Words may also contain numbers, for example "Hello world123 567"
    /// </summary>
    public class LongestWord
    {
        public static string FindLongestWord(string sen)
        {
            if (sen.Length == 0)
                return sen;

            //keep track of the current workd and the current longest
            string Longest = "";
            string CurrentWord = "";

            foreach (char c in sen) //loop through the input sting
            {
                if (char.IsLetterOrDigit(c)) { CurrentWord += c; } //only mark the valid charactors
                else if (c == ' ')
                { //if there is a new word check length
                    if (CurrentWord.Length > Longest.Length) { Longest = CurrentWord; }
                    CurrentWord = string.Empty;
                }
            }

            //chack word length after loop << this will chack the last work (as sentences dont end with a space)
            if (CurrentWord.Length > Longest.Length) { Longest = CurrentWord; }

            return Longest;
        }

    }
}
