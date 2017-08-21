using System.Collections.Generic;

namespace _08.MillitaryElite.Interfaces
{
    public interface ILeutenantGeneral : IPrivate
    {
        HashSet<IPrivate> Privates { get; }
    }
}
