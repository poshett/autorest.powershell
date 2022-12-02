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

    /// <summary>
    /// The definition of Azure Monitoring metrics list.
    /// </summary>
    public partial class OperationServiceSpecificationDefinition
    {
        /// <summary>
        /// Initializes a new instance of the
        /// OperationServiceSpecificationDefinition class.
        /// </summary>
        public OperationServiceSpecificationDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// OperationServiceSpecificationDefinition class.
        /// </summary>
        /// <param name="metricSpecifications">A list of Azure Monitoring
        /// metrics definition.</param>
        public OperationServiceSpecificationDefinition(System.Collections.Generic.IList<OperationMetricSpecificationDefinition> metricSpecifications = default(System.Collections.Generic.IList<OperationMetricSpecificationDefinition>))
        {
            this.MetricSpecifications = metricSpecifications;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of Azure Monitoring metrics definition.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "metricSpecifications")]
        public System.Collections.Generic.IList<OperationMetricSpecificationDefinition> MetricSpecifications { get; set; }

    }
}
