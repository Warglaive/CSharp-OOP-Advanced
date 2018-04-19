public class Easy : Mission
{
    private const int enduranceRequired = 20;
    private const int wearLevelDecrement = 30;

    public Easy(string name, double scoreToComplete)
        : base(name, scoreToComplete)
    {
    }

    public override double EnduranceRequired => enduranceRequired;
    public override double WearLevelDecrement => wearLevelDecrement;
}