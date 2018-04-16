public class Gun : Ammunition
{
    public const double Weight = 1.4;
    public const double wearLevel = Weight * 100;

    public Gun(string name)
        : base(name, Weight,wearLevel)
    {
    }
}