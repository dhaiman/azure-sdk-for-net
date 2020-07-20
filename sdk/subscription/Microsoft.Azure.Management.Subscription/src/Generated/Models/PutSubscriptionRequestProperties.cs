// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Subscription.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Put subscription properties.
    /// </summary>
    public partial class PutSubscriptionRequestProperties
    {
        /// <summary>
        /// Initializes a new instance of the PutSubscriptionRequestProperties
        /// class.
        /// </summary>
        public PutSubscriptionRequestProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PutSubscriptionRequestProperties
        /// class.
        /// </summary>
        /// <param name="displayName">The friendly name of the
        /// subscription.</param>
        /// <param name="skuId">The SKU ID of the Azure plan. Azure plan
        /// determines the pricing and service-level agreement of the
        /// subscription. Use 0001 for Microsoft Azure Plan and 0002 for
        /// Microsoft Azure Plan for DevTest.</param>
        /// <param name="billingScope">Determines customerLed / fieldLed
        /// (/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/invoiceSections/{invoiceSectionId}),
        /// partnerLed
        /// (/billingAccounts/{billingAccountId}/customers/{customerId}).</param>
        /// <param name="initialOwnerPrincipalId">Initial owner principal
        /// Id.</param>
        /// <param name="initialOwnerTenantId">Initial owner tenant Id.</param>
        public PutSubscriptionRequestProperties(string displayName, string skuId, string billingScope, string initialOwnerPrincipalId = default(string), string initialOwnerTenantId = default(string))
        {
            DisplayName = displayName;
            SkuId = skuId;
            BillingScope = billingScope;
            InitialOwnerPrincipalId = initialOwnerPrincipalId;
            InitialOwnerTenantId = initialOwnerTenantId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the friendly name of the subscription.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the SKU ID of the Azure plan. Azure plan determines
        /// the pricing and service-level agreement of the subscription. Use
        /// 0001 for Microsoft Azure Plan and 0002 for Microsoft Azure Plan for
        /// DevTest.
        /// </summary>
        [JsonProperty(PropertyName = "skuId")]
        public string SkuId { get; set; }

        /// <summary>
        /// Gets or sets determines customerLed / fieldLed
        /// (/billingAccounts/{billingAccountId}/billingProfiles/{billingProfileId}/invoiceSections/{invoiceSectionId}),
        /// partnerLed
        /// (/billingAccounts/{billingAccountId}/customers/{customerId}).
        /// </summary>
        [JsonProperty(PropertyName = "billingScope")]
        public string BillingScope { get; set; }

        /// <summary>
        /// Gets or sets initial owner principal Id.
        /// </summary>
        [JsonProperty(PropertyName = "initialOwnerPrincipalId")]
        public string InitialOwnerPrincipalId { get; set; }

        /// <summary>
        /// Gets or sets initial owner tenant Id.
        /// </summary>
        [JsonProperty(PropertyName = "initialOwnerTenantId")]
        public string InitialOwnerTenantId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (SkuId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SkuId");
            }
            if (BillingScope == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BillingScope");
            }
        }
    }
}
