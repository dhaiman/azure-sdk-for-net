// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Bing.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Specifications of the Dimension of metrics
    /// </summary>
    public partial class MetricDimension
    {
        /// <summary>
        /// Initializes a new instance of the MetricDimension class.
        /// </summary>
        public MetricDimension()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricDimension class.
        /// </summary>
        /// <param name="name">Name of the dimension</param>
        /// <param name="displayName">Localized friendly display name of the
        /// dimension</param>
        public MetricDimension(string name = default(string), string displayName = default(string))
        {
            Name = name;
            DisplayName = displayName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the dimension
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets localized friendly display name of the dimension
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

    }
}
