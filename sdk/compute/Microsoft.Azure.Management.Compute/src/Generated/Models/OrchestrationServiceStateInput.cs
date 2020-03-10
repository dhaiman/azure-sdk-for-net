// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class OrchestrationServiceStateInput
    {
        /// <summary>
        /// Initializes a new instance of the OrchestrationServiceStateInput
        /// class.
        /// </summary>
        public OrchestrationServiceStateInput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OrchestrationServiceStateInput
        /// class.
        /// </summary>
        /// <param name="action">The action to be performed. Possible values
        /// include: 'Resume', 'Suspend'</param>
        public OrchestrationServiceStateInput(string action)
        {
            Action = action;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for OrchestrationServiceStateInput class.
        /// </summary>
        static OrchestrationServiceStateInput()
        {
            ServiceName = "AutomaticRepairs";
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the action to be performed. Possible values include:
        /// 'Resume', 'Suspend'
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public string Action { get; set; }

        /// <summary>
        /// The name of the service.
        /// </summary>
        [JsonProperty(PropertyName = "serviceName")]
        public static string ServiceName { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Action == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Action");
            }
        }
    }
}
