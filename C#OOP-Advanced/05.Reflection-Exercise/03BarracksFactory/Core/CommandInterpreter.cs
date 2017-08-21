using System;
using System.Globalization;
using System.Linq;
using System.Reflection;
using _03BarracksFactory.Contracts;

namespace _03BarracksFactory.Core
{
    class CommandInterpreter : ICommandInterpreter
    {
        public const string CommandSuffix = "Command";

        private IUnitFactory unitFactory;
        private IRepository repository;

        public CommandInterpreter(IUnitFactory unitFactory, IRepository repository)
        {
            this.unitFactory = unitFactory;
            this.repository = repository;
        }

        public IExecutable InterpretCommand(string[] data, string commandName)
        {
            string command = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(commandName);
            string commandNameWithSuffix = command + CommandSuffix;

            Type executableClass = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .First(x => x.Name == commandNameWithSuffix);

            if (executableClass == null)
            {
                throw new ArgumentException("Invalid command!");
            }

            object[] parameters = { data };

            IExecutable currentCommand = (IExecutable)Activator.CreateInstance(executableClass, parameters);

            currentCommand = this.InjectDependacies(currentCommand);

            return currentCommand;
        }

        private IExecutable InjectDependacies(IExecutable currentCommand)
        {
            FieldInfo[] currentCommandFields = currentCommand
                .GetType()
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            FieldInfo[] commandInterpreterFields = this
                .GetType()
                .GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (FieldInfo commandField in currentCommandFields)
            {
                FieldInfo interpreterField = commandInterpreterFields
                    .First(f => f.FieldType == commandField.FieldType);

                commandField.SetValue(currentCommand, interpreterField.GetValue(this));
            }

            return currentCommand;
        }
    }
}
