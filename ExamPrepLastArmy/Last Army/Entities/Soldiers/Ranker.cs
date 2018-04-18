using System.Collections.Generic;

public class Ranker : Soldier
{
    public List<string> weaponsAllowed = new List<string>
    {
        "Gun",
        "AutomaticMachine",
        "Helmet"
    };

    public Ranker(string name, int age, double experience, double endurance) : base(name, age, experience, endurance)
    {
    }

    public override double OverallSkillMultiplier { get; }
    public override List<string> WeasponsAllowed => this.weaponsAllowed;
}