namespace Technical_Example_Questions.Sections
{
    public class FizzBuzz
    {
        //Find if any positive integer number is a multiple of 3, 5 or both
        public static string FindOneFizzBuzz(int number)
        {
            //zero's are not counted as valid multiples in this example
            if (number == 0) return "0";
            //negitive numbers are currently un supported
            if (number < 0) return "Unsupported";

            string fizzbuzz = "";

            //find the fizzbuzz value
            if (number % 3 == 0) fizzbuzz += "Fizz";
            if (number % 5 == 0) fizzbuzz += "Buzz";
            if (fizzbuzz.Length == 0) fizzbuzz = number.ToString();

            return fizzbuzz;
        }

        //For a list of positive intigers find all multiples of 3, 5 or both
        public static List<string> FindFizzBuzzList(int LastNumber)
        {
            List<string> FizzBuzz = new List<string>();
            //unsupported outcomes
            if(LastNumber < 0)
            {
                FizzBuzz.Add("Negitive numbers unsupported");
                return FizzBuzz;
            }
            //for all supported outcomes
            for(int i = 0; i <= LastNumber; i++)
            {
                FizzBuzz.Add(FindOneFizzBuzz(i));
            }

            return FizzBuzz;
        }

    }
}
