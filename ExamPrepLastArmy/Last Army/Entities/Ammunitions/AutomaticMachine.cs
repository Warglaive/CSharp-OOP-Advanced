public class AutomaticMachine : Ammunition
{
    public const double Weight = 6.3;
    public const double wearLevel = Weight * 100;
    public AutomaticMachine(string name)
        : base(name, Weight, wearLevel)
    {
    }
}