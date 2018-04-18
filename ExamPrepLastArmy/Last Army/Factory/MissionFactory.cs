using System;
using System.Linq;
using System.Reflection;

public class MissionFactory : IMissionFactory
{
    public IMission CreateMission(string difficultyLevel, double neededPoints)
    {
        var type = Assembly.GetCallingAssembly()
            .GetTypes()
            .Single(m => m.Name == difficultyLevel);

        var mission = (IMission)Activator.CreateInstance(type, neededPoints);

        return mission;
    }
}