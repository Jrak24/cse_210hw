class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalPoints = 0;

    static void Main(string[] args)
    {
        // Sample goals for demonstration
        goals.Add(new SimpleGoal("Run a Marathon", 1000));
        goals.Add(new EternalGoal("Read Scriptures", 100));
        goals.Add(new ChecklistGoal("Attend Temple", 50, 10, 500));

        // Display goals
        DisplayGoals();

        // Record progress
        goals[0].RecordProgress(); // Mark SimpleGoal complete
        goals[1].RecordProgress(); // Record EternalGoal
        goals[2].RecordProgress(); // Record ChecklistGoal progress

        // Display updated goals
        DisplayGoals();
    }

    static void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.DisplayStatus());
        }
    }
}
