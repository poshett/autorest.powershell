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
    /// The properties of a task step.
    /// </summary>
    [Newtonsoft.Json.JsonObject("FileTask")]
    public partial class FileTaskStep : TaskStepProperties
    {
        /// <summary>
        /// Initializes a new instance of the FileTaskStep class.
        /// </summary>
        public FileTaskStep()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FileTaskStep class.
        /// </summary>
        /// <param name="taskFilePath">The task template/definition file path
        /// relative to the source context.</param>
        /// <param name="baseImageDependencies">List of base image dependencies
        /// for a step.</param>
        /// <param name="contextPath">The URL(absolute or relative) of the
        /// source context for the task step.</param>
        /// <param name="contextAccessToken">The token (git PAT or SAS token of
        /// storage account blob) associated with the context for a
        /// step.</param>
        /// <param name="valuesFilePath">The task values/parameters file path
        /// relative to the source context.</param>
        /// <param name="values">The collection of overridable values that can
        /// be passed when running a task.</param>
        public FileTaskStep(string taskFilePath, System.Collections.Generic.IList<BaseImageDependency> baseImageDependencies = default(System.Collections.Generic.IList<BaseImageDependency>), string contextPath = default(string), string contextAccessToken = default(string), string valuesFilePath = default(string), System.Collections.Generic.IList<SetValue> values = default(System.Collections.Generic.IList<SetValue>))
            : base(baseImageDependencies, contextPath, contextAccessToken)
        {
            this.TaskFilePath = taskFilePath;
            this.ValuesFilePath = valuesFilePath;
            this.Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the task template/definition file path relative to the
        /// source context.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "taskFilePath")]
        public string TaskFilePath { get; set; }

        /// <summary>
        /// Gets or sets the task values/parameters file path relative to the
        /// source context.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "valuesFilePath")]
        public string ValuesFilePath { get; set; }

        /// <summary>
        /// Gets or sets the collection of overridable values that can be
        /// passed when running a task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "values")]
        public System.Collections.Generic.IList<SetValue> Values { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.TaskFilePath == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "TaskFilePath");
            }
            if (this.Values != null)
            {
                foreach (var element in this.Values)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
