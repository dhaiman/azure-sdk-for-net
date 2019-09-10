// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The actual traffic details
    /// </summary>
    public partial class ActualTrafficConnectedResources
    {
        /// <summary>
        /// Initializes a new instance of the ActualTrafficConnectedResources
        /// class.
        /// </summary>
        public ActualTrafficConnectedResources()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActualTrafficConnectedResources
        /// class.
        /// </summary>
        /// <param name="volume">The actual traffic volume between the actual
        /// traffic start time to the actual traffic end time</param>
        public ActualTrafficConnectedResources(string volume = default(string), IList<ConnectionDetails> connectionsDetails = default(IList<ConnectionDetails>))
        {
            Volume = volume;
            ConnectionsDetails = connectionsDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the actual traffic volume between the actual traffic start
        /// time to the actual traffic end time
        /// </summary>
        [JsonProperty(PropertyName = "volume")]
        public string Volume { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "connectionsDetails")]
        public IList<ConnectionDetails> ConnectionsDetails { get; set; }

    }
}
