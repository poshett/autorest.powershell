// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using System.Linq;

    public partial class ImportSource
    {
        /// <summary>
        /// Initializes a new instance of the ImportSource class.
        /// </summary>
        public ImportSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImportSource class.
        /// </summary>
        /// <param name="sourceImage">Repository name of the source image.
        /// Specify an image by repository ('hello-world'). This will use the
        /// 'latest' tag.
        /// Specify an image by tag ('hello-world:latest').
        /// Specify an image by sha256-based manifest digest
        /// ('hello-world@sha256:abc123').</param>
        /// <param name="resourceId">The resource identifier of the source
        /// Azure Container Registry.</param>
        /// <param name="registryUri">The address of the source registry (e.g.
        /// 'mcr.microsoft.com').</param>
        /// <param name="credentials">Credentials used when importing from a
        /// registry uri.</param>
        public ImportSource(string sourceImage, string resourceId = default(string), string registryUri = default(string), ImportSourceCredentials credentials = default(ImportSourceCredentials))
        {
            this.ResourceId = resourceId;
            this.RegistryUri = registryUri;
            this.Credentials = credentials;
            this.SourceImage = sourceImage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the resource identifier of the source Azure Container
        /// Registry.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

        /// <summary>
        /// Gets or sets the address of the source registry (e.g.
        /// 'mcr.microsoft.com').
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "registryUri")]
        public string RegistryUri { get; set; }

        /// <summary>
        /// Gets or sets credentials used when importing from a registry uri.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "credentials")]
        public ImportSourceCredentials Credentials { get; set; }

        /// <summary>
        /// Gets or sets repository name of the source image.
        /// Specify an image by repository ('hello-world'). This will use the
        /// 'latest' tag.
        /// Specify an image by tag ('hello-world:latest').
        /// Specify an image by sha256-based manifest digest
        /// ('hello-world@sha256:abc123').
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sourceImage")]
        public string SourceImage { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.SourceImage == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "SourceImage");
            }
            if (this.Credentials != null)
            {
                this.Credentials.Validate();
            }
        }
    }
}
