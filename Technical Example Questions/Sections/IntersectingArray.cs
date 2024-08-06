namespace Technical_Example_Questions.Sections
{
    /// <summary>
    /// FindIntersection(strArr) read the array of strings stored in strArr which will contain 2 elements: 
    /// the first element will represent a list of comma-separated numbers sorted in ascending order, 
    /// the second element will represent a second list of comma-separated numbers (also sorted). 
    /// Your goal is to return a comma-separated string containing the numbers that occur in elements of strArr in sorted order.
    /// If there is no intersection, return the string false.
    /// </summary>
    public class IntersectingArray
    {
        public static string FindIntersection(string[] strArr)
        {
            //sperate the input into seperate strings
            string[] array1 = strArr[0].Split(',');
            string[] array2 = strArr[1].Split(',');

            string[] interectionArray = array1.Intersect(array2).ToArray();
            if(interectionArray.Length == 0)
            {
                return "false";
            }
            else
            {
                string returnValue = string.Empty;
                foreach(string str in interectionArray)
                {
                    returnValue = string.Join(",", returnValue, str);
                }
                return returnValue.Remove(0, 1).Replace(" ", "");
            }
        }

        /// <summary>
        /// Find intersection method without using the inbuilt linq method
        /// </summary>
        /// <param name="strArr">input array</param>
        /// <returns>list of intersected numbers or faase if no elements exist</returns>
        public static string FindIntersectionNoLinq(string[] strArr)
        {
            //sperate the input into seperate strings
            string[] array1 = strArr[0].Split(',');
            string[] array2 = strArr[1].Split(',');

            //convert the string arrays into int for comparason
            List<int> element1Array = new();
            foreach (string num in array1) {   element1Array.Add(int.Parse(num));  }

            List<int> element2Array = new();
            foreach (string num in array2) { element2Array.Add(int.Parse(num)); }

            int array1Tracker = 0, array2Tracker = 0; // the pointer of each array

            bool allChecked = false; //loop exit condition
            string returnValue = string.Empty;

            do
            {
                //if either pointers have exceeded thier list update the bool (no more items to compare)
                if (array1Tracker >= element1Array.Count || array2Tracker >= element2Array.Count)
                { allChecked = true; }
                else
                {
                    if (element1Array[array1Tracker] > element2Array[array2Tracker]) { array2Tracker++; }
                    if (element1Array[array1Tracker] < element2Array[array2Tracker]) { array1Tracker++; }

                    if (element1Array[array1Tracker] == element2Array[array2Tracker])
                    {
                        //add the value to the retrun string
                        returnValue = returnValue.Insert(returnValue.Length, $",{element1Array[array1Tracker]}");
                        //update both trackers << we are checking for pairs not multiples so both move
                        array1Tracker++;
                        array2Tracker++;
                    }
                }

            } while (!allChecked);

            if (returnValue != string.Empty)
            {
                return returnValue.Remove(0, 1);
            }
            else
            {
                return "false";
            }
        }
    }
}
