namespace Technical_Example_Questions.Models
{
    // a list of possible states a computer can be, in a network (for this example)
    public enum SystemStates
    {
        Offline = 1,
        Active = 2,
        Error = 3,
        Disconnected = 4,
        Sync = 5,
        Partying = 6, //because even computers need a break
    }
}
