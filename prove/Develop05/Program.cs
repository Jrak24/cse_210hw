using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        MindfulnessApp app = new MindfulnessApp();
        app.Run();
    }
}

class MindfulnessApp
{
    private List<MindfulnessActivity> activities;

    public MindfulnessApp()
    {
        activities = new List<MindfulnessActivity>
        {
            new BreathingActivity(),
            new ReflectionActivity(),
            new ListingActivity()
        };
    }

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            for (int i = 0; i < activities.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {activities[i].ActivityName}");
            }
            Console.WriteLine("0. Exit");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 0) break;

            if (choice > 0 && choice <= activities.Count)
            {
                activities[choice - 1].StartActivity();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}