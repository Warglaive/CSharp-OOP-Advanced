using System.Collections.Generic;

public class Corporal : Soldier
{
    public List<string> weapons = new List<string>
    {
        "Gun",
        "AutomaticMachine",
        "MachineGun",
        "Helmet",
        "Knife"
    };

    public override double OverallSkillMultiplier => 2.5;
    public override double OverallSkill => base.OverallSkill * OverallSkillMultiplier;
    protected override IReadOnlyList<string> WeaponsAllowed => this.weapons;

    public Corporal(string name, int age, double experience, double endurance)
        : base(name, age, experience, endurance)
    {
    }
}