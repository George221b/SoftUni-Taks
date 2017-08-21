using System.Collections.Generic;
using _08.MillitaryElite.Models;

namespace _08.MillitaryElite.Interfaces
{
    public interface ICommando : ISpecialisedSoldier
    {
        HashSet<Mission> Missions { get; }
    }
}
