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
    using System.Linq;

    /// <summary>
    /// Blob range
    /// </summary>
    public partial class BlobRestoreRange
    {
        /// <summary>
        /// Initializes a new instance of the BlobRestoreRange class.
        /// </summary>
        public BlobRestoreRange()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BlobRestoreRange class.
        /// </summary>
        /// <param name="startRange">Blob start range. This is inclusive. Empty
        /// means account start.</param>
        /// <param name="endRange">Blob end range. This is exclusive. Empty
        /// means account end.</param>
        public BlobRestoreRange(string startRange, string endRange)
        {
            this.StartRange = startRange;
            this.EndRange = endRange;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets blob start range. This is inclusive. Empty means
        /// account start.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startRange")]
        public string StartRange { get; set; }

        /// <summary>
        /// Gets or sets blob end range. This is exclusive. Empty means account
        /// end.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endRange")]
        public string EndRange { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.StartRange == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "StartRange");
            }
            if (this.EndRange == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "EndRange");
            }
        }
    }
}
