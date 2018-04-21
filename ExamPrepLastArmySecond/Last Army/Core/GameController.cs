using System;
using System.Linq;
using System.Reflection;

public class GameController
{
    private IArmy Army;
    private IWareHouse wearHouse;
    private MissionController missionControllerField;
    private IWriter Writer;
    private int successfulMissionsCounter;
    private int failedMissionsCounter;

    //to add mission factory
    public ISoldierFactory SoldierFactory;
    public GameController(IWriter writer)
    {
        this.Army = new Army();
        this.wearHouse = new WareHouse();
        this.missionControllerField = new MissionController(this.Army, this.wearHouse);
        this.SoldierFactory = new SoldiersFactory();
        this.Writer = writer;
    }

    public void GiveInputToGameController(string input)
    {
        var data = input.Split();
        var command = data[0];
        if (command.Equals("Soldier"))
        {
            var type = data[1];
            var name = data[2];
            var age = int.Parse(data[3]);
            var experiance = double.Parse(data[4]);
            var endurance = double.Parse(data[5]);
            var soldier = this.SoldierFactory.CreateSoldier(type, name, age, experiance, endurance);

            if (!wearHouse.TryEquipSoldier(soldier))
            {
                this.Writer.AppendLine(string.Format(OutputMessages.SoldierCannonBeEquipped, soldier.GetType().Name, soldier.Name));
            }
            this.Army.AddSoldier(soldier);

        }
        else if (command.Equals("WareHouse"))
        {
            var ammunition = data[1];
            var count = int.Parse(data[2]);
            this.wearHouse.AddAmmunitions(ammunition, count);
        }
        else if (command.Equals("Mission"))
        {
            this.Writer.Clear();
            var missionType = data[1];
            var scoreToComplete = double.Parse(data[2]);

            var type = Assembly.GetCallingAssembly()
                .GetTypes().First(t => t.Name == missionType);

            var mission = (IMission)Activator.CreateInstance(type, scoreToComplete);
            var missionResult = this.missionControllerField.PerformMission(mission);

            Console.WriteLine(missionResult.Trim());
            this.missionControllerField.FailMissionsOnHold();

            //this.Writer.AppendLine("Results:");

            this.successfulMissionsCounter = this.missionControllerField.SuccessMissionCounter;
            this.failedMissionsCounter = this.missionControllerField.FailedMissionCounter;

        }
        this.Writer.AppendLine(string.Format(OutputMessages.SuccessfulMissionsCount, successfulMissionsCounter));
        this.Writer.AppendLine(string.Format(OutputMessages.FailedMissionsCount, failedMissionsCounter));
    }
}