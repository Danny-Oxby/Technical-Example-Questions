namespace Technical_Example_Questions.Sections
{

    //Given a string with the just the six characters - ‘(’, ‘)’, ‘{’, ‘}’, ‘[’ and ‘]’.
    //Determine if the string is balanced.

    //A string is balanced if all brackets exist in pairs and are closed in the correct order.

    //Example:
    //String: ({})[]
    //Result: Balanced

    //String: {()})(
    //Result: Not Balanced

    //String: {(})[]
    //Result: Not Balanced
    public static class BalancedParentheses
    {
        //define a list of each matching
        private static readonly Dictionary<char, char> MatchingPairs = new Dictionary<char, char>()
        {
            { '(', ')' },
            { '{', '}' },
            { '[', ']' }
        };

        /// <summary>
        /// taking a string of parentheses check if all items properly close
        /// </summary>
        /// <param name="ParString"> the string to check </param>
        /// <returns> bool if all internal parentheses close correctly</returns>
        public static bool BalanceChecker(string ParString)
        {
            //check for bad values
            if (string.IsNullOrEmpty(ParString)) //empty value string is false
                return false; 

            if (ParString.Length % 2 == 1) //odd number strings are always false
                return false;

            //create storage
            Stack<char> openBrackets = new Stack<char>(); //stackt o store open cases

            //check value
            foreach (char c in ParString)
            {
                if (openBrackets.Count != 0) //see if item is the closing set
                {
                    if (MatchingPairs[openBrackets.Peek()] == c) //remove from list if matching
                        openBrackets.Pop();
                    else // add to list if not
                    {
                        //exit early if a closing bracket would be added to the stack, (also prevents invalid unputs)
                        if (!MatchingPairs.ContainsKey(c))
                            return false;

                        openBrackets.Push(c);
                    }
                }
                else //if no items in stack 
                {
                    //exit early if a closing bracket would be added to the stack, (also prevents invalid unputs)
                    if (!MatchingPairs.ContainsKey(c))
                        return false;

                    openBrackets.Push(c);
                }
            }

            //if the stack still has values retrun false else return true
            return openBrackets.Count == 0;
        }
    }
}
