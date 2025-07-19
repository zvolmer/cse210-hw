public class Running : Activity
{
    public double DistanceMiles { get; private set; }

    public Running(string date, int lengthMin, double distanceMiles)
        : base(date, lengthMin)
    {
        DistanceMiles = distanceMiles;
    }

    public override double GetDistance()
    {
        return DistanceMiles;
    }

    public override double GetSpeed()
    {
        return DistanceMiles / LengthMin * 60;
    }

    public override double GetPace()
    {
        return LengthMin / DistanceMiles;
    }
}
