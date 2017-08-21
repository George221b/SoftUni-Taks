using System.Collections.Generic;
using System.Linq;

public class RecipeCommand : AbstractCommand
{
    private string name;
    private string heroName;
    private int strengthBonus;
    private int agilityBonus;
    private int intelligenceBonus;
    private int hitpointsBonus;
    private int damageBonus;
    private List<string> requiredItems;
    [Inject]
    private IManager manager;

    public RecipeCommand(string name, string heroName,
        int strengthBonus, int agilityBonus, int intelligenceBonus,
        int hitpointsBonus, int damageBonus, params string[] requiredItems)
    {
        this.name = name;
        this.heroName = heroName;
        this.strengthBonus = strengthBonus;
        this.agilityBonus = agilityBonus;
        this.intelligenceBonus = intelligenceBonus;
        this.hitpointsBonus = hitpointsBonus;
        this.damageBonus = damageBonus;
        this.requiredItems = requiredItems.ToList();
    }

    public override string Execute()
    {
        return this.manager.AddRecipeToHero(name, heroName, strengthBonus,
            agilityBonus, intelligenceBonus, hitpointsBonus,
            damageBonus, requiredItems);
    }
}
