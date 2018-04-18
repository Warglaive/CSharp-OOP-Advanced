public class Gun : Ammunition
{
    private const double WeigthMultiplier = 1.4;
    public override double Weight => WeigthMultiplier;
}