﻿public class Knife : Ammunition
{
    public const double Weight = 0.4;

    public Knife(string name)
        : base(name, Weight)
    {
    }

    public double WearLevel { get; }
    public void DecreaseWearLevel(double wearAmount)
    {
        //
    }
}