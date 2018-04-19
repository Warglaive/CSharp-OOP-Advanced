using System.Collections.Generic;
using System.Linq;

public abstract class Soldier : ISoldier
{
    private ConsoleWriter writer;

    private double endurance;

    public string Name { get; }
    public int Age { get; }
    public double Experience { get; }
    public double Endurance { get; }
    //bug maybe
    public virtual double OverallSkill => this.Age + this.Experience;

    public IDictionary<string, IAmmunition> Weapons { get; }

    protected abstract IReadOnlyList<string> WeaponsAllowed { get; }

    protected Soldier()
    {
        // this.OverallSkill = this.Age + this.Experience;
        this.writer = new ConsoleWriter();
        //bug maybe
        foreach (var weapon in WeaponsAllowed)
        {
            if (this.Weapons[weapon] == null)
            {
                writer.AppendLine($"There is no weapon for {this.GetType().Name} {this.Name}!");
                break;
            }
            else
            {
                //add to army

            }
        }
    }

    public virtual void Regenerate()
    {

    }

    public bool ReadyForMission(IMission mission)
    {
        if (this.Endurance < mission.EnduranceRequired)
        {
            return false;
        }

        bool hasAllEquipment = this.Weapons
            .Values.Count(weapon => weapon == null) == 0;

        if (!hasAllEquipment)
        {
            return false;
        }

        return this.Weapons
            .Values.Count(weapon => weapon.WearLevel <= 0) == 0;
    }

    public void CompleteMission(IMission mission)
    {
        foreach (var weapon in this.Weapons.Values.Where(v => v != null))
        {
            weapon.DecreaseWearLevel(mission.WearLevelDecrement);
        }
    }

    public override string ToString() => string.Format(OutputMessages.SoldierToString, this.Name, this.OverallSkill);
}