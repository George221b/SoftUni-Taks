using System.Collections.Generic;

public class RecipeItem : IRecipe
{
    public RecipeItem(string name, int strengthBonus, int agilityBonus, int intelligenceBonus, int hitPointsBonus, int damageBonus, List<string> requiredItems)
    {
        this.Name = name;
        this.StrengthBonus = strengthBonus;
        this.AgilityBonus = agilityBonus;
        this.IntelligenceBonus = intelligenceBonus;
        this.HitPointsBonus = hitPointsBonus;
        this.DamageBonus = damageBonus;
        this.RequiredItems = requiredItems;
    }

    public string Name { get; }
    public int StrengthBonus { get; }
    public int AgilityBonus { get; }
    public int IntelligenceBonus { get; }
    public int HitPointsBonus { get; }
    public int DamageBonus { get; }

    public List<string> RequiredItems { get; }
}