using System;

class ListingActivity : MindfulnessActivity
{
    private static readonly string[] Prompts = 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", 
        "This activity will help you reflect on the good things in your life by listing them.")
    {
    }

    public override void ExecuteActivity()
    {
        Random random = new Random();
        string prompt = Prompts[random.Next(Prompts.Length)];
        Console.WriteLine(prompt);
        Pause(5);

        Console.WriteLine("Start listing now! Press Enter for each item.");
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"You listed {count} items.");
        EndActivity();
    }
}
