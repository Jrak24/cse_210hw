public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(DateTime date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000.0; // Distance in km
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Duration()) * 60; // Speed in kph
    }

    public override double GetPace()
    {
        return Duration() / GetDistance(); // Pace in min per km
    }

    private int Duration()
    {
        return (int) GetType().GetProperty("Duration").GetValue(this, null);
    }
}
