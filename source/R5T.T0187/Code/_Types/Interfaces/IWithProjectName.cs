using System;

using R5T.T0142;


namespace R5T.T0187
{
    [DataTypeMarker]
    public interface IWithProjectName :
        IHasProjectName
    {
        new IProjectName ProjectName { set; }
    }
}
