namespace Technical_Example_Questions.Sections
{
    public class CountAndSaySequence
    {
        /* format example
         1.   1
         2.   11
         3.   21
         4.   1211
         5.   111221
         */

        /// <summary>
        /// convert a integer number into something?
        /// </summary>
        /// <param name="n"> number of itterations, 1 <= N <= 40, recursive?</param>
        /// <returns>the string say value</returns>
        public static string CountAndSay(int n)
        {
            if (n == 1)
                return "1";

            // n-1 as "1" is the first value
            return SayGenerator("1", n-1);
        }

        private static string SayGenerator(string lastSaid, int recursionCounter)
        {
            //if counter is 0 retrun the Said line
            if(recursionCounter == 0)
                return lastSaid;

            string CurrentlySaid = "";
            int StrPos = 0;

            //itterate ove the string counting mathcing values
            while(StrPos < lastSaid.Length)
            {
                char targetChar = lastSaid[StrPos];
                int counter = 0;

                while (StrPos < lastSaid.Length && lastSaid[StrPos] == targetChar) //while the number is the same counter the duplicates and update the pointer
                {
                    counter++;
                    StrPos++;
                }
                //add the current number to the said list
                CurrentlySaid += $"{counter}{targetChar}";
            }

            //remove 1 from the counter an pass in the last said line
            return SayGenerator(CurrentlySaid, recursionCounter-1);
        }
    }
}
