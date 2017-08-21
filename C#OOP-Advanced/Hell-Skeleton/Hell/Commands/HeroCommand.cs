public class HeroCommand : AbstractCommand
{
    private string name;
    private string type;
    [Inject]
    private IManager manager;

    public HeroCommand(string name, string type)
    {
        this.name = name;
        this.type = type;
    }

    public override string Execute()
    {
        return this.manager.AddHero(name, type);
    }
}
