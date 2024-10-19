public class BreathingActivity : MindfulnessActivity
{
    public override string ActivityName => "Breathing Activity";
    public override string Description => "Focus on your breathing for a few minutes.";

    protected override void ExecuteActivity()
    {
        Console.WriteLine("Breathe in... (hold for 4 seconds)");
        Pause(4);
        Console.WriteLine("Breathe out... (hold for 4 seconds)");
        Pause(4);
    }
}