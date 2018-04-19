using System.Collections.Generic;
public class SpecialForce : Soldier
{
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

    public override double OverallSkillMultiplier => 3.5;
    public override double OverallSkill => base.OverallSkill * OverallSkillMultiplier;
    protected override IReadOnlyList<string> WeaponsAllowed => this.weapons;

    public SpecialForce(string name, int age, double experience, double endurance)
        : base(name, age, experience, endurance)
    {
    }
}