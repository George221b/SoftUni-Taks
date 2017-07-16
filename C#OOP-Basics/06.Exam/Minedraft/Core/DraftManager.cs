using System;
using System.Collections.Generic;
using System.Text;

public class DraftManager
{
    private Dictionary<string, Harvester> harvesters;
    private Dictionary<string, Provider> providers;
    private string dayMode;

    private double totalEnergyStored;
    private double totalMinedOre;

    public DraftManager()
    {
        this.harvesters = new Dictionary<string, Harvester>();
        this.providers = new Dictionary<string, Provider>();
        this.dayMode = "Full";
    }

    public string RegisterHarvester(List<string> arguments)
    {
        string type = arguments[0];

        try
        {
            Harvester currentHarvester = HarvesterFactory.GetHarvester(arguments);
            this.harvesters.Add(currentHarvester.Id, currentHarvester);

            if (type == "Sonic")
            {
                return $"Successfully registered Sonic Harvester - {currentHarvester.Id}";
            }

            return $"Successfully registered Hammer Harvester - {currentHarvester.Id}";
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }

    //private Harvester GetHarvester(List<string> arguments)
    //{
    //    string type = arguments[0];
    //    string id = arguments[1];
    //    double oreOutput = double.Parse(arguments[2]);
    //    double energyRequirment = double.Parse(arguments[3]);

    //    switch (type)
    //    {
    //        case "Hammer":
    //            return new HammerHarvester(id, oreOutput, energyRequirment);
    //            break;
    //        case "Sonic":
    //            return new SonicHarvester(id, oreOutput, energyRequirment, int.Parse(arguments[4]));
    //            break;
    //        default:
    //            throw new ArgumentException("Harvester failed to be created.");
    //            break;
    //    }
    //}

    public string RegisterProvider(List<string> arguments)
    {
        string type = arguments[0];

        try
        {
            Provider currentProvider = ProviderFactory.GetProvider(arguments);
            this.providers.Add(currentProvider.Id, currentProvider);

            if (type == "Solar")
            {
                return $"Successfully registered Solar Provider - {currentProvider.Id}";
            }

            return $"Successfully registered Pressure Provider - {currentProvider.Id}";
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }

    //private Provider GetProvider(List<string> arguments)
    //{
    //    var type = arguments[0];
    //    var id = arguments[1];
    //    var energy = double.Parse(arguments[2]);

    //    switch (type)
    //    {
    //        case "Solar":
    //            return new SolarProvider(id, energy);
    //            break;
    //        case "Pressure":
    //            return new PressureProvider(id, energy);
    //            break;
    //        default:
    //            throw new ArgumentException("Provider failed to be created.");
    //            break;
    //    }
    //}

    public string Day()
    {
        string result = string.Empty;

        switch (this.dayMode)
        {
            case "Full":
                result = this.FullDayWork();
                break;
            case "Half":
                result = this.HalfDayWork();
                break;
            case "Energy":
                result = this.EnergyDayWork();
                break;
        }
        return result;
    }

    private string HalfDayWork()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"A day has passed.");

        double providersDailyEnergyProduce = this.GetProvidersEnergy();
        this.totalEnergyStored += providersDailyEnergyProduce;
        sb.AppendLine($"Energy Provided: {providersDailyEnergyProduce}");

        double harvestersDailyEnergyConsume = 0;
        double harvesterDailyOreOutput = 0;
        foreach (var harvester in this.harvesters)
        {
            harvestersDailyEnergyConsume += harvester.Value.EnergyRequirement;
            harvesterDailyOreOutput += harvester.Value.OreOutput;
        }

        harvestersDailyEnergyConsume *= 0.6;
        harvesterDailyOreOutput *= 0.5;

        if (this.totalEnergyStored >= harvestersDailyEnergyConsume)
        {
            this.totalEnergyStored = this.totalEnergyStored - harvestersDailyEnergyConsume;
            this.totalMinedOre += harvesterDailyOreOutput;
            sb.Append($"Plumbus Ore Mined: {harvesterDailyOreOutput}");
        }
        else
        {
            sb.Append($"Plumbus Ore Mined: 0");
        }

        return sb.ToString();
    }

    private string EnergyDayWork()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"A day has passed.");

        double providersDailyEnergyProduce = this.GetProvidersEnergy();
        this.totalEnergyStored += providersDailyEnergyProduce;
        sb.AppendLine($"Energy Provided: {providersDailyEnergyProduce}");
        sb.Append($"Plumbus Ore Mined: 0");

        return sb.ToString();
    }

    private string FullDayWork()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"A day has passed.");

        double providersDailyEnergyProduce = this.GetProvidersEnergy();
        this.totalEnergyStored += providersDailyEnergyProduce;
        sb.AppendLine($"Energy Provided: {providersDailyEnergyProduce}");

        double harvestersDailyEnergyConsume = 0;
        double harvesterDailyOreOutput = 0;
        foreach (var harvester in this.harvesters)
        {
            harvestersDailyEnergyConsume += harvester.Value.EnergyRequirement;
            harvesterDailyOreOutput += harvester.Value.OreOutput;
        }

        if (this.totalEnergyStored >= harvestersDailyEnergyConsume)
        {
            this.totalEnergyStored = this.totalEnergyStored - harvestersDailyEnergyConsume;
            this.totalMinedOre += harvesterDailyOreOutput;
            sb.Append($"Plumbus Ore Mined: {harvesterDailyOreOutput}");
        }
        else
        {
            sb.Append($"Plumbus Ore Mined: 0");
        }

        return sb.ToString();
    }

    private double GetProvidersEnergy()
    {
        double result = 0;

        foreach (var provider in this.providers)
        {
            result += provider.Value.EnergyOutput;
        }

        return result;
    }

    public string Mode(List<string> arguments)
    {
        var currentDay = arguments[0];
        if (currentDay == "Full")
        {
            this.dayMode = "Full";
            return $"Successfully changed working mode to Full Mode";
        }
        else if (currentDay == "Half")
        {
            this.dayMode = "Half";
            return $"Successfully changed working mode to Half Mode";
        }

        this.dayMode = "Energy";
        return $"Successfully changed working mode to Energy Mode";
    }

    public string Check(List<string> arguments)
    {
        string idToCheck = arguments[0];

        if (this.harvesters.ContainsKey(idToCheck))
        {
            return this.harvesters[idToCheck].ToString();
        }
        else if (this.providers.ContainsKey(idToCheck))
        {
            return this.providers[idToCheck].ToString();
        }

        return $"No element found with id - {idToCheck}";
    }

    public string ShutDown()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"System Shutdown");
        sb.AppendLine($"Total Energy Stored: {this.totalEnergyStored}");
        sb.Append($"Total Mined Plumbus Ore: {this.totalMinedOre}");
        return sb.ToString();
    }
}
