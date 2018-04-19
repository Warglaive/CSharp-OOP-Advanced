using System.Collections.Generic;

public class Corporal : Soldier
{
    private const double OverallSkillMiltiplier = 2.5;
    public List<string> weapons = new List<string>
    {
        "Gun",
        "AutomaticMachine",
        "MachineGun",
        "Helmet",
        "Knife"
    };

    public override double OverallSkill => OverallSkillMiltiplier;
    protected override IReadOnlyList<string> WeaponsAllowed => this.weapons;
}