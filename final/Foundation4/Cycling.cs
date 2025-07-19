public class Cycling : Activity
{
    public double SpeedMph { get; private set; }

    public Cycling(string date, int lengthMin, double speedMph)
        : base(date, lengthMin)
    {
        SpeedMph = speedMph;
    }

    public override double GetDistance()
    {
        return SpeedMph * LengthMin / 60;
    }

    public override double GetSpeed()
    {
        return SpeedMph;
    }

    public override double GetPace()
    {
        return 60 / SpeedMph;
    }
}
