using System;

using R5T.T0132;


namespace R5T.T0187.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        public IProjectDescription ToProjectDescription(string value)
        {
            var output = new ProjectDescription(value);
            return output;
        }

        public IProjectName ToProjectName(string value)
        {
            var output = new ProjectName(value);
            return output;
        }

        public ISolutionName ToSolutionName(string value)
        {
            var output = new SolutionName(value);
            return output;
        }
    }
}
