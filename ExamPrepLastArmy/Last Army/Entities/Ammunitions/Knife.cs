﻿public class Knife : Ammunition
{
    public const double Weight = 0.4;
    public const double wearLevel = Weight * 100;
    public Knife(string name)
        : base(name, Weight,wearLevel)
    {
    }
}