using System.Collections.Generic;
using System.Linq;

public class WareHouse : IWareHouse
{
    public Dictionary<string, int> ammunitionsQuantities;
    public AmmunitionFactory AmmunitionFactory;
    public WareHouse()
    {
        this.ammunitionsQuantities = new Dictionary<string, int>();
        this.AmmunitionFactory = new AmmunitionFactory();
    }
    public void EquipArmy(IArmy army)
    {
        foreach (var soldier in army.Soldiers)
        {
            this.TryEquipSoldier(soldier);
        }
    }

    public bool TryEquipSoldier(ISoldier soldier)
    {
        bool isEquipped = true;

        var missingWeapons = soldier
            .Weapons.Where(v => v.Value == null)
            .Select(k => k.Key)
            .ToList();

        foreach (var missingWeaponName in missingWeapons)
        {
            if (this.ammunitionsQuantities.ContainsKey(missingWeaponName)
                && this.ammunitionsQuantities[missingWeaponName] > 0)
            {
                soldier.Weapons[missingWeaponName] = this.AmmunitionFactory.CreateAmmunition(missingWeaponName);
                this.ammunitionsQuantities[missingWeaponName]--;
            }
        }

        return isEquipped;
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