public class RPG : Ammunition
{
    public const double Weight = 17.1;
    public const double wearLevel = Weight * 100;
    public RPG(string name)
        : base(name, Weight, wearLevel)
    {
    }
}