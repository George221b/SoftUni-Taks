using System.Collections.Generic;
using _08.MillitaryElite.Models;

namespace _08.MillitaryElite.Interfaces
{
    public interface IEngineer : ISpecialisedSoldier
    {
        HashSet<Repair> Repairs { get; }
    }
}
