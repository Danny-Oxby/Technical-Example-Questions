namespace Technical_Example_Questions.Sections
{
    public class AnnogramChecker
    {
        /// <summary>
        /// Compare two strings to see if one is an annogram of another, not case sensitive
        /// </summary>
        /// <param name="str1">string to find</param>
        /// <param name="str2">string to compare against</param>
        /// <returns>true if one is another annogram of another</returns>
        public static bool AnnogramComparason(string str1, string str2)
        {
            //check for common potential diffrences
            if (str1 == null || str2 == null) return false; //two nulls dont make a right
            if(str1.Length != str2.Length) return false;

            str1 = str1.ToLower();
            str2 = str2.ToLower();

            foreach (char c in str1)
            {
                if (!str2.Contains(c)) //check if the charactor is in the string
                    return false;
                else //remove the charactor from the string
                    str2 = str2.Remove(str2.IndexOf(c), 1);
            }
            //if no more chars in list return true
            return true;
        }

        /// <summary>
        /// Compare two strings to see if one is an annogram of another using a dictionary, not case sensitive
        /// </summary>
        /// <param name="str1">string to find</param>
        /// <param name="str2">string to compare against</param>
        /// <returns>true if one is another annogram of another</returns>
        public static bool AnnogramComparason_DirVer(string str1, string str2)
        {
            //check for common potential diffrences
            if (str1 == null || str2 == null) return false; //two nulls dont make a right
            if (str1.Length != str2.Length) return false;

            Dictionary<char, int> charactorCounter = new();

            //try to add each letter if already exists increase the counter
            foreach(char c in str1.ToLower())
            {
                if (!charactorCounter.TryAdd(c, 1))
                    charactorCounter[c]++;
            }

            //check the number of chars in string two matches
            foreach (char c in str2.ToLower())
            {
                //check the value exists and is not zero
                if (!charactorCounter.TryGetValue(c, out int value) || value == 0)
                    return false;
                //remoave one form the dir to prevent double counting
                charactorCounter[c] --;
            }

            //due to string equals chack at the start, there is no need to check that all items = zero here
            return true;
        }
    }
}
