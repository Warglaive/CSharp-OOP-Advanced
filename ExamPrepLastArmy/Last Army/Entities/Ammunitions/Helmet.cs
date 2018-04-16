public class Helmet : Ammunition, IAmmunition
{
    public const double Weight = 2.3;

    public Helmet(string name)
        : base(name, Weight)
    {
    }

    public double WearLevel { get; }
    public void DecreaseWearLevel(double wearAmount)
    {
        //
    }
}