using Technical_Example_Questions.Models;

namespace Technical_Example_Questions.SupportingMethods
{
    public static class GeneratePeople
    {
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

        public static int[] FibList(int length)
        {
            if (length <= 0) //if no length retrun empty list
                return Array.Empty<int>();

            List<int> numbers = new List<int>(); //unkown length so start as list then convert on return

            if(length > 0) 
                numbers.Add(0);
            if (length > 1)
                numbers.Add(1);
            for(int i = 2; i < length; i++)
                numbers.Add(numbers[i-2] + numbers[i-1]);

            return numbers.ToArray();
        }

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
