using System;
using _03BarracksFactory.Attributes;
using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core.Commands
{
    public class RetireCommand : Command
    {
        [Inject]
        private IRepository repository;

        public RetireCommand(string[] data) : base(data)
        {
        }

        public override string Execute()
        {
            var unitType = this.Data[1];

            try
            {
                this.repository.RemoveUnit(unitType);
                return String.Format($"{unitType} retired!");
            }
            catch (ArgumentException arg)
            {
                return arg.Message;
            }
        }
    }
}
