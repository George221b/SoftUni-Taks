namespace _03BarracksFactory.Core.Factories
{
    using System;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public const string UnitsNameSpace = "_03BarracksFactory.Models.Units.";

        public IUnit CreateUnit(string unitType)
        {
            Type typeUnit = Type.GetType(UnitsNameSpace + unitType);
            IUnit unitInstance = (IUnit)Activator.CreateInstance(typeUnit);
            return unitInstance;
        }
    }
}
