public class MachineGun : Ammunition, IAmmunition
{
    public const double Weight = 10.6;

    public MachineGun(string name)
        : base(name, Weight)
    {
    }

    public double WearLevel { get; }
    public void DecreaseWearLevel(double wearAmount)
    {
        //
    }
}