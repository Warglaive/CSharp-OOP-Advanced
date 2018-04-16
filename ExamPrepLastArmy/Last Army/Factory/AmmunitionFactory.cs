using System;

public class AmmunitionFactory
{
    public AmmunitionFactory()
    {
    }

    public static IAmmunition CreateAmmunition(string name)
    {
        //reflection
        var type = Type.GetType(name);
        var classInstance = (IAmmunition)Activator.CreateInstance(type);
        return classInstance;

    }

    public static Ammunition CreateAmmunitions(string name, int number)
    {
        var type = Type.GetType(name);
        var classInstance = (Ammunition)Activator.CreateInstance(type);
        return classInstance;
        //fix number
    }
}