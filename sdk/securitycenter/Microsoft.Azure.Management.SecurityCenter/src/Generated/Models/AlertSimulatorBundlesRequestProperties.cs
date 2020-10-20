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
    /// Simulate alerts according to this bundles.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Bundles")]
    public partial class AlertSimulatorBundlesRequestProperties : AlertSimulatorRequestProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AlertSimulatorBundlesRequestProperties class.
        /// </summary>
        public AlertSimulatorBundlesRequestProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AlertSimulatorBundlesRequestProperties class.
        /// </summary>
        /// <param name="bundles">Bundles list.</param>
        public AlertSimulatorBundlesRequestProperties(IList<string> bundles = default(IList<string>))
        {
            Bundles = bundles;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets bundles list.
        /// </summary>
        [JsonProperty(PropertyName = "bundles")]
        public IList<string> Bundles { get; set; }

    }
}
