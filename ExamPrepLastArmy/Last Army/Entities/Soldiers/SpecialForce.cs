﻿using System.Collections.Generic;

public class SpecialForce : Soldier
{
    private const double OverallSkillMiltiplier = 3.5;
    //private readonly List<string> weaponsAllowed = new List<string>
    //    {
    //        "Gun",
    //        "AutomaticMachine",
    //        "MachineGun",
    //        "RPG",
    //        "Helmet",
    //        "Knife",
    //        "NightVision"
    //    };

    public SpecialForce(string name, int age
        , double experience, double endurance, double overallSkill)
        : base(name, age, experience, endurance, overallSkill)
    {
    }

    protected override IReadOnlyList<string> WeaponsAllowed { get; }
}