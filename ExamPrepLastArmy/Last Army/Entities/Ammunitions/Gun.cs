public class Gun : Ammunition, IAmmunition
{
    public const double Weight = 1.4;

    public Gun(string name)
        : base(name, Weight)
    {
    }

    public double WearLevel { get; }
    public void DecreaseWearLevel(double wearAmount)
    {
        //
    }
}