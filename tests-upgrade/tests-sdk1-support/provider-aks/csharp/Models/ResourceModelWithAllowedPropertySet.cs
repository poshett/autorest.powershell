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
    /// The resource model definition containing the full set of allowed
    /// properties for a resource. Except properties bag, there cannot be a top
    /// level property outside of this set.
    /// </summary>
    public partial class ResourceModelWithAllowedPropertySet : Microsoft.Rest.Azure.IResource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResourceModelWithAllowedPropertySet class.
        /// </summary>
        public ResourceModelWithAllowedPropertySet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ResourceModelWithAllowedPropertySet class.
        /// </summary>
        /// <param name="managedBy">The fully qualified resource ID of the
        /// resource that manages this resource. Indicates if this resource is
        /// managed by another Azure resource. If this is present, complete
        /// mode deployment will not delete the resource if it is removed from
        /// the template since it is managed by another resource.</param>
        /// <param name="kind">Metadata used by portal/tooling/etc to render
        /// different UX experiences for resources of the same type; e.g.
        /// ApiApps are a kind of Microsoft.Web/sites type.  If supported, the
        /// resource provider must validate and persist this value.</param>
        /// <param name="etag">The etag field is *not* required. If it is
        /// provided in the response body, it must also be provided as a header
        /// per the normal etag convention.  Entity tags are used for comparing
        /// two or more entities from the same requested resource. HTTP/1.1
        /// uses entity tags in the etag (section 14.19), If-Match (section
        /// 14.24), If-None-Match (section 14.26), and If-Range (section 14.27)
        /// header fields. </param>
        public ResourceModelWithAllowedPropertySet(string managedBy = default(string), string kind = default(string), string etag = default(string), ResourceModelWithAllowedPropertySetIdentity identity = default(ResourceModelWithAllowedPropertySetIdentity), ResourceModelWithAllowedPropertySetSku sku = default(ResourceModelWithAllowedPropertySetSku), ResourceModelWithAllowedPropertySetPlan plan = default(ResourceModelWithAllowedPropertySetPlan))
        {
            this.ManagedBy = managedBy;
            this.Kind = kind;
            this.Etag = etag;
            this.Identity = identity;
            this.Sku = sku;
            this.Plan = plan;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the fully qualified resource ID of the resource that
        /// manages this resource. Indicates if this resource is managed by
        /// another Azure resource. If this is present, complete mode
        /// deployment will not delete the resource if it is removed from the
        /// template since it is managed by another resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "managedBy")]
        public string ManagedBy { get; set; }

        /// <summary>
        /// Gets or sets metadata used by portal/tooling/etc to render
        /// different UX experiences for resources of the same type; e.g.
        /// ApiApps are a kind of Microsoft.Web/sites type.  If supported, the
        /// resource provider must validate and persist this value.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets the etag field is *not* required. If it is provided in the
        /// response body, it must also be provided as a header per the normal
        /// etag convention.  Entity tags are used for comparing two or more
        /// entities from the same requested resource. HTTP/1.1 uses entity
        /// tags in the etag (section 14.19), If-Match (section 14.24),
        /// If-None-Match (section 14.26), and If-Range (section 14.27) header
        /// fields.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "identity")]
        public ResourceModelWithAllowedPropertySetIdentity Identity { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sku")]
        public ResourceModelWithAllowedPropertySetSku Sku { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "plan")]
        public ResourceModelWithAllowedPropertySetPlan Plan { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Kind != null)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(this.Kind, "^[-\\w\\._,\\(\\)]+$"))
                {
                    throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.Pattern, "Kind", "^[-\\w\\._,\\(\\)]+$");
                }
            }
            if (this.Sku != null)
            {
                this.Sku.Validate();
            }
            if (this.Plan != null)
            {
                this.Plan.Validate();
            }
        }
    }
}
