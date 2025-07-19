public class Swimming : Activity
{
    public int Laps { get; private set; }

    public Swimming(string date, int lengthMin, int laps)
        : base(date, lengthMin)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * 50 / 1000.0 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / LengthMin * 60;
    }

    public override double GetPace()
    {
        return LengthMin / GetDistance();
    }
}
