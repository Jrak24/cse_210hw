public abstract class MindfulnessActivity
{
    public abstract string ActivityName { get; }
    public abstract string Description { get; }
    protected int duration;

    public void StartActivity(int durationInSeconds)
    {
        duration = durationInSeconds;
        Console.WriteLine($"Starting {ActivityName}: {Description}");
        ExecuteActivity();
        EndActivity();
    }

    public void EndActivity()
    {
        Console.WriteLine($"Activity '{ActivityName}' has ended. Well done!");
        Console.WriteLine($"You spent {duration} seconds on this activity.");
    }

    protected abstract void ExecuteActivity();

    protected void Pause(int seconds)
    {
        System.Threading.Thread.Sleep(seconds * 1000);
    }
}