public abstract class Mission : IMission
{
    public string Name { get; }
    public double EnduranceRequired { get; }
    public double ScoreToComplete { get; }
    public double WearLevelDecrement { get; }
}