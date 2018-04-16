public class NightVision : Ammunition
{
    public const double Weight = 0.8;
    public const double wearLevel = Weight * 100;

    public NightVision(string name)
        : base(name, Weight, wearLevel)
    {
    }
}