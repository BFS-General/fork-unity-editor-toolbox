using System;
using System.Diagnostics;

namespace Toolbox
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    [Conditional("UNITY_EDITOR")]
    public abstract class ToolboxConditionAttribute : ToolboxAttribute
    { }
}