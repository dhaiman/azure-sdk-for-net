// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Enable Microsoft azure plan
    /// </summary>
    public partial class PolicyPropertiesEnableMicrosoftAzurePlan
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PolicyPropertiesEnableMicrosoftAzurePlan class.
        /// </summary>
        public PolicyPropertiesEnableMicrosoftAzurePlan()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PolicyPropertiesEnableMicrosoftAzurePlan class.
        /// </summary>
        /// <param name="enabled">Specifies whether azure plan is
        /// enabled.</param>
        /// <param name="budgetAmount">Budget amount for policy</param>
        /// <param name="startDate">Start date of policy</param>
        /// <param name="endDate">End date of policy</param>
        /// <param name="externalReferenceId">External reference</param>
        public PolicyPropertiesEnableMicrosoftAzurePlan(bool? enabled = default(bool?), double? budgetAmount = default(double?), System.DateTime? startDate = default(System.DateTime?), System.DateTime? endDate = default(System.DateTime?), string externalReferenceId = default(string))
        {
            Enabled = enabled;
            BudgetAmount = budgetAmount;
            StartDate = startDate;
            EndDate = endDate;
            ExternalReferenceId = externalReferenceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies whether azure plan is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Gets or sets budget amount for policy
        /// </summary>
        [JsonProperty(PropertyName = "budgetAmount")]
        public double? BudgetAmount { get; set; }

        /// <summary>
        /// Gets or sets start date of policy
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// Gets or sets end date of policy
        /// </summary>
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or sets external reference
        /// </summary>
        [JsonProperty(PropertyName = "externalReferenceId")]
        public string ExternalReferenceId { get; set; }

    }
}
