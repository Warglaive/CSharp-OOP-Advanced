using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Soldier : ISoldier
{
    private const int MaxEndurance = 100;
    private const int BaseRegeneraIncrease = 10;

    public string Name { get; }
    public int Age { get; }
    public double Experience { get; private set; }

    private double endurance;

    public double Endurance
    {
        get { return endurance; }
        set
        {
            endurance = Math.Min(value, MaxEndurance);
        }
    }

    public abstract double OverallSkillMultiplier { get; }

    public double OverallSkill => (this.Age + this.Experience)
        * OverallSkillMultiplier;

    public abstract List<string> WeasponsAllowed { get; }

    public IDictionary<string, IAmmunition> Weapons { get; }

    protected virtual int RegenerateIncrease => BaseRegeneraIncrease;

    protected Soldier(string name, int age, double experience, double endurance)
    {
        this.Name = name;
        this.Age = age;
        this.Experience = experience;
        this.Endurance = endurance;

        this.Weapons = new Dictionary<string, IAmmunition>();

        foreach (var ammunition in this.WeasponsAllowed)
        {
            this.Weapons.Add(ammunition, null);
        }
    }


    public bool ReadyForMission(IMission mission)
    {
        if (this.Endurance < mission.EnduranceRequired)
        {
            return false;
        }

        bool hasAllEquipment = this.Weapons.Values.Count(weapon => weapon == null) == 0;

        if (!hasAllEquipment)
        {
            return false;
        }
        return this.Weapons.Values.All(weapon => weapon.WearLevel > 0);

    }

    public void CompleteMission(IMission mission)
    {
        this.Experience += mission.EnduranceRequired;
        this.Endurance -= mission.EnduranceRequired;
        foreach (var weapon in this.Weapons.Values.Where(w => w != null))
        {
            weapon.DecreaseWearLevel(mission.WearLevelDecrement);
            if (weapon.WearLevel <= 0)
            {
                this.Weapons[weapon.Name] = null;
            }
        }
    }

    public void Regenerate()
    {
        this.Endurance += this.Age + this.RegenerateIncrease;
    }

    public override string ToString() => string.Format(OutputMessages.SoldierToString, this.Name, this.OverallSkill);
}