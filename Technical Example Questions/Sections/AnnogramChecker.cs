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
    }
}
