// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for Operations.
    /// </summary>
    public static partial class OperationsExtensions
    {
            /// <summary>
            /// Gets a list of operations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static System.Collections.Generic.IEnumerable<OperationValue> List(this IOperations operations)
            {
                return ((IOperations)operations).ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of operations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<OperationValue>> ListAsync(this IOperations operations, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
