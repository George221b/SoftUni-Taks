using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    private Dictionary<string, Nation> nations;
    private List<string> warHistoryRecord;

    public NationsBuilder()
    {
        this.nations = new Dictionary<string, Nation>()
        {
            {"Air", new Nation()},
            {"Fire", new Nation()},
            {"Earth", new Nation()},
            {"Water", new Nation()}
        };

        this.warHistoryRecord = new List<string>();
    }

    public void AssignBender(List<string> benderArgs) // Command 1
    {
        var benderType = benderArgs[0];

        Bender currentBender = this.GetBender(benderArgs);
        this.nations[benderType].AddBender(currentBender);
    }

    private Bender GetBender(List<string> benderArgs)
    {
        var benderType = benderArgs[0];
        var name = benderArgs[1];
        var power = int.Parse(benderArgs[2]);
        var secondaryParameter = double.Parse(benderArgs[3]);

        switch (benderType.ToLower())
        {
            case "air":
                return new AirBender(name, power, secondaryParameter);
                break;
            case "earth":
                return new EarthBender(name, power, secondaryParameter);
                break;
            case "fire":
                return new FireBender(name, power, secondaryParameter);
                break;
            case "water":
                return new WaterBender(name, power, secondaryParameter);
                break;
            default:
                throw new ArgumentException("Wrong bender type input.");
        }
    }

    public void AssignMonument(List<string> monumentArgs) // Command 2
    {
        var monumentType = monumentArgs[0];

        Monument currentMonument = this.GetMonument(monumentArgs);
        this.nations[monumentType].AddMonument(currentMonument);
    }

    private Monument GetMonument(List<string> monumentArgs)
    {
        var type = monumentArgs[0];
        var name = monumentArgs[1];
        int affinity = int.Parse(monumentArgs[2]);

        switch (type.ToLower())
        {
            case "air":
                return new AirMonument(name, affinity);
                break;
            case "earth":
                return new EarthMonument(name, affinity);
                break;
            case "fire":
                return new FireMonument(name, affinity);
                break;
            case "water":
                return new WaterMonument(name, affinity);
                break;
            default:
                throw new ArgumentException("Wrong monument type input.");
                break;
        }
    }

    public string GetStatus(string nationsType) // Command 3
    {
        StringBuilder message = new StringBuilder();

        message.AppendLine($"{nationsType} Nation")
            .Append(this.nations[nationsType]);

        return message.ToString();
    }

    public void IssueWar(string nationsType) // Command 4
    {
        double victoriousPower = this.nations.Max(kvp => kvp.Value.GetTotalPower());

        foreach (var nation in nations.Values)
        {
            if (nation.GetTotalPower() != victoriousPower)
            {
                nation.DeclareDefeat();
            }
        }

        this.warHistoryRecord.Add($"War {this.warHistoryRecord.Count + 1} issued by {nationsType}");
    }

    public string GetWarsRecord() // Command 5 - Terminate
    {
        return string.Join(Environment.NewLine, warHistoryRecord);
    }
}
