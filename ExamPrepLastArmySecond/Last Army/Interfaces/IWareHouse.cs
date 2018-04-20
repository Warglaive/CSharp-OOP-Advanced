public interface IWareHouse
{
    void EquipArmy(IArmy army);
    void AddAmmunitions(string ammunitions, int count);
    bool TryEquipSoldier(ISoldier soldier);
}