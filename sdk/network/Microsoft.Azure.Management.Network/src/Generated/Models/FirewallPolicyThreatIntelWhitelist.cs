// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// ThreatIntel Whitelist for Firewall Policy.
    /// </summary>
    public partial class FirewallPolicyThreatIntelWhitelist
    {
        /// <summary>
        /// Initializes a new instance of the
        /// FirewallPolicyThreatIntelWhitelist class.
        /// </summary>
        public FirewallPolicyThreatIntelWhitelist()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// FirewallPolicyThreatIntelWhitelist class.
        /// </summary>
        /// <param name="ipAddresses">List of IP addresses for the Firewall
        /// Policy ThreatIntel Whitelist.</param>
        /// <param name="fqdns">List of FQDNs for the Firewall Policy
        /// ThreatIntel Whitelist.</param>
        public FirewallPolicyThreatIntelWhitelist(IList<string> ipAddresses = default(IList<string>), IList<string> fqdns = default(IList<string>))
        {
            IpAddresses = ipAddresses;
            Fqdns = fqdns;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of IP addresses for the Firewall Policy
        /// ThreatIntel Whitelist.
        /// </summary>
        [JsonProperty(PropertyName = "ipAddresses")]
        public IList<string> IpAddresses { get; set; }

        /// <summary>
        /// Gets or sets list of FQDNs for the Firewall Policy ThreatIntel
        /// Whitelist.
        /// </summary>
        [JsonProperty(PropertyName = "fqdns")]
        public IList<string> Fqdns { get; set; }

    }
}
