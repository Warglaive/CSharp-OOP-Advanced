using System;
using System.Linq;
using System.Reflection;

public class AmmunitionFactory : IAmmunitionFactory
{
    public IAmmunition CreateAmmunition(string ammunitionName)
    {
        var type = Assembly.GetCallingAssembly()
            .GetTypes().First(n => n.Name == ammunitionName);
        return (IAmmunition)Activator.CreateInstance(type);
    }
}