// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{

    /// <summary>
    /// Defines values for ListKeyExpand.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ListKeyExpand
    {
        [System.Runtime.Serialization.EnumMember(Value = "kerb")]
        Kerb
    }
    internal static class ListKeyExpandEnumExtension
    {
        internal static string ToSerializedValue(this ListKeyExpand? value)
        {
            return value == null ? null : ((ListKeyExpand)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ListKeyExpand value)
        {
            switch( value )
            {
                case ListKeyExpand.Kerb:
                    return "kerb";
            }
            return null;
        }

        internal static ListKeyExpand? ParseListKeyExpand(this string value)
        {
            switch( value )
            {
                case "kerb":
                    return ListKeyExpand.Kerb;
            }
            return null;
        }
    }
}
