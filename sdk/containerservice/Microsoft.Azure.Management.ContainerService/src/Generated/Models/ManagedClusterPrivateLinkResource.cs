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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties related to private link cluster.
    /// </summary>
    public partial class ManagedClusterPrivateLinkResource
    {
        /// <summary>
        /// Initializes a new instance of the ManagedClusterPrivateLinkResource
        /// class.
        /// </summary>
        public ManagedClusterPrivateLinkResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedClusterPrivateLinkResource
        /// class.
        /// </summary>
        /// <param name="id">The fully qualified Azure resource ID.</param>
        /// <param name="name">The private link resource name.</param>
        /// <param name="type">The private link resource type.</param>
        /// <param name="groupId">The group ID of the private link
        /// resource.</param>
        /// <param name="requiredMembers">The required members of the private
        /// link cluster.</param>
        /// <param name="privateLinkServiceID">The fully qualified private link
        /// service Azure resource ID.</param>
        public ManagedClusterPrivateLinkResource(string id = default(string), string name = default(string), string type = default(string), string groupId = default(string), IList<string> requiredMembers = default(IList<string>), string privateLinkServiceID = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            GroupId = groupId;
            RequiredMembers = requiredMembers;
            PrivateLinkServiceID = privateLinkServiceID;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the fully qualified Azure resource ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the private link resource name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the private link resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the group ID of the private link resource.
        /// </summary>
        [JsonProperty(PropertyName = "groupId")]
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or sets the required members of the private link cluster.
        /// </summary>
        [JsonProperty(PropertyName = "requiredMembers")]
        public IList<string> RequiredMembers { get; set; }

        /// <summary>
        /// Gets or sets the fully qualified private link service Azure
        /// resource ID.
        /// </summary>
        [JsonProperty(PropertyName = "privateLinkServiceID")]
        public string PrivateLinkServiceID { get; set; }

    }
}
