namespace Technical_Example_Questions.Models
{
    //for this example assume that a town can only have one cinema
    public class TownMdl
    {
        /// <summary>
        /// Create a town
        /// </summary>
        /// <param name="TName"> the name of the town</param>
        /// <param name="Cin"> the cinema in town if there is one </param>
        public TownMdl(string TName, bool Cin = false)
        {
            Name = TName;
            Cimema = Cin;
        }

        public string Name { get; private set; } //town name
        //public CinemaMdl? Cimema { get; private set; } //does the town have a cinema
        public bool Cimema { get; private set; } //does the town have a cinema

        public List<RoadMdl> Roads { get; set; } = new List<RoadMdl>(); // how does this town link to others

    }
}
