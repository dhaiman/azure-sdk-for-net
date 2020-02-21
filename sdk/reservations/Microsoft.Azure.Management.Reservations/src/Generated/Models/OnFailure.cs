// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The actions for auto quota increase.
    /// </summary>
    public partial class OnFailure
    {
        /// <summary>
        /// Initializes a new instance of the OnFailure class.
        /// </summary>
        public OnFailure()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OnFailure class.
        /// </summary>
        /// <param name="emailActions">The email actions for auto quota
        /// increase.</param>
        /// <param name="phoneActions">The phone actions for auto quota
        /// increase.</param>
        public OnFailure(OnFailureEmailActions emailActions = default(OnFailureEmailActions), OnFailurePhoneActions phoneActions = default(OnFailurePhoneActions))
        {
            EmailActions = emailActions;
            PhoneActions = phoneActions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the email actions for auto quota increase.
        /// </summary>
        [JsonProperty(PropertyName = "emailActions")]
        public OnFailureEmailActions EmailActions { get; set; }

        /// <summary>
        /// Gets or sets the phone actions for auto quota increase.
        /// </summary>
        [JsonProperty(PropertyName = "phoneActions")]
        public OnFailurePhoneActions PhoneActions { get; set; }

    }
}
