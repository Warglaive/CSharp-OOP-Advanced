using P04_BarrackWarsTheCommandsStrikeBack.Core;
using P04_BarrackWarsTheCommandsStrikeBack.Data;
using _03BarracksFactory.Contracts;
using _03BarracksFactory.Core.Factories;

namespace P04_BarrackWarsTheCommandsStrikeBack
{
    class AppEntryPoint
    {
        static void Main()
        {
            IRepository repository = new UnitRepository();
            IUnitFactory unitFactory = new UnitFactory();
            IRunnable engine = new Engine(repository, unitFactory);
            engine.Run();
        }
    }
}
