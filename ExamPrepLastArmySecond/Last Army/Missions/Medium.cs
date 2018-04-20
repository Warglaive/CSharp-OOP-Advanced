public class Medium : Mission
{
    private const int enduranceRequired = 50;
    private const int wearLevelDecrement = 50;
    private const string MissionName = "Capturing dangerous criminals";

    public Medium(double scoreToComplete)
        : base( scoreToComplete)
    {
    }

    public override string Name => MissionName;
    public override double EnduranceRequired => enduranceRequired;
    public override double WearLevelDecrement => wearLevelDecrement;
}