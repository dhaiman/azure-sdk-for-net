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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Transformation for data flow sink.
    /// </summary>
    public partial class DataFlowSink : Transformation
    {
        /// <summary>
        /// Initializes a new instance of the DataFlowSink class.
        /// </summary>
        public DataFlowSink()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataFlowSink class.
        /// </summary>
        /// <param name="name">Transformation name.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Transformation description.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="dataset">Dataset reference.</param>
        public DataFlowSink(string name, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), DatasetReference dataset = default(DatasetReference))
            : base(name, additionalProperties, description)
        {
            AdditionalProperties = additionalProperties;
            Dataset = dataset;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unmatched properties from the message are deserialized
        /// this collection
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Gets or sets dataset reference.
        /// </summary>
        [JsonProperty(PropertyName = "dataset")]
        public DatasetReference Dataset { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Dataset != null)
            {
                Dataset.Validate();
            }
        }
    }
}
