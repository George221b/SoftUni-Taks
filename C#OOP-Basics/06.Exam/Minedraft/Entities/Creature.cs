public abstract class Creature
{
    private string id;

    protected Creature(string id)
    {
        this.Id = id;
    }

    public string Id
    {
        get { return this.id; }
        set { this.id = value; }
    }
}
