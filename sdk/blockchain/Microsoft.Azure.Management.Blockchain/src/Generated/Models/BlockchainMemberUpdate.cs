// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Blockchain.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Update the payload of the blockchain member which is exposed in the
    /// request/response of the resource provider.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BlockchainMemberUpdate
    {
        /// <summary>
        /// Initializes a new instance of the BlockchainMemberUpdate class.
        /// </summary>
        public BlockchainMemberUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BlockchainMemberUpdate class.
        /// </summary>
        /// <param name="tags">Tags of the service which is a list of key value
        /// pairs that describes the resource.</param>
        /// <param name="password">Sets the transaction node dns endpoint basic
        /// auth password.</param>
        /// <param name="firewallRules">Gets or sets the firewall
        /// rules.</param>
        /// <param name="consortiumManagementAccountPassword">Sets the managed
        /// consortium management account password.</param>
        public BlockchainMemberUpdate(IDictionary<string, string> tags = default(IDictionary<string, string>), string password = default(string), IList<FirewallRule> firewallRules = default(IList<FirewallRule>), string consortiumManagementAccountPassword = default(string))
        {
            Tags = tags;
            Password = password;
            FirewallRules = firewallRules;
            ConsortiumManagementAccountPassword = consortiumManagementAccountPassword;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets tags of the service which is a list of key value pairs
        /// that describes the resource.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets sets the transaction node dns endpoint basic auth
        /// password.
        /// </summary>
        [JsonProperty(PropertyName = "properties.password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the firewall rules.
        /// </summary>
        [JsonProperty(PropertyName = "properties.firewallRules")]
        public IList<FirewallRule> FirewallRules { get; set; }

        /// <summary>
        /// Gets or sets sets the managed consortium management account
        /// password.
        /// </summary>
        [JsonProperty(PropertyName = "properties.consortiumManagementAccountPassword")]
        public string ConsortiumManagementAccountPassword { get; set; }

    }
}
