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
        public static int[] FindMultipleValues(int[] intList, int multiple) //SIMPLE WHERE
        {
            if(multiple == 0) { return Array.Empty<int>(); } //return empty list if multi is 0
            return (from num in intList where (num % multiple == 0 && num != 0) select num).ToArray();
        }

        /// <summary>
        /// Search a provided list to find the oldest person
        /// </summary>
        /// <param name="searchList"> the list of TYPE(People) to search</param>
        /// <returns>the found person or null if the input is invalid</returns>
        public static Person? FindOldestPerson(Person[] searchList) //BASIC SEARCH
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
        /// Find the first instances of a name in a given list
        /// </summary>
        /// <param name="searchList"> the list to search</param>
        /// <returns>a string array containing one of every found name</returns>
        public static string[] FindAllOccuringNames(Person[] searchList) //GROUPING
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
        public static (string name, int count) FindMostCommonName(Person[] searchList) //SPECIFING RETURN
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

        /// <summary>
        /// Find the maxium number of people who can watch a film with a given age rating, This methos uses a fixed date of 1/1/2020 for age calcs (this is convienint for this example)
        /// </summary>
        /// <param name="maxAud">A list of of people, where they live and their DOB</param>
        /// <param name="cinemas">A list of towns and if they have a cinema</param>
        /// <param name="filmAge">The age to filter the maxAud by</param>
        /// <returns>A list of all the people near a cinema in the target age group, or an empty list if input is invlid</returns>
        public static Person[] FindExpectedAudence(Person[] maxAud, TownMdl[] cinemas, int filmAge) //INNER JOIN
        {
            if(maxAud == Array.Empty<Person>() && cinemas == Array.Empty<TownMdl>())
                return Array.Empty<Person>(); // would try catch be better for this check?

            //find all people in the maxAud list who live near a cinema AND are above the minium age
            var expected = from person in maxAud
                                join town in cinemas on person.City equals town.Name
                                where person.DOB < new DateOnly(2020 - filmAge, 1, 1) && town.Cimema == true
                                select person;

            return expected.ToArray();
        }

        public static int NumberOfPeoplrWithoutCinemaAccess(Person[] maxAud, TownMdl[] cinemas)
        {
            if (maxAud == Array.Empty<Person>() && cinemas == Array.Empty<TownMdl>())
                return 0;

            //find all people in the maxAud list who live near a cinema AND are above the minium age
            var expected = from person in maxAud
                           join town in cinemas on person.City equals town.Name
                           group town by town.Cimema into cinemalist
                           where cinemalist.Key == false
                           select cinemalist.Count();

            return expected.First();
        }
    }
}
