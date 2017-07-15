using System.Collections.Generic;
using System.Linq;

public class Family
{
    private HashSet<Person> members;

    public Family()
    {
        this.members = new HashSet<Person>();
    }

    public void AddMember(Person member)
    {
        this.members.Add(member);
    }

    public Person GetOldestMember()
    {
        return this.members.OrderByDescending(p => p.Age)
            .FirstOrDefault();
    }
}
