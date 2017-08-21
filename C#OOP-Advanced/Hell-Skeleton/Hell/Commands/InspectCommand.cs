public class InspectCommand : AbstractCommand
{
    private string name;
    [Inject]
    private IManager manager;

    public InspectCommand(string name)
    {
        this.name = name;
    }

    public override string Execute()
    {
        return this.manager.Inspect(this.name);
    }
}
