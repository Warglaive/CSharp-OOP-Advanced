using System.Collections.Generic;

public class SpecialForce : Soldier
{
    public const double overallSkillMultiplier = 3.5;
    public override double OverallSkillMultiplier => overallSkillMultiplier;
    private const int regenerateIncrease = 30;

    private readonly List<string> weaponsAllowed = new List<string>
    {
        "Gun",
        "AutomaticMachine",
        "MachineGun",
        "RPG",
        "Helmet",
        "Knife",
        "NightVision"
    };

    public override List<string> WeasponsAllowed => this.weaponsAllowed;

    protected override int RegenerateIncrease => regenerateIncrease;

    public SpecialForce(string name, int age, double experience, double endurance)
        : base(name, age, experience, endurance)
    {
    }
}