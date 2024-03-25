namespace Technical_Example_Questions.Sections
{
    //given an array of numbers return a new array of the same length where
    //the position in the new array is equal to all previouse values in the
    // old array
    public class RunningTotal
    {
        /// <summary>
        /// Calcualte the running total of a list of numbers
        /// </summary>
        /// <param name="originAry"> the list of numbers to be converted</param>
        /// <returns>List containing the running totla of previouse list</returns>
        public static double[] FindRunningTotal(double[] originAry)
        {
            if (originAry.Length == 0) // check for bad values
                return new double[] { 0 };

            List<double> RTotal = new();
            double currentTotal = 0;
            
            //add the total value
            foreach (double i in originAry)
            {
                currentTotal += i; // if becomes a problem break out of loop if currentTotal > int.max
                RTotal.Add(currentTotal);
            }
            //return the list as an array
            return RTotal.ToArray();
        }

    }
}
