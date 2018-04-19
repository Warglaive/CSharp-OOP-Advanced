using System;
using System.Collections.Generic;
public class GameController
{
    private IArmy Army;
    private IWareHouse wearHouse;
    private MissionController missionControllerField;

    public GameController()
    {
        this.Army = new Army();
        this.wearHouse = new WareHouse();
        this.missionControllerField = new MissionController(this.Army, this.wearHouse);
    }

    public void GiveInputToGameController(string input)
    {
        var data = input.Split();
        var command = data[0];
        if (command.Equals("Soldier"))
        {

        }
        else if (command.Equals("WearHouse"))
        {
            var name = data[1];
            var number = int.Parse(data[2]);

          //  AddAmmunitions(AmmunitionFactory.CreateAmmunitions(name, number));
        }
        else if (command.Equals("Mission"))
        {
            this.missionControllerField.PerformMission(new Easy());
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