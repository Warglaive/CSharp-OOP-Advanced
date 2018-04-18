using System;
using System.Linq;
using System.Reflection;

public class AmmunitionFactory : IAmmunitionFactory
{
    IAmmunition IAmmunitionFactory.CreateAmmunition(string ammunitionName)
    {
        //reflection
        var type = Assembly
            .GetCallingAssembly()
            .GetTypes()
            .Single(t => t.Name == ammunitionName);

        var classInstance = (IAmmunition)Activator.CreateInstance(type);
        return classInstance;
    }
}