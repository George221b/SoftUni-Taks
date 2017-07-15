using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private bool isRunning;
    private NationsBuilder nationsBuilder;

    public Engine()
    {
        this.isRunning = true;
        this.nationsBuilder = new NationsBuilder();
    }

    public void Run()
    {
        while (this.isRunning)
        {
            string inputCommand = this.ReadInput();
            List<string> commandParameters = this.ParseInput(inputCommand);
            this.DistributeCommand(commandParameters);
        }
    }

    private void DistributeCommand(List<string> commandParameters)
    {
        var command = commandParameters[0];
        commandParameters.Remove(command);

        switch (command.ToLower())
        {
            case "bender":
                this.nationsBuilder.AssignBender(commandParameters);
                break;
            case "monument":
                this.nationsBuilder.AssignMonument(commandParameters);
                break;
            case "status":
                string status = this.nationsBuilder.GetStatus(commandParameters[0]);
                this.OutputWriter(status);
                break;
            case "war":
                this.nationsBuilder.IssueWar(commandParameters[0]);
                break;
            case "quit":
                string record = this.nationsBuilder.GetWarsRecord();
                this.OutputWriter(record);
                this.isRunning = false;
                break;
        }
    }

    private void OutputWriter(string line)
    {
        Console.WriteLine(line);
    }

    private List<string> ParseInput(string inputCommand)
    {
        return inputCommand.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
    }

    private string ReadInput()
    {
        return Console.ReadLine();
    }
}
