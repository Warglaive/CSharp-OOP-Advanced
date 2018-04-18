public abstract class Ammunition : IAmmunition
{
    public const int WearLevelMultiplier = 100;
    //this on abstract class gets members that inherit it
    public string Name => this.GetType().Name;

    public abstract double Weight { get; }

    public double WearLevel { get; private set; }

    public Ammunition()
    {
        this.WearLevel = this.Weight * WearLevelMultiplier;
    }

    public void DecreaseWearLevel(double wearAmount)
    {
        this.WearLevel -= wearAmount;
    }
}