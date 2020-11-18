// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Self-hosted integration runtime status.
    /// </summary>
    [Newtonsoft.Json.JsonObject("SelfHosted")]
    [Rest.Serialization.JsonTransformation]
    public partial class SelfHostedIntegrationRuntimeStatus : IntegrationRuntimeStatus
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SelfHostedIntegrationRuntimeStatus class.
        /// </summary>
        public SelfHostedIntegrationRuntimeStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SelfHostedIntegrationRuntimeStatus class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="dataFactoryName">The workspace name which the
        /// integration runtime belong to.</param>
        /// <param name="state">The state of integration runtime. Possible
        /// values include: 'Initial', 'Stopped', 'Started', 'Starting',
        /// 'Stopping', 'NeedRegistration', 'Online', 'Limited', 'Offline',
        /// 'AccessDenied'</param>
        /// <param name="createTime">The time at which the integration runtime
        /// was created, in ISO8601 format.</param>
        /// <param name="taskQueueId">The task queue id of the integration
        /// runtime.</param>
        /// <param name="nodeCommunicationChannelEncryptionMode">The node
        /// communication Channel encryption mode</param>
        /// <param name="internalChannelEncryption">It is used to set the
        /// encryption mode for node-node communication channel (when more than
        /// 2 self-hosted integration runtime nodes exist). Possible values
        /// include: 'NotSet', 'SslEncrypted', 'NotEncrypted'</param>
        /// <param name="version">Version of the integration runtime.</param>
        /// <param name="nodes">The list of nodes for this integration
        /// runtime.</param>
        /// <param name="scheduledUpdateDate">The date at which the integration
        /// runtime will be scheduled to update, in ISO8601 format.</param>
        /// <param name="updateDelayOffset">The time in the date scheduled by
        /// service to update the integration runtime, e.g., PT03H is 3
        /// hours</param>
        /// <param name="localTimeZoneOffset">The local time zone offset in
        /// hours.</param>
        /// <param name="capabilities">Object with additional information about
        /// integration runtime capabilities.</param>
        /// <param name="serviceUrls">The URLs for the services used in
        /// integration runtime backend service.</param>
        /// <param name="autoUpdate">Whether Self-hosted integration runtime
        /// auto update has been turned on. Possible values include: 'On',
        /// 'Off'</param>
        /// <param name="versionStatus">Status of the integration runtime
        /// version.</param>
        /// <param name="links">The list of linked integration runtimes that
        /// are created to share with this integration runtime.</param>
        /// <param name="pushedVersion">The version that the integration
        /// runtime is going to update to.</param>
        /// <param name="latestVersion">The latest version on download
        /// center.</param>
        /// <param name="autoUpdateETA">The estimated time when the self-hosted
        /// integration runtime will be updated.</param>
        public SelfHostedIntegrationRuntimeStatus(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string dataFactoryName = default(string), string state = default(string), System.DateTime? createTime = default(System.DateTime?), string taskQueueId = default(string), string nodeCommunicationChannelEncryptionMode = default(string), string internalChannelEncryption = default(string), string version = default(string), IList<SelfHostedIntegrationRuntimeNode> nodes = default(IList<SelfHostedIntegrationRuntimeNode>), System.DateTime? scheduledUpdateDate = default(System.DateTime?), string updateDelayOffset = default(string), string localTimeZoneOffset = default(string), IDictionary<string, string> capabilities = default(IDictionary<string, string>), IList<string> serviceUrls = default(IList<string>), string autoUpdate = default(string), string versionStatus = default(string), IList<LinkedIntegrationRuntime> links = default(IList<LinkedIntegrationRuntime>), string pushedVersion = default(string), string latestVersion = default(string), System.DateTime? autoUpdateETA = default(System.DateTime?))
            : base(additionalProperties, dataFactoryName, state)
        {
            CreateTime = createTime;
            TaskQueueId = taskQueueId;
            NodeCommunicationChannelEncryptionMode = nodeCommunicationChannelEncryptionMode;
            InternalChannelEncryption = internalChannelEncryption;
            Version = version;
            Nodes = nodes;
            ScheduledUpdateDate = scheduledUpdateDate;
            UpdateDelayOffset = updateDelayOffset;
            LocalTimeZoneOffset = localTimeZoneOffset;
            Capabilities = capabilities;
            ServiceUrls = serviceUrls;
            AutoUpdate = autoUpdate;
            VersionStatus = versionStatus;
            Links = links;
            PushedVersion = pushedVersion;
            LatestVersion = latestVersion;
            AutoUpdateETA = autoUpdateETA;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the time at which the integration runtime was created, in
        /// ISO8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.createTime")]
        public System.DateTime? CreateTime { get; private set; }

        /// <summary>
        /// Gets the task queue id of the integration runtime.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.taskQueueId")]
        public string TaskQueueId { get; private set; }

        /// <summary>
        /// Gets the node communication Channel encryption mode
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.nodeCommunicationChannelEncryptionMode")]
        public string NodeCommunicationChannelEncryptionMode { get; private set; }

        /// <summary>
        /// Gets it is used to set the encryption mode for node-node
        /// communication channel (when more than 2 self-hosted integration
        /// runtime nodes exist). Possible values include: 'NotSet',
        /// 'SslEncrypted', 'NotEncrypted'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.internalChannelEncryption")]
        public string InternalChannelEncryption { get; private set; }

        /// <summary>
        /// Gets version of the integration runtime.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.version")]
        public string Version { get; private set; }

        /// <summary>
        /// Gets or sets the list of nodes for this integration runtime.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.nodes")]
        public IList<SelfHostedIntegrationRuntimeNode> Nodes { get; set; }

        /// <summary>
        /// Gets the date at which the integration runtime will be scheduled to
        /// update, in ISO8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.scheduledUpdateDate")]
        public System.DateTime? ScheduledUpdateDate { get; private set; }

        /// <summary>
        /// Gets the time in the date scheduled by service to update the
        /// integration runtime, e.g., PT03H is 3 hours
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.updateDelayOffset")]
        public string UpdateDelayOffset { get; private set; }

        /// <summary>
        /// Gets the local time zone offset in hours.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.localTimeZoneOffset")]
        public string LocalTimeZoneOffset { get; private set; }

        /// <summary>
        /// Gets object with additional information about integration runtime
        /// capabilities.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.capabilities")]
        public IDictionary<string, string> Capabilities { get; private set; }

        /// <summary>
        /// Gets the URLs for the services used in integration runtime backend
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.serviceUrls")]
        public IList<string> ServiceUrls { get; private set; }

        /// <summary>
        /// Gets whether Self-hosted integration runtime auto update has been
        /// turned on. Possible values include: 'On', 'Off'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.autoUpdate")]
        public string AutoUpdate { get; private set; }

        /// <summary>
        /// Gets status of the integration runtime version.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.versionStatus")]
        public string VersionStatus { get; private set; }

        /// <summary>
        /// Gets or sets the list of linked integration runtimes that are
        /// created to share with this integration runtime.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.links")]
        public IList<LinkedIntegrationRuntime> Links { get; set; }

        /// <summary>
        /// Gets the version that the integration runtime is going to update
        /// to.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.pushedVersion")]
        public string PushedVersion { get; private set; }

        /// <summary>
        /// Gets the latest version on download center.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.latestVersion")]
        public string LatestVersion { get; private set; }

        /// <summary>
        /// Gets the estimated time when the self-hosted integration runtime
        /// will be updated.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.autoUpdateETA")]
        public System.DateTime? AutoUpdateETA { get; private set; }

    }
}
