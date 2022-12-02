// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Sample.Models
{
    using System.Linq;

    /// <summary>
    /// Properties required to create any resource tracked by Azure Resource
    /// Manager.
    /// </summary>
    public partial class CreateOrUpdateTrackedResourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CreateOrUpdateTrackedResourceProperties class.
        /// </summary>
        public CreateOrUpdateTrackedResourceProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CreateOrUpdateTrackedResourceProperties class.
        /// </summary>
        /// <param name="location">The location of the resource.</param>
        /// <param name="tags">Key-value pairs of additional properties for the
        /// resource.</param>
        public CreateOrUpdateTrackedResourceProperties(string location, string tags = default(string))
        {
            this.Location = location;
            this.Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the location of the resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets key-value pairs of additional properties for the
        /// resource.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tags")]
        public string Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Location == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Location");
            }
        }
    }
}
