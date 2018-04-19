using System.Collections.Generic;
public class SpecialForce : Soldier
{
    private const double OverallSkillMiltiplier = 3.5;
    private readonly List<string> weapons = new List<string>
        {
            "Gun",
            "AutomaticMachine",
            "MachineGun",
            "RPG",
            "Helmet",
            "Knife",
            "NightVision"
        };

    public override double OverallSkill => OverallSkillMiltiplier;
    protected override IReadOnlyList<string> WeaponsAllowed => this.weapons;
}