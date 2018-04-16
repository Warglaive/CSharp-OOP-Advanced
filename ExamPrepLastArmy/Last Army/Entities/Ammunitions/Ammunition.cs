public abstract class Ammunition : IAmmunition
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public double WearLevel { get; }

    public void DecreaseWearLevel(double wearAmount)
    {
        throw new System.NotImplementedException();
    }

    public Ammunition(string name, double weigth, double wearLevel)
    {
        this.Name = name;
        this.Weight = weigth;
        this.WearLevel = wearLevel;
    }
}