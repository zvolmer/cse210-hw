public abstract class Activity
{
    public string Date { get; private set; }
    public int LengthMin { get; private set; }

    public Activity(string date, int lengthMin)
    {
        Date = date;
        LengthMin = lengthMin;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return Date
            + " " + GetType().Name
            + " (" + LengthMin + " min)- Distance "
            + GetDistance() + " miles, Speed "
            + GetSpeed() + " mph, Pace: "
            + GetPace() + " min per mile";
    }
}
