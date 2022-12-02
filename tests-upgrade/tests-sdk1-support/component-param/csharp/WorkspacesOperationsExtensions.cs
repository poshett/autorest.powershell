// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Sample
{
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Extension methods for WorkspacesOperations.
    /// </summary>
    public static partial class WorkspacesOperationsExtensions
    {
            /// <summary>
            /// Gets the workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            public static void Get(this IWorkspacesOperations operations, string resourceGroupName)
            {
                ((IWorkspacesOperations)operations).GetAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task GetAsync(this IWorkspacesOperations operations, string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.GetWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets the workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            public static void Delete(this IWorkspacesOperations operations, string resourceGroupName)
            {
                ((IWorkspacesOperations)operations).DeleteAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this IWorkspacesOperations operations, string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a new workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            public static void CreateOrUpdate(this IWorkspacesOperations operations, string resourceGroupName)
            {
                ((IWorkspacesOperations)operations).CreateOrUpdateAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task CreateOrUpdateAsync(this IWorkspacesOperations operations, string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            public static void Update(this IWorkspacesOperations operations, string resourceGroupName)
            {
                ((IWorkspacesOperations)operations).UpdateAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a workspace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task UpdateAsync(this IWorkspacesOperations operations, string resourceGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
