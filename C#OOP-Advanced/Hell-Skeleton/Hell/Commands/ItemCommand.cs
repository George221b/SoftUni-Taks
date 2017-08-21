public class ItemCommand : AbstractCommand
{
    private string name;
    private string heroName;
    private int strengthBonus;
    private int agilityBonus;
    private int intelligenceBonus;
    private int hitpointsBonus;
    private int damageBonus;
    [Inject]
    private IManager manager;

    public ItemCommand(string name, string heroName,
        int strengthBonus, int agilityBonus, int intelligenceBonus,
        int hitpointsBonus, int damageBonus)
    {
        this.name = name;
        this.heroName = heroName;
        this.strengthBonus = strengthBonus;
        this.agilityBonus = agilityBonus;
        this.intelligenceBonus = intelligenceBonus;
        this.hitpointsBonus = hitpointsBonus;
        this.damageBonus = damageBonus;
    }

    public override string Execute()
    {
        return this.manager.AddItemToHero(name, heroName,
        strengthBonus, agilityBonus, intelligenceBonus,
        hitpointsBonus, damageBonus);
    }
}
