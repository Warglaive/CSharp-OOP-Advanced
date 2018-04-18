using System;
using System.Linq;

public class GameController
{
    private IArmy army;
    private IWareHouse wareHouse;
    private MissionController missionController;
    private ISoldierFactory soldierFactory;
    private IMissionFactory missionFactory;
    private IWriter writer;

    public GameController(IWriter writer)
    {
        this.army = new Army();
        this.wareHouse = new WareHouse();
        this.missionController = new MissionController(army, wareHouse);
        this.soldierFactory = new SoldierFactory();
        this.missionFactory = new MissionFactory();
        this.writer = writer;
    }

    public void GiveInputToGameController(string input)
    {
        var data = input.Split();

        if (data[0].Equals("Soldier"))
        {
            if (data[1] == "Regenerate")
            {
                army.RegenerateTeam(data[2]);
            }
            else
            {
                var type = data[1];
                var name = data[2];
                var age = int.Parse(data[3]);
                var experience = double.Parse(data[4]);
                var endurance = double.Parse(data[5]);

                var soldier = this.soldierFactory.CreateSoldier(type, name, age, experience, endurance);
                if (this.wareHouse.TryEquipSoldier(soldier))
                {
                    this.army.AddSoldier(soldier);
                }
                else
                {
                    throw new ArgumentException(
                        string.Format(OutputMessages.SoldierCannonBeEquipped, type, name));
                }
            }
        }
        else if (data[0].Equals("WareHouse"))
        {
            string name = data[1];
            int number = int.Parse(data[2]);

            this.wareHouse.AddAmmunition(name, number);
        }
        else if (data[0].Equals("Mission"))
        {
            var difficultyLevel = data[1];
            var neededPoints = double.Parse(data[2]);

            var mission = this.missionFactory.CreateMission(difficultyLevel, neededPoints);
            writer.AppendLine(this.missionController.PerformMission(mission));
        }
    }

    public void RequestResult()
    {
        missionController.FailMissionsOnHold();
        this.writer.AppendLine(OutputMessages.Results);
        this.writer.AppendLine(string.Format(OutputMessages.SuccesfullMissionsCount, missionController.SuccessMissionCounter));
        this.writer.AppendLine(string.Format(OutputMessages.FailedMissionsCount, missionController.FailedMissionCounter));
        this.writer.AppendLine(OutputMessages.Soldiers);
        foreach (var soldier in this.army.Soldiers.OrderByDescending(s => s.OverallSkill))
        {
            writer.AppendLine(soldier.ToString());
        }
    }
}