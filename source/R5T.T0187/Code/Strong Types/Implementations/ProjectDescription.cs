using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0187
{
    /// <inheritdoc cref="IProjectDescription"/>
    [StrongTypeImplementationMarker]
    public class ProjectDescription : TypedBase<string>, IStrongTypeMarker,
        IProjectDescription
    {
        public ProjectDescription(string value)
            : base(value)
        {
        }
    }
}
