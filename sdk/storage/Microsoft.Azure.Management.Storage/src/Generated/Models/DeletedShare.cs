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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The deleted share to be restored.
    /// </summary>
    public partial class DeletedShare
    {
        /// <summary>
        /// Initializes a new instance of the DeletedShare class.
        /// </summary>
        public DeletedShare()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeletedShare class.
        /// </summary>
        /// <param name="deletedShareName">Required. Identify the name of the
        /// deleted share that will be restored.</param>
        /// <param name="deletedShareVersion">Required. Identify the version of
        /// the deleted share that will be restored.</param>
        public DeletedShare(string deletedShareName = default(string), string deletedShareVersion = default(string))
        {
            DeletedShareName = deletedShareName;
            DeletedShareVersion = deletedShareVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets required. Identify the name of the deleted share that
        /// will be restored.
        /// </summary>
        [JsonProperty(PropertyName = "deletedShareName")]
        public string DeletedShareName { get; set; }

        /// <summary>
        /// Gets or sets required. Identify the version of the deleted share
        /// that will be restored.
        /// </summary>
        [JsonProperty(PropertyName = "deletedShareVersion")]
        public string DeletedShareVersion { get; set; }

    }
}
