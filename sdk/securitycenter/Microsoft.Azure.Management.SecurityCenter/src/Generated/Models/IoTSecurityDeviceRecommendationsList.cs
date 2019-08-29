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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// List of aggregated recommendation data, per recommendation type, per
    /// device.
    /// </summary>
    public partial class IoTSecurityDeviceRecommendationsList
    {
        /// <summary>
        /// Initializes a new instance of the
        /// IoTSecurityDeviceRecommendationsList class.
        /// </summary>
        public IoTSecurityDeviceRecommendationsList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// IoTSecurityDeviceRecommendationsList class.
        /// </summary>
        /// <param name="value">List of aggregated recommendation data</param>
        public IoTSecurityDeviceRecommendationsList(IList<IoTSecurityDeviceRecommendation> value)
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of aggregated recommendation data
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<IoTSecurityDeviceRecommendation> Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}
