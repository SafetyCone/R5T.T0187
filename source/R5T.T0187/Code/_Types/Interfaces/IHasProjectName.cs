using System;

using R5T.T0142;


namespace R5T.T0187
{
    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    /// For stringly-typed complementary type, see R5T.L0096.T000.
    /// </remarks>
    [DataTypeMarker]
    public interface IHasProjectName
    {
        IProjectName ProjectName { get; }
    }
}
