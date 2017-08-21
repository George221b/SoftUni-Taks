using System.Text;

public class CommonItem : IItem
{
    public CommonItem(string name, int strengthBonus, int agilityBonus, int intelligenceBonus, int hitPointsBonus, int damageBonus)
    {
        this.Name = name;
        this.StrengthBonus = strengthBonus;
        this.AgilityBonus = agilityBonus;
        this.IntelligenceBonus = intelligenceBonus;
        this.HitPointsBonus = hitPointsBonus;
        this.DamageBonus = damageBonus;
    }

    public string Name { get; }
    public int StrengthBonus { get; }
    public int AgilityBonus { get; }
    public int IntelligenceBonus { get; }
    public int HitPointsBonus { get; }
    public int DamageBonus { get; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"###Item: {this.Name}");
        sb.AppendLine($"###+{this.StrengthBonus} Strength");
        sb.AppendLine($"###+{this.AgilityBonus} Agility");
        sb.AppendLine($"###+{this.AgilityBonus} Intelligence");
        sb.AppendLine($"###+{this.HitPointsBonus} HitPoints");
        sb.Append($"###+{this.DamageBonus} Damage");

        return sb.ToString();
    }
}