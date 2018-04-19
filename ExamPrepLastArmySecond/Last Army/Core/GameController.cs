using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class GameController
{
    private IArmy Army;
    private IWareHouse wearHouse;
    private MissionController missionControllerField;
    //to add mission factory
    public ISoldierFactory SoldierFactory;
    public GameController()
    {
        this.Army = new Army();
        this.wearHouse = new WareHouse();
        this.missionControllerField = new MissionController(this.Army, this.wearHouse);
        this.SoldierFactory = new SoldiersFactory();
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
            var missionType = data[1];
            var scoreToComplete = int.Parse(data[2]);
            var type = Assembly.GetCallingAssembly()
                .GetTypes().First(t => t.Name == missionType);
            var mission = (IMission)Activator.CreateInstance(type, scoreToComplete);
            this.missionControllerField.PerformMission(mission);
        }
    }

    //private void AddAmmunitions(Ammunition ammunition)
    //{
    //    if (!this.WearHouse.ContainsKey(ammunition.Name))
    //    {
    //        this.WearHouse[ammunition.Name] = new List<Ammunition>();
    //        this.WearHouse[ammunition.Name].Add(ammunition);
    //    }
    //    else
    //    {
    //        this.WearHouse[ammunition.Name][0].Number += ammunition.Number;
    //    }
    //}
}