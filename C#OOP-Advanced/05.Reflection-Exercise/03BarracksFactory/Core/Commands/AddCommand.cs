using _03BarracksFactory.Attributes;
using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    public class AddCommand : Command
    {
        [Inject]
        private IRepository repository;
        [Inject]
        private IUnitFactory unitFactory;

        public AddCommand(string[] data): base(data)
        {
        }

        public override string Execute()
        {
            var unitType = this.Data[1];
            var unitToAdd = this.unitFactory.CreateUnit(unitType);
            this.repository.AddUnit(unitToAdd);
            var output = unitType + " added!";
            return output;
        }
    }
}
