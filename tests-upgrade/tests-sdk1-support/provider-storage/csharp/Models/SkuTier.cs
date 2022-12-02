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
    /// Defines values for SkuTier.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum SkuTier
    {
        [System.Runtime.Serialization.EnumMember(Value = "Standard")]
        Standard,
        [System.Runtime.Serialization.EnumMember(Value = "Premium")]
        Premium
    }
    internal static class SkuTierEnumExtension
    {
        internal static string ToSerializedValue(this SkuTier? value)
        {
            return value == null ? null : ((SkuTier)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this SkuTier value)
        {
            switch( value )
            {
                case SkuTier.Standard:
                    return "Standard";
                case SkuTier.Premium:
                    return "Premium";
            }
            return null;
        }

        internal static SkuTier? ParseSkuTier(this string value)
        {
            switch( value )
            {
                case "Standard":
                    return SkuTier.Standard;
                case "Premium":
                    return SkuTier.Premium;
            }
            return null;
        }
    }
}
