using System;
using System.Diagnostics;
using UnityEngine;

namespace Toolbox
{
    /// <summary>
    /// Calls given callback each time associated property is changed.
    /// 
    /// <para>Supported types: all.</para>
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    [Conditional("UNITY_EDITOR")]
    public class OnValueChangedAttribute : PropertyAttribute
    {
        public OnValueChangedAttribute(string callbackMethodName)
        {
            CallbackMethodName = callbackMethodName;
        }

        public string CallbackMethodName { get; private set; }
    }
}