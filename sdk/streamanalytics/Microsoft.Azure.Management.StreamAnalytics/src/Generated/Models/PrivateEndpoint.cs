// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Complete information about the private endpoint.
    /// </summary>
    public partial class PrivateEndpoint : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the PrivateEndpoint class.
        /// </summary>
        public PrivateEndpoint()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PrivateEndpoint class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="properties">The properties associated with a private
        /// endpoint.</param>
        /// <param name="etag">Unique opaque string (generally a GUID) that
        /// represents the metadata state of the resource (private endpoint)
        /// and changes whenever the resource is updated. Required on PUT
        /// (CreateOrUpdate) requests.</param>
        public PrivateEndpoint(string id = default(string), string name = default(string), string type = default(string), PrivateEndpointProperties properties = default(PrivateEndpointProperties), string etag = default(string))
            : base(id, name, type)
        {
            Properties = properties;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the properties associated with a private endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public PrivateEndpointProperties Properties { get; set; }

        /// <summary>
        /// Gets unique opaque string (generally a GUID) that represents the
        /// metadata state of the resource (private endpoint) and changes
        /// whenever the resource is updated. Required on PUT (CreateOrUpdate)
        /// requests.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

    }
}
