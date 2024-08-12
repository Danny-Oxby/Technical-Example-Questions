namespace Technical_Example_Questions.SupportingMethods
{
    public class GenerateSimpleLists
    {
        /// <summary>
        /// Generate a list of fibinarchi numbers
        /// </summary>
        /// <param name="length">how many numbers are in the returned list</param>
        /// <returns>A list of fibinarchi numbers euqal in thength to the input</returns>
        public static int[] FibList(int length)
        {
            if (length <= 0) //if no length retrun empty list
                return Array.Empty<int>();

            List<int> numbers = new List<int>(); //unkown length so start as list then convert on return

            if (length > 0)
                numbers.Add(0);
            if (length > 1)
                numbers.Add(1);
            for (int i = 2; i < length; i++)
                numbers.Add(numbers[i - 2] + numbers[i - 1]);

            return numbers.ToArray();
        }
    }
}
