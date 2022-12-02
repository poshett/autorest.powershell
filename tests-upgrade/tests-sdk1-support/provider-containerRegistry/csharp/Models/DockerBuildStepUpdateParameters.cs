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
    /// The properties for updating a docker build step.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Docker")]
    public partial class DockerBuildStepUpdateParameters : TaskStepUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the DockerBuildStepUpdateParameters
        /// class.
        /// </summary>
        public DockerBuildStepUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DockerBuildStepUpdateParameters
        /// class.
        /// </summary>
        /// <param name="contextPath">The URL(absolute or relative) of the
        /// source context for the task step.</param>
        /// <param name="contextAccessToken">The token (git PAT or SAS token of
        /// storage account blob) associated with the context for a
        /// step.</param>
        /// <param name="imageNames">The fully qualified image names including
        /// the repository and tag.</param>
        /// <param name="isPushEnabled">The value of this property indicates
        /// whether the image built should be pushed to the registry or
        /// not.</param>
        /// <param name="noCache">The value of this property indicates whether
        /// the image cache is enabled or not.</param>
        /// <param name="dockerFilePath">The Docker file path relative to the
        /// source context.</param>
        /// <param name="arguments">The collection of override arguments to be
        /// used when executing this build step.</param>
        /// <param name="target">The name of the target build stage for the
        /// docker build.</param>
        public DockerBuildStepUpdateParameters(string contextPath = default(string), string contextAccessToken = default(string), System.Collections.Generic.IList<string> imageNames = default(System.Collections.Generic.IList<string>), bool? isPushEnabled = default(bool?), bool? noCache = default(bool?), string dockerFilePath = default(string), System.Collections.Generic.IList<Argument> arguments = default(System.Collections.Generic.IList<Argument>), string target = default(string))
            : base(contextPath, contextAccessToken)
        {
            this.ImageNames = imageNames;
            this.IsPushEnabled = isPushEnabled;
            this.NoCache = noCache;
            this.DockerFilePath = dockerFilePath;
            this.Arguments = arguments;
            this.Target = target;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the fully qualified image names including the
        /// repository and tag.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "imageNames")]
        public System.Collections.Generic.IList<string> ImageNames { get; set; }

        /// <summary>
        /// Gets or sets the value of this property indicates whether the image
        /// built should be pushed to the registry or not.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isPushEnabled")]
        public bool? IsPushEnabled { get; set; }

        /// <summary>
        /// Gets or sets the value of this property indicates whether the image
        /// cache is enabled or not.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "noCache")]
        public bool? NoCache { get; set; }

        /// <summary>
        /// Gets or sets the Docker file path relative to the source context.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dockerFilePath")]
        public string DockerFilePath { get; set; }

        /// <summary>
        /// Gets or sets the collection of override arguments to be used when
        /// executing this build step.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "arguments")]
        public System.Collections.Generic.IList<Argument> Arguments { get; set; }

        /// <summary>
        /// Gets or sets the name of the target build stage for the docker
        /// build.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

    }
}
