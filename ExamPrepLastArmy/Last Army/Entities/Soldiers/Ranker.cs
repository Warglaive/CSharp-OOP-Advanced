using System.Collections.Generic;

public class Ranker : Soldier
{
    public Ranker(string name, int age, double experience
        , double endurance, double overallSkill)
        : base(name, age, experience, endurance, overallSkill)
    {
    }

    private readonly List<string> weaponsAllowed = new List<string>
    {
        "Gun",
        "AutomaticMachine",
        "Helmet"
    };
    protected override IReadOnlyList<string> WeaponsAllowed => this.weaponsAllowed;
}