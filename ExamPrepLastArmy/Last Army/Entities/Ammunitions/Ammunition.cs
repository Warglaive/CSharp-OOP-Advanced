public abstract class Ammunition
{
    public string Name { get; set; }
    public double Weight { get; set; }
    public Ammunition(string name, double weigth)
    {
        this.Name = name;
        this.Weight = weigth;
    }
}