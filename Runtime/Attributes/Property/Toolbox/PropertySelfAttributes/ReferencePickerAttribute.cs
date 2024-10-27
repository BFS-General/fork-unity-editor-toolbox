﻿#if UNITY_2019_3_OR_NEWER
using System;
using System.Diagnostics;

namespace Toolbox
{
    /// <summary>
    /// Creates dedicated drawer for fields marked with the <see cref="SerializeReference"/>.
    /// 
    /// <para>Supported types: any serializable type and field with the <see cref="SerializeReference"/> attribute.</para>
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    [Conditional("UNITY_EDITOR")]
    public class ReferencePickerAttribute : ToolboxSelfPropertyAttribute
    {
        public ReferencePickerAttribute()
        { }

        public ReferencePickerAttribute(Type parentType) : this(parentType, TypeGrouping.None)
        { }

        public ReferencePickerAttribute(Type parentType, TypeGrouping typeGrouping)
        {
            ParentType = parentType;
            TypeGrouping = typeGrouping;
        }

        public Type ParentType { get; set; }

        /// <summary>
        /// Indicates if created instance should be uninitialized.
        /// </summary>
        public bool ForceUninitializedInstance { get; set; }

        /// <summary>
        /// Gets or sets grouping of selectable classes.
        /// Defaults to <see cref="TypeGrouping.None"/> unless explicitly specified.
        /// </summary>
        public TypeGrouping TypeGrouping { get; set; } = TypeGrouping.None;

        /// <summary>
        /// Indicates if created popup menu should have an additional search field.
        /// </summary>
        public bool AddTextSearchField { get; set; } = true;
    }
}
#endif