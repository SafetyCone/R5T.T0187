using System;

using R5T.T0178;
using R5T.T0185;


namespace R5T.T0187
{
    /// <summary>
    /// Strongly-types a string as a project description.
    /// </summary>
    [StrongTypeMarker]
    public interface IProjectDescription : IStrongTypeMarker,
        IDescription
    {
    }
}
