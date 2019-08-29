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
    /// List of Security analytics of your IoT Security solution
    /// </summary>
    public partial class IoTSecuritySolutionAnalyticsModelList
    {
        /// <summary>
        /// Initializes a new instance of the
        /// IoTSecuritySolutionAnalyticsModelList class.
        /// </summary>
        public IoTSecuritySolutionAnalyticsModelList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// IoTSecuritySolutionAnalyticsModelList class.
        /// </summary>
        /// <param name="value">List of Security analytics of your IoT Security
        /// solution</param>
        /// <param name="nextLink">When there is too much alert data for one
        /// page, use this URI to fetch the next page.</param>
        public IoTSecuritySolutionAnalyticsModelList(IList<IoTSecuritySolutionAnalyticsModel> value, string nextLink = default(string))
        {
            Value = value;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of Security analytics of your IoT Security
        /// solution
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<IoTSecuritySolutionAnalyticsModel> Value { get; set; }

        /// <summary>
        /// Gets when there is too much alert data for one page, use this URI
        /// to fetch the next page.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; private set; }

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
            if (Value != null)
            {
                foreach (var element in Value)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
