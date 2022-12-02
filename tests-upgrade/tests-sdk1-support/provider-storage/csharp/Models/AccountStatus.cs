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
    /// Defines values for AccountStatus.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum AccountStatus
    {
        [System.Runtime.Serialization.EnumMember(Value = "available")]
        Available,
        [System.Runtime.Serialization.EnumMember(Value = "unavailable")]
        Unavailable
    }
    internal static class AccountStatusEnumExtension
    {
        internal static string ToSerializedValue(this AccountStatus? value)
        {
            return value == null ? null : ((AccountStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AccountStatus value)
        {
            switch( value )
            {
                case AccountStatus.Available:
                    return "available";
                case AccountStatus.Unavailable:
                    return "unavailable";
            }
            return null;
        }

        internal static AccountStatus? ParseAccountStatus(this string value)
        {
            switch( value )
            {
                case "available":
                    return AccountStatus.Available;
                case "unavailable":
                    return AccountStatus.Unavailable;
            }
            return null;
        }
    }
}
