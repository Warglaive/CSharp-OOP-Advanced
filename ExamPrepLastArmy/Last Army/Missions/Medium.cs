public class Medium : Mission
{
    private const string name = "Capturing dangerous criminals";
    private const double enduranceRequired = 50;
    private const double wearLevelDecrement = 50;
    public override string Name => name;

    public override double EnduranceRequired => enduranceRequired;
    public override double WearLevelDecrement => wearLevelDecrement;

    public Medium(double scoreToComplete)
        : base(scoreToComplete)
    {

    }
}