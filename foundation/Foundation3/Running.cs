public class RunningActivity : Activity
{
    private double _distance; // in miles

    public RunningActivity(DateTime date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / Duration()) * 60; // Speed in mph
    }

    public override double GetPace()
    {
        return Duration() / _distance; // Pace in min per mile
    }

    private int Duration()
    {
        return (int) GetType().GetProperty("Duration").GetValue(this, null);
    }
}
