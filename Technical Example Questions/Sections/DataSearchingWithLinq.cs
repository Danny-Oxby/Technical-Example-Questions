using Technical_Example_Questions.Models;

namespace Technical_Example_Questions.Sections
{
    public static class DataSearchingWithLinq
    {
        /// <summary>
        /// search in intList of any values that is a multiple of the provided multiple
        /// </summary>
        /// <param name="intList">the list to search against</param>
        /// <param name="multiple">the multiple value to search</param>
        /// <returns>an int list containing all the found multiple values</returns>
        public static int[] FindMultipleValues(int[] intList, int multiple)
        {
            return (from num in intList where (num % multiple == 0) select num).ToArray();
        }

        /// <summary>
        /// Search a provided list to find the oldest person
        /// </summary>
        /// <param name="searchList"> the list of TYPE(People) to search</param>
        /// <returns>the found person or null if the input is invalid</returns>
        public static Person? FindOldestPerson(Person[] searchList)
        {
            //if the input has no values return null
            if(searchList == null || searchList == Array.Empty<Person>()) return null;

            //else order the inputted table by age
            IEnumerable<Person>? Oldest = from person in searchList 
                            orderby person.DOB ascending select person;

            //alternate search returning a list of 1
            //IEnumerable<Person>? Oldest = from p in searchList where p.DOB == searchList.Min(o => o.DOB)
            //               select p;

            return Oldest.First();
        }

        /// <summary>
        /// Find the fist instances of a name in a given list
        /// </summary>
        /// <param name="searchList"> the list to search</param>
        /// <returns>a string array containing one of every found name</returns>
        public static string[] FindAllUniqueNames(Person[] searchList)
        {
            //if the input has no values return empty list
            if (searchList == null || searchList == Array.Empty<Person>()) return Array.Empty<string>();

            //var v = from person in searchList
            //        group person by person.Name;

            IEnumerable<string> n = from person in searchList //manditory start of linq sequence
                                    group person by person.Name into nameList //optional grouping
                                    orderby nameList.Key ascending //option ordering
                                    select nameList.Key; //select the return properties

            return n.ToArray();
        }

        /// <summary>
        /// Find the most common name and the number of times it occures in a given list
        /// </summary>
        /// <param name="searchList"> the list to search </param>
        /// <returns> the most common name (in ASc order) and it's occurence rate </returns>
        public static (string name, int count) FindMostCommonName(Person[] searchList)
        {
            //if the input has no values return empty value
            if (searchList == null || searchList == Array.Empty<Person>()) return ("", 0);

            var v = (from person in searchList //manditory start of linq sequence
                    group person by person.Name into nameList //optional grouping
                    orderby nameList.Count() descending //option ordering
                    select new
                    {
                        Name = nameList.Key,
                        Counter = nameList.Count()
                    }).First(); //create an annonomus return type reprosenting the touple

            return (v.Name, v.Counter);
        }
    }
}
