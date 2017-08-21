using System.Collections.Generic;

public class QuitCommand : AbstractCommand
{
    [Inject]
    private IManager manager;

    public override string Execute()
    {
        return this.manager.PrintAllHeroes();
    }
}