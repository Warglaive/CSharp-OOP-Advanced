using System;
using System.Linq;
using System.Reflection;

public class SoldierFactory : ISoldierFactory
{
    public ISoldier CreateSoldier(string soldierTypeName, string name, int age, double experience, double endurance)
    {
        var type = Assembly
            .GetCallingAssembly()
            .GetTypes()
            .Single(s => s.Name == soldierTypeName);

        //calling ctor with specified arguments
        var instancedClass = (ISoldier)Activator
            .CreateInstance(type, name, age, experience, endurance);

        return instancedClass;
    }
}