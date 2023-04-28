using System;

using R5T.T0178;
using R5T.T0185;


namespace R5T.T0187
{
    /// <summary>
    /// Strongly-types a string as a .NET project name.
    /// </summary>
    [StrongTypeMarker]
    public interface IProjectName : IStrongTypeMarker,
        IName
    {
    }
}
