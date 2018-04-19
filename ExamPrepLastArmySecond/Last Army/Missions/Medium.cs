public class Medium : Mission
{
    private const int enduranceRequired = 50;
    private const int wearLevelDecrement = 50;

    public Medium(string name, double scoreToComplete)
        : base(name, scoreToComplete)
    {
    }

    public override double EnduranceRequired => enduranceRequired;
    public override double WearLevelDecrement => wearLevelDecrement;
}