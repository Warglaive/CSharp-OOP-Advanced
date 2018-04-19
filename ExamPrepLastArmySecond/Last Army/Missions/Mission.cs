public abstract class Mission : IMission
{
    public string Name { get; }
    public abstract double EnduranceRequired { get; }
    public double ScoreToComplete { get; }

    protected Mission(string name, double scoreToComplete)
    {
        this.Name = name;
        this.ScoreToComplete = scoreToComplete;
    }
    public abstract double WearLevelDecrement { get; }
}