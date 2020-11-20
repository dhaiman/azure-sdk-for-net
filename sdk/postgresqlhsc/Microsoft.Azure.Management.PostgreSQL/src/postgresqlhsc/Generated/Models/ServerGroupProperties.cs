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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The properties used to create a new server group.
    /// </summary>
    public partial class ServerGroupProperties
    {
        /// <summary>
        /// Initializes a new instance of the ServerGroupProperties class.
        /// </summary>
        public ServerGroupProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerGroupProperties class.
        /// </summary>
        /// <param name="administratorLogin">The administrator's login name of
        /// servers in server group. Can only be specified when the server is
        /// being created (and is required for creation).</param>
        /// <param name="backupRetentionDays">The backup retention days for
        /// server group.</param>
        /// <param name="version">The version of servers. Possible values
        /// include: '11', '12'</param>
        /// <param name="citusVersion">The citus version of servers. Possible
        /// values include: '8.3', '9.0', '9.1', '9.2', '9.3', '9.4',
        /// '9.5'</param>
        /// <param name="isMx">If zfs is enabled or not for the server
        /// group.</param>
        /// <param name="isZfs">If zfs is enabled or not for the server
        /// group.</param>
        /// <param name="state">A state of a server group that is visible to
        /// user. Possible values include: 'Ready', 'Dropping', 'Disabled',
        /// 'Starting', 'Stopping', 'Stopped', 'Updating'</param>
        /// <param name="earliestRestoreTime">The earliest restore point time
        /// (ISO8601 format) for server group.</param>
        /// <param name="resourceProviderType">The resource provider type of
        /// server group. Possible values include: 'Meru', 'Marlin'</param>
        /// <param name="vnetInjArgs">The vnet injection arguments for server
        /// group.</param>
        /// <param name="serverRoleGroups">The list of server role
        /// groups.</param>
        public ServerGroupProperties(string administratorLogin = default(string), int? backupRetentionDays = default(int?), string version = default(string), string citusVersion = default(string), bool? isMx = default(bool?), bool? isZfs = default(bool?), string state = default(string), System.DateTime? earliestRestoreTime = default(System.DateTime?), string resourceProviderType = default(string), VnetInjArgs vnetInjArgs = default(VnetInjArgs), IList<ServerRoleGroup> serverRoleGroups = default(IList<ServerRoleGroup>))
        {
            AdministratorLogin = administratorLogin;
            BackupRetentionDays = backupRetentionDays;
            Version = version;
            CitusVersion = citusVersion;
            IsMx = isMx;
            IsZfs = isZfs;
            State = state;
            EarliestRestoreTime = earliestRestoreTime;
            ResourceProviderType = resourceProviderType;
            VnetInjArgs = vnetInjArgs;
            ServerRoleGroups = serverRoleGroups;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the administrator's login name of servers in server
        /// group. Can only be specified when the server is being created (and
        /// is required for creation).
        /// </summary>
        [JsonProperty(PropertyName = "administratorLogin")]
        public string AdministratorLogin { get; set; }

        /// <summary>
        /// Gets or sets the backup retention days for server group.
        /// </summary>
        [JsonProperty(PropertyName = "backupRetentionDays")]
        public int? BackupRetentionDays { get; set; }

        /// <summary>
        /// Gets or sets the version of servers. Possible values include: '11',
        /// '12'
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the citus version of servers. Possible values include:
        /// '8.3', '9.0', '9.1', '9.2', '9.3', '9.4', '9.5'
        /// </summary>
        [JsonProperty(PropertyName = "citusVersion")]
        public string CitusVersion { get; set; }

        /// <summary>
        /// Gets or sets if zfs is enabled or not for the server group.
        /// </summary>
        [JsonProperty(PropertyName = "isMx")]
        public bool? IsMx { get; set; }

        /// <summary>
        /// Gets or sets if zfs is enabled or not for the server group.
        /// </summary>
        [JsonProperty(PropertyName = "isZfs")]
        public bool? IsZfs { get; set; }

        /// <summary>
        /// Gets or sets a state of a server group that is visible to user.
        /// Possible values include: 'Ready', 'Dropping', 'Disabled',
        /// 'Starting', 'Stopping', 'Stopped', 'Updating'
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// Gets the earliest restore point time (ISO8601 format) for server
        /// group.
        /// </summary>
        [JsonProperty(PropertyName = "earliestRestoreTime")]
        public System.DateTime? EarliestRestoreTime { get; private set; }

        /// <summary>
        /// Gets or sets the resource provider type of server group. Possible
        /// values include: 'Meru', 'Marlin'
        /// </summary>
        [JsonProperty(PropertyName = "resourceProviderType")]
        public string ResourceProviderType { get; set; }

        /// <summary>
        /// Gets or sets the vnet injection arguments for server group.
        /// </summary>
        [JsonProperty(PropertyName = "vnetInjArgs")]
        public VnetInjArgs VnetInjArgs { get; set; }

        /// <summary>
        /// Gets or sets the list of server role groups.
        /// </summary>
        [JsonProperty(PropertyName = "serverRoleGroups")]
        public IList<ServerRoleGroup> ServerRoleGroups { get; set; }

    }
}
