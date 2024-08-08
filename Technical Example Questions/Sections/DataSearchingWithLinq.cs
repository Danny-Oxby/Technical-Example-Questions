using Technical_Example_Questions.Models;

namespace Technical_Example_Questions.Sections
{
    public static class DataSearchingWithLinq
    {
        //public string[] FindMostCommonNames(Person[] searchList)
        //{
        //    string[] names = from person in searchList select person.Name;
        //} 

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
    }
}
