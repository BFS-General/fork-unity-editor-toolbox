using System;
using System.Diagnostics;

namespace Toolbox
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    [Conditional("UNITY_EDITOR")]
    public class DynamicMinMaxSliderAttribute : DynamicMinMaxBaseAttribute
    {
        public DynamicMinMaxSliderAttribute(string minValueSource, string maxValueSource) : base(minValueSource, maxValueSource)
        { }
    }
}