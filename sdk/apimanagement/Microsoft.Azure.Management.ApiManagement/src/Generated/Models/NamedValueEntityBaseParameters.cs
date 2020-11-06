// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// NamedValue Entity Base Parameters set.
    /// </summary>
    public partial class NamedValueEntityBaseParameters
    {
        /// <summary>
        /// Initializes a new instance of the NamedValueEntityBaseParameters
        /// class.
        /// </summary>
        public NamedValueEntityBaseParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NamedValueEntityBaseParameters
        /// class.
        /// </summary>
        /// <param name="tags">Optional tags that when provided can be used to
        /// filter the NamedValue list.</param>
        /// <param name="secret">Determines whether the value is a secret and
        /// should be encrypted or not. Default value is false.</param>
        public NamedValueEntityBaseParameters(IList<string> tags = default(IList<string>), bool? secret = default(bool?))
        {
            Tags = tags;
            Secret = secret;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets optional tags that when provided can be used to filter
        /// the NamedValue list.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }

        /// <summary>
        /// Gets or sets determines whether the value is a secret and should be
        /// encrypted or not. Default value is false.
        /// </summary>
        [JsonProperty(PropertyName = "secret")]
        public bool? Secret { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Tags != null)
            {
                if (Tags.Count > 32)
                {
                    throw new ValidationException(ValidationRules.MaxItems, "Tags", 32);
                }
            }
        }
    }
}
