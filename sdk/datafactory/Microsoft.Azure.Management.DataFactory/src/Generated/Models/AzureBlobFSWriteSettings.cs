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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Azure blobFS write settings.
    /// </summary>
    public partial class AzureBlobFSWriteSettings : StoreWriteSettings
    {
        /// <summary>
        /// Initializes a new instance of the AzureBlobFSWriteSettings class.
        /// </summary>
        public AzureBlobFSWriteSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureBlobFSWriteSettings class.
        /// </summary>
        /// <param name="type">The write setting type.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="maxConcurrentConnections">The maximum concurrent
        /// connection count for the source data store. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="copyBehavior">The type of copy behavior for copy
        /// sink.</param>
        public AzureBlobFSWriteSettings(string type, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object maxConcurrentConnections = default(object), object copyBehavior = default(object))
            : base(type, additionalProperties, maxConcurrentConnections, copyBehavior)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
