using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private bool isRunning;
    private DraftManager draftManager;

    public Engine()
    {
        this.isRunning = true;
        this.draftManager = new DraftManager();
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
        string result = string.Empty;


        switch (command.ToLower())
        {
            case "registerharvester":
                result = draftManager.RegisterHarvester(commandParameters);
                this.OutputWriter(result);
                break;
            case "registerprovider":
                result = draftManager.RegisterProvider(commandParameters);
                this.OutputWriter(result);
                break;
            case "day":
                result = draftManager.Day();
                this.OutputWriter(result);
                break;
            case "mode":
                result = draftManager.Mode(commandParameters);
                this.OutputWriter(result);
                break;
            case "check":
                result = draftManager.Check(commandParameters);
                this.OutputWriter(result);
                break;
            case "shutdown":
                result = draftManager.ShutDown();
                this.OutputWriter(result);
                this.isRunning = false;
                break;
        }
    }

    private List<string> ParseInput(string inputCommand)
    {
        return inputCommand.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
    }

    private void OutputWriter(string line)
    {
        Console.WriteLine(line);
    }

    private string ReadInput()
    {
        return Console.ReadLine();
    }
}
