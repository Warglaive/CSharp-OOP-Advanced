public abstract class Weapon
{
    public string Name { get; set; }
    public int MinDamage { get; set; }
    public int MaxDamage { get; set; }
    public int SocketsNumber { get; set; }

    protected Weapon(string name, int minDamage, int maxDamage, int socketsNumber)
    {
        this.Name = name;
        this.MinDamage = minDamage;
        this.MaxDamage = maxDamage;
        this.SocketsNumber = socketsNumber;
    }
}