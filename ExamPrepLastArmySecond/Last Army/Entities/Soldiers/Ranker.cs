using System.Collections.Generic;

public class Ranker : Soldier
{
    private const double OverallSkillMiltiplier = 1.5;
    public List<string> weapons = new List<string>
    {
        "Gun",
        "AutomaticMachine",
        "Helmet"
    };

    public override double OverallSkill => OverallSkillMiltiplier;
    protected override IReadOnlyList<string> WeaponsAllowed => this.weapons;
}