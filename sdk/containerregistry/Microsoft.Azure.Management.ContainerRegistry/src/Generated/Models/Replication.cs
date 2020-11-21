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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An object that represents a replication for a container registry.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Replication : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Replication class.
        /// </summary>
        public Replication()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Replication class.
        /// </summary>
        /// <param name="location">The location of the resource. This cannot be
        /// changed after the resource is created.</param>
        /// <param name="id">The resource ID.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="tags">The tags of the resource.</param>
        /// <param name="systemData">Metadata pertaining to creation and last
        /// modification of the resource.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// replication at the time the operation was called. Possible values
        /// include: 'Creating', 'Updating', 'Deleting', 'Succeeded', 'Failed',
        /// 'Canceled'</param>
        /// <param name="status">The status of the replication at the time the
        /// operation was called.</param>
        /// <param name="regionEndpointEnabled">Specifies whether the
        /// replication's regional endpoint is enabled. Requests will not be
        /// routed to a replication whose regional endpoint is disabled,
        /// however its data will continue to be synced with other
        /// replications.</param>
        /// <param name="zoneRedundancy">Whether or not zone redundancy is
        /// enabled for this container registry replication. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        public Replication(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), SystemData systemData = default(SystemData), string provisioningState = default(string), Status status = default(Status), bool? regionEndpointEnabled = default(bool?), string zoneRedundancy = default(string))
            : base(location, id, name, type, tags, systemData)
        {
            ProvisioningState = provisioningState;
            Status = status;
            RegionEndpointEnabled = regionEndpointEnabled;
            ZoneRedundancy = zoneRedundancy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the provisioning state of the replication at the time the
        /// operation was called. Possible values include: 'Creating',
        /// 'Updating', 'Deleting', 'Succeeded', 'Failed', 'Canceled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the status of the replication at the time the operation was
        /// called.
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public Status Status { get; private set; }

        /// <summary>
        /// Gets or sets specifies whether the replication's regional endpoint
        /// is enabled. Requests will not be routed to a replication whose
        /// regional endpoint is disabled, however its data will continue to be
        /// synced with other replications.
        /// </summary>
        [JsonProperty(PropertyName = "properties.regionEndpointEnabled")]
        public bool? RegionEndpointEnabled { get; set; }

        /// <summary>
        /// Gets or sets whether or not zone redundancy is enabled for this
        /// container registry replication. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.zoneRedundancy")]
        public string ZoneRedundancy { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
