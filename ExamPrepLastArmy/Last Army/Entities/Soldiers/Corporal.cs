using System.Collections.Generic;

public class Corporal : Soldier
{
    public const double overallSkillMultiplier = 2.5;
    public Corporal(string name, int age, double experience
        , double endurance)
    : base(name, age, experience, endurance)
    {
    }

    public readonly List<string> weaponsAllowed = new List<string>
    {
        "Gun",
        "AutomaticMachine",
        "MachineGun",
        "Helmet",
        "Knife"
    };

    public override double OverallSkillMultiplier => overallSkillMultiplier;
    public override List<string> WeasponsAllowed => this.weaponsAllowed;
}