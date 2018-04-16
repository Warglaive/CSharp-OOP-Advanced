public class MachineGun : Ammunition
{
    public const double Weight = 10.6;
    public const double wearLevel = Weight * 100;
    public MachineGun(string name)
        : base(name, Weight,wearLevel)
    {
    }
}