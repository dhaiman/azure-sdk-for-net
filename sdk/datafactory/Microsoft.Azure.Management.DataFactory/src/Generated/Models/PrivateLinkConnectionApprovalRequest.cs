// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A request to approve or reject a private endpoint connection
    /// </summary>
    public partial class PrivateLinkConnectionApprovalRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PrivateLinkConnectionApprovalRequest class.
        /// </summary>
        public PrivateLinkConnectionApprovalRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PrivateLinkConnectionApprovalRequest class.
        /// </summary>
        public PrivateLinkConnectionApprovalRequest(PrivateLinkConnectionState privateLinkServiceConnectionState = default(PrivateLinkConnectionState))
        {
            PrivateLinkServiceConnectionState = privateLinkServiceConnectionState;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "privateLinkServiceConnectionState")]
        public PrivateLinkConnectionState PrivateLinkServiceConnectionState { get; set; }

    }
}
