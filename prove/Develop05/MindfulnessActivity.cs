using System;

abstract class MindfulnessActivity
{
    public string ActivityName { get; }
    public string ActivityDescription { get; }
    protected int Duration { get; private set; }

    protected MindfulnessActivity(string name, string description)
    {
        ActivityName = name;
        ActivityDescription = description;
    }

    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Starting {ActivityName}...\n{ActivityDescription}");
        Console.Write("Enter duration in seconds: ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready to begin...");
        Pause(3);
    }

    protected void Pause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }

    public abstract void ExecuteActivity();

    public void EndActivity()
    {
        Console.WriteLine("Good job! You completed the activity.");
        Console.WriteLine($"Duration: {Duration} seconds");
        Pause(3);
    }
}
