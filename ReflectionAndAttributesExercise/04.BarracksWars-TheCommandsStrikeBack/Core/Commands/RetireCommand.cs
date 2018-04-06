using _03BarracksFactory.Contracts;

namespace P04_BarrackWarsTheCommandsStrikeBack.Core.Commands
{
    public class RetireCommand : Command
    {
        public RetireCommand(string[] data, IRepository repository, IUnitFactory unitFactory)
            : base(data, repository, unitFactory)
        {
        }

        public override string Execute()
        {
            string unitToRetire = Data[1];
            this.Repository.RemoveUnit(unitToRetire);
            string output = unitToRetire + " retired!";
            return output;
        }
    }
}
