public class ReflectionActivity : MindfulnessActivity
{
    public override string ActivityName => "Reflection Activity";
    public override string Description => "Reflect on your day and think about what you are grateful for.";

    protected override void ExecuteActivity()
    {
        Console.WriteLine("Take a moment to reflect...");
        Pause(duration);
    }
}