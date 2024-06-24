namespace Technical_Example_Questions.Sections
{
    /// <summary>
    /// This class converts a sentence into lowercase then can be used to check the number of duplicate words in a 
    /// sentence. the current format of this method is not designed for equations and containing symbols, for example
    /// (3 * 4) + 10 = 22, the current methods will ground the brackets with the number retruning '(3' and '4)'.
    /// </summary>
    public class InstanceCounter
    {
        /// <summary>
        /// Main ctor
        /// </summary>
        public InstanceCounter()
        {
            
        }

        /// <summary>
        /// overloaded methods that allows the LoadSentence methods to be call on class new
        /// </summary>
        /// <param name="sentence">the string that will be checked</param>
        public InstanceCounter(string sentence)
        {
            LoadSentence(sentence);
        }


        //countiner for all found words
        private Dictionary<string, int> FoundWords = new Dictionary<string, int>();

        //array of all charactors that signify new words
        private static readonly char[] seperators = {' ', ',', '.', '?', '!', '/', '\\', '"', '\'' };

        /// <summary>
        /// Insert a sentence that can be checked by another method
        /// </summary>
        /// <param name="sentence">the string that will be checked</param>
        public void LoadSentence(string sentence)
        {
            FoundWords.Clear();

            foreach (string word in sentence.ToLower().Split(seperators))
            {
                if(word.Length < 1) { continue; } //skip current word if it's length is zero << this may happen for the following strings " '" or "!!!"

                if(FoundWords.TryGetValue(word, out _)) //the returned value can be ignored as we are only adding 1
                    FoundWords[word] ++;
                else
                    FoundWords.Add(word, 1);
            }
        }

        /// <summary>
        /// Check if the target 'word' is contained in the loaded sentence
        /// </summary>
        /// <param name="target">the 'word' that the user is trying to find</param>
        /// <returns>the number of time that 'word' occured in the sentence</returns>
        public int ReturnCount(string target)
        {
            //early break if the counter has need been seeded
            if(FoundWords.Count < 1) return 0;

            //retrun the found number of instances or 0 if there are none
            if(FoundWords.TryGetValue(target.ToLower(), out int value))
                return value;
            else return 0;
        }
    }
}
