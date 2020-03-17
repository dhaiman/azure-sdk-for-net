// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class AutoScaleSkuCollection
    {
        /// <summary>
        /// Initializes a new instance of the AutoScaleSkuCollection class.
        /// </summary>
        public AutoScaleSkuCollection()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AutoScaleSkuCollection class.
        /// </summary>
        /// <param name="value">Collection of supported Skus</param>
        public AutoScaleSkuCollection(IList<AutoScaleSku> value = default(IList<AutoScaleSku>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets collection of supported Skus
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<AutoScaleSku> Value { get; set; }

    }
}
