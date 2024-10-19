public class ListingActivity : MindfulnessActivity
{
    public override string ActivityName => "Listing Activity";
    public override string Description => "List things you are grateful for.";

    protected override void ExecuteActivity()
    {
        Console.WriteLine("Start listing things you are grateful for:");
        for (int i = 0; i < duration / 10; i++) // Assuming 10 seconds per item
        {
            Console.WriteLine($"Item {i + 1}: ");
            Console.ReadLine(); // User inputs their gratitude item
        }
    }
}