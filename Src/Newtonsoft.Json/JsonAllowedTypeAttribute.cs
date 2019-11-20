#region License
// Copyright (c) 2007 James Newton-King
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace Yodiwo.Json
{
    /// <summary>
    /// Instructs the <see cref="JsonSerializer"/> that the specified types are allowed to be used in with "$type" in deserialization of object/abstract/intrefaces members.
    /// You can decorate the property/field with multiple JsonAllowedType attributes to allow many different types
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)]
    public sealed class JsonAllowedTypeAttribute : Attribute
    {
        /// <summary></summary>
        public Type AllowedType;
        /// <summary></summary>
        public Type[] AllowedTypes;
        /// <summary></summary>
        public bool AllowDerivedTypes;

        /// <summary></summary>
        public JsonAllowedTypeAttribute(Type AllowedType)
        {
            this.AllowedType = AllowedType;
        }
        /// <summary></summary>
        public JsonAllowedTypeAttribute(Type[] AllowedTypes)
        {
            this.AllowedTypes = AllowedTypes;
        }
        /// <summary></summary>
        public JsonAllowedTypeAttribute(bool AllowDerivedTypes)
        {
            this.AllowDerivedTypes = AllowDerivedTypes;
        }
    }
}