public class Hard : Mission
{
    private const int enduranceRequired = 80;
    private const int wearLevelDecrement = 70;

    public Hard(string name, double scoreToComplete)
        : base(name, scoreToComplete)
    {
    }


    public override double EnduranceRequired => enduranceRequired;
    public override double WearLevelDecrement => wearLevelDecrement;
}