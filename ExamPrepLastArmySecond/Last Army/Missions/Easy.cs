public class Easy : Mission
{
    private const int enduranceRequired = 20;
    private const int wearLevelDecrement = 30;

    private const string MissionName = "Suppression of civil rebellion";

    public Easy(double scoreToComplete)
        : base(scoreToComplete)
    {
    }

    public override string Name => MissionName;
    public override double EnduranceRequired => enduranceRequired;
    public override double WearLevelDecrement => wearLevelDecrement;
}