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
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A product.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Product : Resource
    {
        /// <summary>
        /// Initializes a new instance of the Product class.
        /// </summary>
        public Product()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Product class.
        /// </summary>
        /// <param name="id">Resource Id.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="displayName">The display name of the product.</param>
        /// <param name="purchaseDate">The date when the product was
        /// purchased.</param>
        /// <param name="productTypeId">The ID of the type of product.</param>
        /// <param name="productType">The description of the type of
        /// product.</param>
        /// <param name="status">The current status of the product. Possible
        /// values include: 'Active', 'Inactive', 'PastDue', 'Expiring',
        /// 'Expired', 'Disabled', 'Cancelled', 'AutoRenew'</param>
        /// <param name="endDate">The date when the product will be renewed or
        /// canceled.</param>
        /// <param name="billingFrequency">The frequency at which the product
        /// will be billed. Possible values include: 'OneTime', 'Monthly',
        /// 'UsageBased'</param>
        /// <param name="lastCharge">The last month charges.</param>
        /// <param name="lastChargeDate">The date of the last charge.</param>
        /// <param name="quantity">The quantity purchased for the
        /// product.</param>
        /// <param name="skuId">The sku ID of the product.</param>
        /// <param name="skuDescription">The sku description of the
        /// product.</param>
        /// <param name="tenantId">The id of the tenant in which the product is
        /// used.</param>
        /// <param name="availabilityId">The availability of the
        /// product.</param>
        /// <param name="parentProductId">Parent product Id.</param>
        /// <param name="invoiceSectionId">The ID of the invoice section to
        /// which the product is billed.</param>
        /// <param name="invoiceSectionDisplayName">The name of the invoice
        /// section to which the product is billed.</param>
        /// <param name="billingProfileId">The ID of the billing profile to
        /// which the product is billed.</param>
        /// <param name="billingProfileDisplayName">The name of the billing
        /// profile to which the product is billed.</param>
        /// <param name="customerId">The ID of the customer for whom the
        /// product was purchased. The field is applicable only for Microsoft
        /// Partner Agreement billing account.</param>
        /// <param name="customerDisplayName">The name of the customer for whom
        /// the product was purchased. The field is applicable only for
        /// Microsoft Partner Agreement billing account.</param>
        /// <param name="reseller">Reseller for this product.</param>
        public Product(string id = default(string), string name = default(string), string type = default(string), string displayName = default(string), System.DateTime? purchaseDate = default(System.DateTime?), string productTypeId = default(string), string productType = default(string), string status = default(string), System.DateTime? endDate = default(System.DateTime?), string billingFrequency = default(string), Amount lastCharge = default(Amount), System.DateTime? lastChargeDate = default(System.DateTime?), double? quantity = default(double?), string skuId = default(string), string skuDescription = default(string), string tenantId = default(string), string availabilityId = default(string), string parentProductId = default(string), string invoiceSectionId = default(string), string invoiceSectionDisplayName = default(string), string billingProfileId = default(string), string billingProfileDisplayName = default(string), string customerId = default(string), string customerDisplayName = default(string), Reseller reseller = default(Reseller))
            : base(id, name, type)
        {
            DisplayName = displayName;
            PurchaseDate = purchaseDate;
            ProductTypeId = productTypeId;
            ProductType = productType;
            Status = status;
            EndDate = endDate;
            BillingFrequency = billingFrequency;
            LastCharge = lastCharge;
            LastChargeDate = lastChargeDate;
            Quantity = quantity;
            SkuId = skuId;
            SkuDescription = skuDescription;
            TenantId = tenantId;
            AvailabilityId = availabilityId;
            ParentProductId = parentProductId;
            InvoiceSectionId = invoiceSectionId;
            InvoiceSectionDisplayName = invoiceSectionDisplayName;
            BillingProfileId = billingProfileId;
            BillingProfileDisplayName = billingProfileDisplayName;
            CustomerId = customerId;
            CustomerDisplayName = customerDisplayName;
            Reseller = reseller;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the display name of the product.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets the date when the product was purchased.
        /// </summary>
        [JsonProperty(PropertyName = "properties.purchaseDate")]
        public System.DateTime? PurchaseDate { get; private set; }

        /// <summary>
        /// Gets the ID of the type of product.
        /// </summary>
        [JsonProperty(PropertyName = "properties.productTypeId")]
        public string ProductTypeId { get; private set; }

        /// <summary>
        /// Gets the description of the type of product.
        /// </summary>
        [JsonProperty(PropertyName = "properties.productType")]
        public string ProductType { get; private set; }

        /// <summary>
        /// Gets or sets the current status of the product. Possible values
        /// include: 'Active', 'Inactive', 'PastDue', 'Expiring', 'Expired',
        /// 'Disabled', 'Cancelled', 'AutoRenew'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets the date when the product will be renewed or canceled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endDate")]
        public System.DateTime? EndDate { get; private set; }

        /// <summary>
        /// Gets or sets the frequency at which the product will be billed.
        /// Possible values include: 'OneTime', 'Monthly', 'UsageBased'
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingFrequency")]
        public string BillingFrequency { get; set; }

        /// <summary>
        /// Gets the last month charges.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastCharge")]
        public Amount LastCharge { get; private set; }

        /// <summary>
        /// Gets the date of the last charge.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastChargeDate")]
        public System.DateTime? LastChargeDate { get; private set; }

        /// <summary>
        /// Gets the quantity purchased for the product.
        /// </summary>
        [JsonProperty(PropertyName = "properties.quantity")]
        public double? Quantity { get; private set; }

        /// <summary>
        /// Gets the sku ID of the product.
        /// </summary>
        [JsonProperty(PropertyName = "properties.skuId")]
        public string SkuId { get; private set; }

        /// <summary>
        /// Gets the sku description of the product.
        /// </summary>
        [JsonProperty(PropertyName = "properties.skuDescription")]
        public string SkuDescription { get; private set; }

        /// <summary>
        /// Gets the id of the tenant in which the product is used.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tenantId")]
        public string TenantId { get; private set; }

        /// <summary>
        /// Gets the availability of the product.
        /// </summary>
        [JsonProperty(PropertyName = "properties.availabilityId")]
        public string AvailabilityId { get; private set; }

        /// <summary>
        /// Gets parent product Id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.parentProductId")]
        public string ParentProductId { get; private set; }

        /// <summary>
        /// Gets the ID of the invoice section to which the product is billed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceSectionId")]
        public string InvoiceSectionId { get; private set; }

        /// <summary>
        /// Gets the name of the invoice section to which the product is
        /// billed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.invoiceSectionDisplayName")]
        public string InvoiceSectionDisplayName { get; private set; }

        /// <summary>
        /// Gets the ID of the billing profile to which the product is billed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingProfileId")]
        public string BillingProfileId { get; private set; }

        /// <summary>
        /// Gets the name of the billing profile to which the product is
        /// billed.
        /// </summary>
        [JsonProperty(PropertyName = "properties.billingProfileDisplayName")]
        public string BillingProfileDisplayName { get; private set; }

        /// <summary>
        /// Gets the ID of the customer for whom the product was purchased. The
        /// field is applicable only for Microsoft Partner Agreement billing
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customerId")]
        public string CustomerId { get; private set; }

        /// <summary>
        /// Gets the name of the customer for whom the product was purchased.
        /// The field is applicable only for Microsoft Partner Agreement
        /// billing account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customerDisplayName")]
        public string CustomerDisplayName { get; private set; }

        /// <summary>
        /// Gets reseller for this product.
        /// </summary>
        [JsonProperty(PropertyName = "properties.reseller")]
        public Reseller Reseller { get; private set; }

    }
}
