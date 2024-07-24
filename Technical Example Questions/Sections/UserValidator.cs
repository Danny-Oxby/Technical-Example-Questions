using System.Diagnostics.Metrics;

namespace Technical_Example_Questions.Sections
{
    /// <summary>
    /// Have the function CodelandUsernameValidation(str) take the str parameter being passed and determine if the string is a valid username according to the following rules:
    ///1. The username is between 4 and 25 characters.
    ///2. It must start with a letter.
    ///3. It can only contain letters, numbers, and the underscore character.
    ///4. It cannot end with an underscore character.
    ///If the username is valid then your program should return the string true, otherwise return the string false.
    /// </summary>
    public class UserValidator
    {
        public static bool CodelandUsernameValidation(string str)
        {
            //check the length conditions
            if (str.Length > 25 || str.Length < 4) { return false; }
            //check the first char is a letter << don't check for null string due to above line
            if (!char.IsLetter(str[0])) { return false; }
            //check for the trailing underscore
            if (str[^1] == '_') { return false; }
            //check for invalid chars
            foreach (char c in str) //loop through the input sting
            {
                if (!(char.IsLetterOrDigit(c) || c == '_')) { return false; }
            }

            // if not caught return true
            return true;
        }
    }
}
