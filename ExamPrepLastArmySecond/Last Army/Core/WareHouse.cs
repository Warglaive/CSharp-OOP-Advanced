using System.Collections.Generic;

public class WareHouse : IWareHouse
{
    public Dictionary<string, int> ammunitionsQuantities;

    public WareHouse()
    {
        this.ammunitionsQuantities = new Dictionary<string, int>();
    }
    public void EquipArmy(IArmy army)
    {
        foreach (var soldier in army.Soldiers)
        {
        }
    }

    public void AddAmmunitions(string ammunition, int count)
    {
        if (!this.ammunitionsQuantities.ContainsKey(ammunition))
        {
            this.ammunitionsQuantities.Add(ammunition, 0);
        }
        this.ammunitionsQuantities[ammunition] += count;
    }
}