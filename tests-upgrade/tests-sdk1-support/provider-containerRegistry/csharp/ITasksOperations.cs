// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// TasksOperations operations.
    /// </summary>
    public partial interface ITasksOperations
    {
        /// <summary>
        /// Lists all the tasks for a specified container registry.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<Task>>> ListWithHttpMessagesAsync(string resourceGroupName, string registryName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get the properties of a specified task.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='taskName'>
        /// The name of the container registry task.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Task>> GetWithHttpMessagesAsync(string resourceGroupName, string registryName, string taskName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Creates a task for a container registry with the specified
        /// parameters.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='taskName'>
        /// The name of the container registry task.
        /// </param>
        /// <param name='taskCreateParameters'>
        /// The parameters for creating a task.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Task>> CreateWithHttpMessagesAsync(string resourceGroupName, string registryName, string taskName, Task taskCreateParameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Deletes a specified task.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='taskName'>
        /// The name of the container registry task.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string registryName, string taskName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Updates a task with the specified parameters.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='taskName'>
        /// The name of the container registry task.
        /// </param>
        /// <param name='taskUpdateParameters'>
        /// The parameters for updating a task.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Task>> UpdateWithHttpMessagesAsync(string resourceGroupName, string registryName, string taskName, TaskUpdateParameters taskUpdateParameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Returns a task with extended information that includes all secrets.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='taskName'>
        /// The name of the container registry task.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Task>> GetDetailsWithHttpMessagesAsync(string resourceGroupName, string registryName, string taskName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Creates a task for a container registry with the specified
        /// parameters.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='taskName'>
        /// The name of the container registry task.
        /// </param>
        /// <param name='taskCreateParameters'>
        /// The parameters for creating a task.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Task>> BeginCreateWithHttpMessagesAsync(string resourceGroupName, string registryName, string taskName, Task taskCreateParameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Deletes a specified task.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='taskName'>
        /// The name of the container registry task.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string registryName, string taskName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Updates a task with the specified parameters.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='taskName'>
        /// The name of the container registry task.
        /// </param>
        /// <param name='taskUpdateParameters'>
        /// The parameters for updating a task.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Task>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string registryName, string taskName, TaskUpdateParameters taskUpdateParameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Lists all the tasks for a specified container registry.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<Task>>> ListNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}
