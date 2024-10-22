using System;
using System.Collections.Generic;
using System.Threading;

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
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("Choose an activity:");
            for (int i = 0; i < activities.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {activities[i].ActivityName}");
            }
            Console.WriteLine("0. Exit");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice) && choice >= 0 && choice <= activities.Count)
            {
                if (choice == 0) break;
                activities[choice - 1].StartActivity();
                activities[choice - 1].ExecuteActivity();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Pause(2);
            }
        }
    }

    private void Pause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }
}
