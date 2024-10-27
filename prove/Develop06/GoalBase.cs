public abstract class Goal
{
    public string Description { get; set; }
    public int Points { get; set; }
    protected bool IsComplete { get; set; }

    public abstract void RecordProgress();
    public abstract string DisplayStatus();
}
