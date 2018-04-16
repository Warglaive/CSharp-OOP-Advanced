public class NightVision : Ammunition
{
    public const double Weight = 0.8;

    public NightVision(string name)
        : base(name, Weight)
    {
    }

    public double WearLevel { get; }
    public void DecreaseWearLevel(double wearAmount)
    {
        //
    }
}