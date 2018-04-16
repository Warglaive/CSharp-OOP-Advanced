using System.Collections.Generic;

public class Corporal : Soldier
{
    public Corporal(string name, int age, double experience
        , double endurance, double overallSkill)
    : base(name, age, experience, endurance, overallSkill)
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

    protected override IReadOnlyList<string> WeaponsAllowed => this.weaponsAllowed;
}