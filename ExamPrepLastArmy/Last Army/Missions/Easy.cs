public class Easy : Mission
{
    private const string name = "Suppresion of civil rebellion";
    private const double enduranceRequired = 20;
    private const double wearLevelDecrement = 30;
    public override string Name => name;

    public override double EnduranceRequired => enduranceRequired;
    public override double WearLevelDecrement => wearLevelDecrement;

    public Easy(double scoreToComplete) 
        : base(scoreToComplete)
    {

    }
}