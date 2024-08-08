namespace Technical_Example_Questions.Models
{
    public class Person
    {
        public Person() { }
        public Person(string name, DateOnly birth, string house) { 
            Name = name;
            DOB = birth;
            City = house;
        }
        public Person(string name, DateOnly birth) {
            Name = name;
            DOB = birth;
        }
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; set; } = "N/A";
        public DateOnly DOB { get; set; } //date of birth
        public string City { get; set; } = "N/A";
        public Person[]? Children { get; set; } //do they have any children
    }
}
