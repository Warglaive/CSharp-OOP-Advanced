public class GameController
{
    private IArmy army;
    private IWareHouse wearHouse;
    private MissionController missionController;
    private ISoldierFactory soldierFactory;
    private IMissionFactory missionFactory;

    public GameController(IArmy army)
    {
        this.army = new Army();
        this.wearHouse = new WareHouse();
        this.missionController = new MissionController(army, wearHouse);
        this.soldierFactory = new SoldierFactory();
        this.missionFactory = new MissionFactory();
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
                var type = data[0];
                var name = data[1];
                var age = int.Parse(data[2]);
                var experience = double.Parse(data[3]);
                var endurance = double.Parse(data[4]);

                var soldier = this.soldierFactory.CreateSoldier(type, name, age, experience, endurance);
                this.army.AddSoldier(soldier);
            }
        }
        else if (data[0].Equals("WearHouse"))
        {
            string name = data[1];
            int number = int.Parse(data[2]);

            this.wearHouse.AddAmmunition(name, number);
        }
        else if (data[0].Equals("Mission"))
        {
            var difficultyLevel = data[1];
            var neededPoints = double.Parse(data[2]);

            var mission = this.missionFactory.CreateMission(difficultyLevel, neededPoints);
            this.missionController.PerformMission(mission);
        }
    }
}