public abstract class Mission
{
    public double EnduranceRequired { get; set; }
    public double ScoreToComplete { get; set; }

    public Mission(double enduranceRequired, double scoreToComplete)
    {
        this.EnduranceRequired = enduranceRequired;
        this.ScoreToComplete = scoreToComplete;
    }
}