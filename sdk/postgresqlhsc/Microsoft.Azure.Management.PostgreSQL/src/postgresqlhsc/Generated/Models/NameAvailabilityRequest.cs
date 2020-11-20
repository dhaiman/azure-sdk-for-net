// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PostgreSQL.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Request from client to check resource name availability.
    /// </summary>
    public partial class NameAvailabilityRequest
    {
        /// <summary>
        /// Initializes a new instance of the NameAvailabilityRequest class.
        /// </summary>
        public NameAvailabilityRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NameAvailabilityRequest class.
        /// </summary>
        /// <param name="name">Resource name to verify.</param>
        /// <param name="type">Resource type used for verification.</param>
        public NameAvailabilityRequest(string name, string type = default(string))
        {
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource name to verify.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets resource type used for verification.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
