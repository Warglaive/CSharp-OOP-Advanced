public class Hard : Mission
{
    private const int enduranceRequired = 80;
    private const int wearLevelDecrement = 70;
    private const string MissionName = "Disposal of terrorists";

    public Hard(double scoreToComplete)
        : base(scoreToComplete)
    {
    }


    public override string Name => MissionName;
    public override double EnduranceRequired => enduranceRequired;
    public override double WearLevelDecrement => wearLevelDecrement;
}