using System;


namespace R5T.T0187.Extensions
{
    public static class StringExtensions
    {
        public static IProjectDescription ToProjectDescription(this string value)
        {
            return Instances.StringOperator.ToProjectDescription(value);
        }

        public static IProjectName ToProjectName(this string value)
        {
            return Instances.StringOperator.ToProjectName(value);
        }

        public static ISolutionName ToSolutionName(this string value)
        {
            return Instances.StringOperator.ToSolutionName(value);
        }
    }
}
