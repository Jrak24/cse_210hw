public class SimpleGoal : Goal
{
    public SimpleGoal(string description, int points)
    {
        Description = description;
        Points = points;
        IsComplete = false;
    }

    public override void RecordProgress()
    {
        if (!IsComplete)
        {
            IsComplete = true;
            Console.WriteLine($"Goal completed! You earned {Points} points.");
        }
        else
        {
            Console.WriteLine("Goal already completed.");
        }
    }

    public override string DisplayStatus()
    {
        return IsComplete ? "[X] " + Description : "[ ] " + Description;
    }
}

public class EternalGoal : Goal
{
    public EternalGoal(string description, int points)
    {
        Description = description;
        Points = points;
    }

    public override void RecordProgress()
    {
        Console.WriteLine($"You earned {Points} points for completing the goal: {Description}.");
    }

    public override string DisplayStatus()
    {
        return "[ ] " + Description + " (Eternal Goal)";
    }
}

public class ChecklistGoal : Goal
{
    public int RequiredTimes { get; set; }
    public int TimesCompleted { get; private set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string description, int points, int requiredTimes, int bonusPoints)
    {
        Description = description;
        Points = points;
        RequiredTimes = requiredTimes;
        BonusPoints = bonusPoints;
        TimesCompleted = 0;
        IsComplete = false;
    }

    public override void RecordProgress()
    {
        if (TimesCompleted < RequiredTimes)
        {
            TimesCompleted++;
            Console.WriteLine($"You earned {Points} points. Completed {TimesCompleted}/{RequiredTimes}.");

            if (TimesCompleted == RequiredTimes)
            {
                IsComplete = true;
                Console.WriteLine($"Goal completed! You earned a bonus of {BonusPoints} points.");
            }
        }
        else
        {
            Console.WriteLine("Goal already completed.");
        }
    }

    public override string DisplayStatus()
    {
        return IsComplete ? "[X] " + Description + $" (Completed {TimesCompleted}/{RequiredTimes})" : "[ ] " + Description + $" (Completed {TimesCompleted}/{RequiredTimes})";
    }
}
