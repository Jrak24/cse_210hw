public class CyclingActivity : Activity
{
    private double _speed; // in mph

    public CyclingActivity(DateTime date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed / 60) * Duration(); // Distance in miles
    }

    public override double GetSpeed()
    {
        return _speed; // Speed in mph
    }

    public override double GetPace()
    {
        return 60 / _speed; // Pace in min per mile
    }

    private int Duration()
    {
        return (int) GetType().GetProperty("Duration").GetValue(this, null);
    }
}
