public class Helmet : Ammunition
{
    public const double Weight = 2.3;
    public const double wearLevel = Weight * 100;
    public Helmet(string name)
        : base(name, Weight, wearLevel)
    {
    }
}