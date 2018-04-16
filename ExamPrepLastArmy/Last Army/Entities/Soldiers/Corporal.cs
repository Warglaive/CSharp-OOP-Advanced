using System.Collections.Generic;

public class Corporal : Soldier
{
    public Corporal(string name, int age, double experience
        , double endurance, double overallSkill)
    : base(name, age, experience, endurance, overallSkill)
    {
    }

    protected override IReadOnlyList<string> WeaponsAllowed { get; }
}