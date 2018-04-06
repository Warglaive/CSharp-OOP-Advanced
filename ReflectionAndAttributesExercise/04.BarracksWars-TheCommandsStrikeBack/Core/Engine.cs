using System;
using _03BarracksFactory.Contracts;

namespace P04_BarrackWarsTheCommandsStrikeBack.Core
{
    class Engine : IRunnable
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public Engine(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    string result = InterpredCommand(data, commandName);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        private string InterpredCommand(string[] data, string commandName)
        {
            var fixedcommand = commandName[0].ToString().ToUpper()
                               + commandName.Substring(1)
                               + "Command";

            var types = Type.GetType("P04_BarrackWarsTheCommandsStrikeBack.Core.Commands." + fixedcommand);
            var instance = (IExecutable)Activator.CreateInstance(types, data, repository, unitFactory);
            return instance.Execute();
        }
    }
}