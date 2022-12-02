// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for LocalUsersOperations.
    /// </summary>
    public static partial class LocalUsersOperationsExtensions
    {
            /// <summary>
            /// List the local users associated with the storage account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            public static System.Collections.Generic.IEnumerable<LocalUser> List(this ILocalUsersOperations operations, string resourceGroupName, string accountName)
            {
                return ((ILocalUsersOperations)operations).ListAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List the local users associated with the storage account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<LocalUser>> ListAsync(this ILocalUsersOperations operations, string resourceGroupName, string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the local user of the storage account by username.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='username'>
            /// The name of local user. The username must contain lowercase letters and
            /// numbers only. It must be unique only within the storage account.
            /// </param>
            public static LocalUser Get(this ILocalUsersOperations operations, string resourceGroupName, string accountName, string username)
            {
                return ((ILocalUsersOperations)operations).GetAsync(resourceGroupName, accountName, username).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the local user of the storage account by username.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='username'>
            /// The name of local user. The username must contain lowercase letters and
            /// numbers only. It must be unique only within the storage account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<LocalUser> GetAsync(this ILocalUsersOperations operations, string resourceGroupName, string accountName, string username, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, username, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update the properties of a local user associated with the storage
            /// account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='username'>
            /// The name of local user. The username must contain lowercase letters and
            /// numbers only. It must be unique only within the storage account.
            /// </param>
            /// <param name='properties'>
            /// The local user associated with a storage account.
            /// </param>
            public static LocalUser CreateOrUpdate(this ILocalUsersOperations operations, string resourceGroupName, string accountName, string username, LocalUser properties)
            {
                return ((ILocalUsersOperations)operations).CreateOrUpdateAsync(resourceGroupName, accountName, username, properties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update the properties of a local user associated with the storage
            /// account
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='username'>
            /// The name of local user. The username must contain lowercase letters and
            /// numbers only. It must be unique only within the storage account.
            /// </param>
            /// <param name='properties'>
            /// The local user associated with a storage account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<LocalUser> CreateOrUpdateAsync(this ILocalUsersOperations operations, string resourceGroupName, string accountName, string username, LocalUser properties, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, accountName, username, properties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the local user associated with the specified storage account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='username'>
            /// The name of local user. The username must contain lowercase letters and
            /// numbers only. It must be unique only within the storage account.
            /// </param>
            public static void Delete(this ILocalUsersOperations operations, string resourceGroupName, string accountName, string username)
            {
                ((ILocalUsersOperations)operations).DeleteAsync(resourceGroupName, accountName, username).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the local user associated with the specified storage account.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='username'>
            /// The name of local user. The username must contain lowercase letters and
            /// numbers only. It must be unique only within the storage account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this ILocalUsersOperations operations, string resourceGroupName, string accountName, string username, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, username, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List SSH authorized keys and shared key of the local user.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='username'>
            /// The name of local user. The username must contain lowercase letters and
            /// numbers only. It must be unique only within the storage account.
            /// </param>
            public static LocalUserKeys ListKeys(this ILocalUsersOperations operations, string resourceGroupName, string accountName, string username)
            {
                return ((ILocalUsersOperations)operations).ListKeysAsync(resourceGroupName, accountName, username).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List SSH authorized keys and shared key of the local user.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='username'>
            /// The name of local user. The username must contain lowercase letters and
            /// numbers only. It must be unique only within the storage account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<LocalUserKeys> ListKeysAsync(this ILocalUsersOperations operations, string resourceGroupName, string accountName, string username, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, accountName, username, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerate the local user SSH password.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='username'>
            /// The name of local user. The username must contain lowercase letters and
            /// numbers only. It must be unique only within the storage account.
            /// </param>
            public static LocalUserRegeneratePasswordResult RegeneratePassword(this ILocalUsersOperations operations, string resourceGroupName, string accountName, string username)
            {
                return ((ILocalUsersOperations)operations).RegeneratePasswordAsync(resourceGroupName, accountName, username).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerate the local user SSH password.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='accountName'>
            /// The name of the storage account within the specified resource group.
            /// Storage account names must be between 3 and 24 characters in length and use
            /// numbers and lower-case letters only.
            /// </param>
            /// <param name='username'>
            /// The name of local user. The username must contain lowercase letters and
            /// numbers only. It must be unique only within the storage account.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<LocalUserRegeneratePasswordResult> RegeneratePasswordAsync(this ILocalUsersOperations operations, string resourceGroupName, string accountName, string username, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.RegeneratePasswordWithHttpMessagesAsync(resourceGroupName, accountName, username, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
