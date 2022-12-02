// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Models
{
    using System.Linq;

    /// <summary>
    /// A private endpoint connection
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class PrivateEndpointConnection : Microsoft.Rest.Azure.IResource
    {
        /// <summary>
        /// Initializes a new instance of the PrivateEndpointConnection class.
        /// </summary>
        public PrivateEndpointConnection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateEndpointConnection class.
        /// </summary>
        /// <param name="privateLinkServiceConnectionState">A collection of
        /// information about the state of the connection between service
        /// consumer and provider.</param>
        /// <param name="id">The ID of the private endpoint connection.</param>
        /// <param name="name">The name of the private endpoint
        /// connection.</param>
        /// <param name="type">The resource type.</param>
        /// <param name="provisioningState">The current provisioning state.
        /// Possible values include: 'Succeeded', 'Creating', 'Deleting',
        /// 'Failed'</param>
        /// <param name="privateEndpoint">The resource of private
        /// endpoint.</param>
        public PrivateEndpointConnection(PrivateLinkServiceConnectionState privateLinkServiceConnectionState, string id = default(string), string name = default(string), string type = default(string), string provisioningState = default(string), PrivateEndpoint privateEndpoint = default(PrivateEndpoint))
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.ProvisioningState = provisioningState;
            this.PrivateEndpoint = privateEndpoint;
            this.PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the ID of the private endpoint connection.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the private endpoint connection.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the resource type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets the current provisioning state. Possible values include:
        /// 'Succeeded', 'Creating', 'Deleting', 'Failed'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the resource of private endpoint.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.privateEndpoint")]
        public PrivateEndpoint PrivateEndpoint { get; set; }

        /// <summary>
        /// Gets or sets a collection of information about the state of the
        /// connection between service consumer and provider.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.privateLinkServiceConnectionState")]
        public PrivateLinkServiceConnectionState PrivateLinkServiceConnectionState { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.PrivateLinkServiceConnectionState == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "PrivateLinkServiceConnectionState");
            }
        }
    }
}
