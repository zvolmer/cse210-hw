public class Lecture : Event
{
    public string Speaker { get; private set; }
    public int Capacity { get; private set; }

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        Speaker = speaker;
        Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return GetStandardDetails() + "\nSpeaker: " + Speaker + "\nCapacity: " + Capacity;
    }
}
