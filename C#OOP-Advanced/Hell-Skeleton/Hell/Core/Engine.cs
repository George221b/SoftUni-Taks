using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class Engine
{
    private IInputReader reader;
    private IOutputWriter writer;
    private IManager heroManager;

    public Engine(IInputReader reader, IOutputWriter writer, IManager heroManager)
    {
        this.reader = reader;
        this.writer = writer;
        this.heroManager = heroManager;
    }

    public void Run()
    {
        bool isRunning = true;

        while (isRunning)
        {
            try
            {
                string inputLine = this.reader.ReadLine();
                List<string> arguments = this.parseInput(inputLine);
                if (arguments[0].Equals("Quit"))
                {
                    isRunning = false;
                }
                this.writer.WriteLine(this.processInput(arguments));
                isRunning = !this.ShouldEnd(inputLine);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    private List<string> parseInput(string input)
    {
        return input.Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
    }

    private string processInput(List<string> arguments)
    {
        string command = arguments[0];
        arguments.RemoveAt(0);
        string fullCommandName = $"{command}Command";

        Type commandClass = Assembly.GetExecutingAssembly()
            .GetTypes()
            .FirstOrDefault(x => x.Name.Equals(fullCommandName));

        if (commandClass == null)
        {
            throw new ArgumentNullException($"There is no command for {command}");
        }

        ConstructorInfo commandConstructor = commandClass.GetConstructors().First();
        ParameterInfo[] commandParameters = commandConstructor.GetParameters();

        List<object> parsedParams = new List<object>();
        List<string> parsedParamsONLYforRecipe = new List<string>();

        for (int i = 0; i < commandParameters.Length; i++)
        {
            if (commandParameters[i].ParameterType.IsArray)
            {
                for (int j = i; j < arguments.Count; j++)
                {
                    parsedParamsONLYforRecipe.Add(arguments[j]);
                }
                continue;
            }
            parsedParams.Add(Convert.ChangeType(arguments[i], commandParameters[i].ParameterType));
        }

        if (parsedParamsONLYforRecipe.Count != 0)
        {
            parsedParams.Add(parsedParamsONLYforRecipe.ToArray());
        }

        AbstractCommand abstractCommand = (AbstractCommand)commandConstructor.Invoke(parsedParams.ToArray());

        InjectManagerInCommand(abstractCommand);

        return abstractCommand.Execute();
    }

    private void InjectManagerInCommand(AbstractCommand abstractCommand)
    {
        foreach (FieldInfo field in abstractCommand.GetType().GetFields(BindingFlags.Instance | BindingFlags.NonPublic))
        {
            if (field.GetCustomAttributes<InjectAttribute>().Any())
            {
                field.SetValue(abstractCommand, this.heroManager);
            }
        }
    }

    private bool ShouldEnd(string inputLine)
    {
        return inputLine.Equals("Quit");
    }
}