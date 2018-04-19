using System.Collections.Generic;
public class Army : IArmy
{
    private List<ISoldier> soldiersList;
    public IReadOnlyList<ISoldier> Soldiers => soldiersList;

    public Army()
    {
        this.soldiersList = new List<ISoldier>();
    }
    public void AddSoldier(ISoldier soldier)
    {
        soldiersList.Add(soldier);
    }

    public void RegenerateTeam(string soldierType)
    {
        throw new System.NotImplementedException();
    }
}