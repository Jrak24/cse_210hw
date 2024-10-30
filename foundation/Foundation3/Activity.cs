using System;

public abstract class Activity
{
    private DateTime _date;
    private int _duration; // in minutes

    public Activity(DateTime date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {GetType().Name} ({_duration} min): Distance: {GetDistance():F1}, Speed: {GetSpeed():F1}, Pace: {GetPace():F2}";
    }
}
