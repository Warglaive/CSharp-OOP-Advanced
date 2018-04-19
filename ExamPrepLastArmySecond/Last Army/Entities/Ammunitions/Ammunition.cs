public abstract class Ammunition : IAmmunition
{
    private const int WeightMultiplier = 100;

    public string Name { get; }
    public double Weight { get; }
    public double WearLevel { get; private set; }

    protected Ammunition(string name, double weight)
    {
        this.Name = name;
        this.Weight = weight;
        this.WearLevel = this.Weight * WeightMultiplier;
    }

    public void DecreaseWearLevel(double wearAmount)
    {
        this.WearLevel -= wearAmount;
    }
}