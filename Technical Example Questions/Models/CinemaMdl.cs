namespace Technical_Example_Questions.Models
{
    public class CinemaMdl
    {
        /// <summary>
        /// Build a new cinema
        /// </summary>
        /// <param name="CName"> What is the name of the cinema</param>
        public CinemaMdl(string CName)
        {
            Name = CName;
        }

        public string Name { get; private set; } //The cinema name
        public List<string> Movies { get; set; } = new List<string>(); // What moveies the cinema has

    }
}
