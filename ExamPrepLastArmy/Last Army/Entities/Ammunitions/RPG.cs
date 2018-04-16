public class RPG : Ammunition, IAmmunition
{
    public const double Weight = 17.1;

    public RPG(string name)
        : base(name, Weight)
    {
    }

    public double WearLevel { get; }
    public void DecreaseWearLevel(double wearAmount)
    {
        //
    }
}