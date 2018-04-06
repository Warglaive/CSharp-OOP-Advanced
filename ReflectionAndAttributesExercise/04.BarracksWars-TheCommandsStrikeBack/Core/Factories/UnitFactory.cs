using System.Reflection;
using _03BarracksFactory.Models.Units;

namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            var classInstance = Type.GetType($"_03BarracksFactory.Models.Units.{unitType}");
            var instancedClass = Activator.CreateInstance(classInstance);
            return (IUnit)instancedClass;
        }
    }
}
