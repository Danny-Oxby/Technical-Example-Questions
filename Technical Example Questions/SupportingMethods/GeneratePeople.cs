using Technical_Example_Questions.Models;

namespace Technical_Example_Questions.SupportingMethods
{
    public static class GeneratePeople
    {
        /// <summary>
        /// Generate a family of 5 with 2 pearents and 3 children
        /// </summary>
        /// <returns>The list of that family</returns>
        public static Person[] GenerateSmallFamily()
        {
            //generate children
            Person Child1 = new("Ray", new DateOnly(2998, 11, 11), "Scunthorpe");
            Person Child2 = new("Clair", new DateOnly(2997, 3, 8), "Scunthorpe");
            Person Child3 = new("Shanon", new DateOnly(2004, 10, 23), "Scunthorpe");
            //generate parents
            Person Mother = new("Heather", new DateOnly(1977, 4, 25), "Scunthorpe");
            Person Father = new("Jeremy", new DateOnly(1975, 6, 18), "Scunthorpe");
            //Add the children to their parents
            Mother.Children = new Person[] { Child1, Child2, Child3 };
            Father.Children = new Person[] { Child1, Child2, Child3 };

            //retrun the list of all people
            return new Person[] { Mother, Father, Child1, Child2, Child3 };
        }

        /// <summary>
        /// Generate a class of 10 people, 1 teacher 9 students
        /// </summary>
        /// <returns>The generated class of people</returns>
        public static Person[] GenerateClass()
        {
            return new Person[] {
            //generate students
            new("Liam", new DateOnly(2004, 9, 8), "Lincoln"),
            new("Noah", new DateOnly(2005, 5, 14), "Gainsborough"),
            new("James", new DateOnly(2004, 10, 16), "Lincoln"),
            new("Henrey", new DateOnly(2004, 11, 26), "Lincoln"),
            new("William", new DateOnly(2005, 3, 11), "Scampton"),
            new("Emma", new DateOnly(2004, 10, 4), "Scampton"),
            new("Charlot", new DateOnly(2005, 1, 5), "Lincoln"),
            new("Ava", new DateOnly(2005, 1, 8), "Lincoln"),
            new("Evelyn", new DateOnly(2004, 12, 18), "Saxilby"),
            //generate teacher
            new("Sophia", new DateOnly(1953, 10, 23), "North Hykeham") };
        }

        /// <summary>
        /// Generate a group of 25 people with varing places to live
        /// </summary>
        /// <returns>The generated list of people born bwtenn 1980 and 2010</returns>
        public static Person[] GenerateGroupWithVaringAges()
        {
            return new Person[]
            {
                new("Adam", new DateOnly(2010, 12, 10), "Saxilby"),
                new("Daniel", new DateOnly(2000, 1, 8), "Lincoln"),
                new("Sam", new DateOnly(1980, 2, 6), "Gainsborough"),
                new("Connor", new DateOnly(1990, 3, 4), "Saxilby"),
                new("Harry", new DateOnly(2010, 4, 2), "Scampton"),
                new("Charls", new DateOnly(1980, 5, 10), "Saxilby"),
                new("Julious", new DateOnly(2020, 6, 8), "North Hykeham"),
                new("Harry", new DateOnly(2000, 7, 6), "Scampton"),
                new("Gengouse", new DateOnly(2010, 8, 4), "Lincoln"),
                new("George", new DateOnly(1980, 9, 2), "Gainsborough"),
                new("Henry", new DateOnly(1990, 10, 10), "Gainsborough"),
                new("Rose", new DateOnly(2000, 11, 8), "Saxilby"),
                new("Betty", new DateOnly(1990, 12, 6), "Lincoln"),
                new("Charlot", new DateOnly(1980, 1, 4), "North Hykeham"),
                new("Amanda", new DateOnly(1980, 2, 2), "Scampton"),
                new("Lilly", new DateOnly(2000, 3, 10), "Lincoln"),
                new("Charlot", new DateOnly(2010, 4, 8), "Scampton"),
                new("Sophie", new DateOnly(1990, 5, 5), "Lincoln"),
                new("Rose", new DateOnly(2000, 6, 4), "Gainsborough"),
                new("Maya", new DateOnly(1980, 7, 2), "Saxilby"),
                new("Rosaline", new DateOnly(2020, 8, 10), "North Hykeham"),
                new("Jane", new DateOnly(1990, 9, 8), "Gainsborough"),
                new("Sophie", new DateOnly(2010, 10, 6), "Saxilby"),
                new("Illia", new DateOnly(1980, 11, 4), "Scampton"),
                new("Sophie", new DateOnly(2020, 12, 2), "Lincoln"),
            };
        }

        /// <summary>
        /// Generate a list of people with only names
        /// </summary>
        /// <returns>A list of 5 people with some duplicate names</returns>
        public static Person[] GenerateCrowd()
        {
            return new Person[] {
                new("Joe"),     new("Adam"),    new("Joe"),     new("Tim"),     new("Bob"),
                new("Terry"),   new("Tom"),     new("Joe"),     new("Ben"),     new("Bill"),
                new("Harry"),   new("Mark"),    new("Connor"),  new("Harry"),   new("Tom"),
                new("Daniel"),  new("Sam"),     new("Connor"),  new("Harry"),   new("Charls"),
                new("Julious"), new("Harry"),   new("Gengouse"), new("George"), new("Henry"),
                new("Rose"),    new("Betty"),   new("Charlot"), new("Amanda"),  new("Lilly"),
                new("Charlot"), new("Sophie"),  new("Rose"),    new("Maya"),    new("Rosaline"),
                new("Danni"),   new("Vanessa"), new("Rose"),    new("Maya"),    new("Elora"),
                new("Jane"),    new("Sophie"),  new("Illia"),   new("Sophie"),  new("Vanessa"),
                new("Evaline"), new("Jane"),    new("Jill"),    new("Jane"),    new("Emmalie")
            };
        }

        /// <summary>
        /// Generate a list of towns matching those set in generate class
        /// </summary>
        /// <returns>A list of generates towns, with their names and cinema state</returns>
        public static TownMdl[] TownList()
        {
            return new TownMdl[]
            {
                new("Lincoln", true),
                new("Gainsborough", true),
                new("Scampton", false),
                new("Saxilby", false),
                new("North Hykeham", false)
            };
        }

        /// <summary>
        /// Generate a list of towns that have a cinema
        /// </summary>
        /// <returns>A list of generates towns, with their names and cinema state</returns>
        public static TownMdl[] CinemaList()
        {
            return new TownMdl[]
            {
                new("Lincoln", true),
                new("Gainsborough", true)
            };
        }

        /// <summary>
        /// Prints out all information contained in a person modle to the console
        /// </summary>
        /// <param name="person">The values that will be printed to the console</param>
        public static void PrintReturnedPerson(Person person)
        {
            if (person.Name != "N/A")
                Console.WriteLine("Name: " + person.Name);
            if (person.DOB != new DateOnly())
                Console.WriteLine("Date Of Birth: " +person.DOB);
            if (person.City != "N/A")
                Console.WriteLine("Residing In: " + person.City);
            if (person.Children != Array.Empty<Person>() && person.Children != null)
                Console.WriteLine("Number of Children:" + person.Children.Length);
        }

    }
}
