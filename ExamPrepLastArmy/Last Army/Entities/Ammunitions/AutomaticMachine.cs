public class AutomaticMachine : Ammunition
{
    public const double Weight = 6.3;

    public AutomaticMachine(string name)
        : base(name, Weight)
    {
    }

    public double WearLevel { get; }
    public void DecreaseWearLevel(double wearAmount)
    {
        //
    }
}