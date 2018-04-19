using System.Collections.Generic;

public class Ranker : Soldier
{
    public List<string> weapons = new List<string>
    {
        "Gun",
        "AutomaticMachine",
        "Helmet"
    };

    public override double OverallSkillMultiplier => 1.5;
    public override double OverallSkill => base.OverallSkill * OverallSkillMultiplier;
    protected override IReadOnlyList<string> WeaponsAllowed => this.weapons;

    public Ranker(string name, int age, double experience, double endurance)
        : base(name, age, experience, endurance)
    {
    }
}