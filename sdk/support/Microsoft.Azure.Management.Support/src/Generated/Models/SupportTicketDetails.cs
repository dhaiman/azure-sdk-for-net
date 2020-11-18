// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Support.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Object that represents SupportTicketDetails resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class SupportTicketDetails : IResource
    {
        /// <summary>
        /// Initializes a new instance of the SupportTicketDetails class.
        /// </summary>
        public SupportTicketDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SupportTicketDetails class.
        /// </summary>
        /// <param name="description">Detailed description of the question or
        /// issue.</param>
        /// <param name="problemClassificationId">Each Azure service has its
        /// own set of issue categories, also known as problem classification.
        /// This parameter is the unique Id for the type of problem you are
        /// experiencing.</param>
        /// <param name="severity">A value that indicates the urgency of the
        /// case, which in turn determines the response time according to the
        /// service level agreement of the technical support plan you have with
        /// Azure. Note: 'Highest critical impact', also known as the
        /// 'Emergency - Severe impact' level in the Azure portal is reserved
        /// only for our Premium customers. Possible values include: 'minimal',
        /// 'moderate', 'critical', 'highestcriticalimpact'</param>
        /// <param name="contactDetails">Contact information of the user
        /// requesting to create a support ticket.</param>
        /// <param name="title">Title of the support ticket.</param>
        /// <param name="serviceId">This is the resource Id of the Azure
        /// service resource associated with the support ticket.</param>
        /// <param name="id">Id of the resource.</param>
        /// <param name="name">Name of the resource.</param>
        /// <param name="type">Type of the resource
        /// 'Microsoft.Support/supportTickets'.</param>
        /// <param name="supportTicketId">System generated support ticket Id
        /// that is unique.</param>
        /// <param name="problemClassificationDisplayName">Localized name of
        /// problem classification.</param>
        /// <param name="enrollmentId">Enrollment Id associated with the
        /// support ticket.</param>
        /// <param name="require24X7Response">Indicates if this requires a 24x7
        /// response from Azure.</param>
        /// <param name="serviceLevelAgreement">Service Level Agreement
        /// information for this support ticket.</param>
        /// <param name="supportEngineer">Information about the support
        /// engineer working on this support ticket.</param>
        /// <param name="supportPlanType">Support plan type associated with the
        /// support ticket.</param>
        /// <param name="problemStartTime">Time in UTC (ISO 8601 format) when
        /// the problem started.</param>
        /// <param name="serviceDisplayName">Localized name of the Azure
        /// service.</param>
        /// <param name="status">Status of the support ticket.</param>
        /// <param name="createdDate">Time in UTC (ISO 8601 format) when the
        /// support ticket was created.</param>
        /// <param name="modifiedDate">Time in UTC (ISO 8601 format) when the
        /// support ticket was last modified.</param>
        /// <param name="technicalTicketDetails">Additional ticket details
        /// associated with a technical support ticket request.</param>
        /// <param name="quotaTicketDetails">Additional ticket details
        /// associated with a quota support ticket request.</param>
        public SupportTicketDetails(string description, string problemClassificationId, string severity, ContactProfile contactDetails, string title, string serviceId, string id = default(string), string name = default(string), string type = default(string), string supportTicketId = default(string), string problemClassificationDisplayName = default(string), string enrollmentId = default(string), bool? require24X7Response = default(bool?), ServiceLevelAgreement serviceLevelAgreement = default(ServiceLevelAgreement), SupportEngineer supportEngineer = default(SupportEngineer), string supportPlanType = default(string), System.DateTime? problemStartTime = default(System.DateTime?), string serviceDisplayName = default(string), string status = default(string), System.DateTime? createdDate = default(System.DateTime?), System.DateTime? modifiedDate = default(System.DateTime?), TechnicalTicketDetails technicalTicketDetails = default(TechnicalTicketDetails), QuotaTicketDetails quotaTicketDetails = default(QuotaTicketDetails))
        {
            Id = id;
            Name = name;
            Type = type;
            SupportTicketId = supportTicketId;
            Description = description;
            ProblemClassificationId = problemClassificationId;
            ProblemClassificationDisplayName = problemClassificationDisplayName;
            Severity = severity;
            EnrollmentId = enrollmentId;
            Require24X7Response = require24X7Response;
            ContactDetails = contactDetails;
            ServiceLevelAgreement = serviceLevelAgreement;
            SupportEngineer = supportEngineer;
            SupportPlanType = supportPlanType;
            Title = title;
            ProblemStartTime = problemStartTime;
            ServiceId = serviceId;
            ServiceDisplayName = serviceDisplayName;
            Status = status;
            CreatedDate = createdDate;
            ModifiedDate = modifiedDate;
            TechnicalTicketDetails = technicalTicketDetails;
            QuotaTicketDetails = quotaTicketDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets id of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets type of the resource 'Microsoft.Support/supportTickets'.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets system generated support ticket Id that is unique.
        /// </summary>
        [JsonProperty(PropertyName = "properties.supportTicketId")]
        public string SupportTicketId { get; set; }

        /// <summary>
        /// Gets or sets detailed description of the question or issue.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets each Azure service has its own set of issue
        /// categories, also known as problem classification. This parameter is
        /// the unique Id for the type of problem you are experiencing.
        /// </summary>
        [JsonProperty(PropertyName = "properties.problemClassificationId")]
        public string ProblemClassificationId { get; set; }

        /// <summary>
        /// Gets localized name of problem classification.
        /// </summary>
        [JsonProperty(PropertyName = "properties.problemClassificationDisplayName")]
        public string ProblemClassificationDisplayName { get; private set; }

        /// <summary>
        /// Gets or sets a value that indicates the urgency of the case, which
        /// in turn determines the response time according to the service level
        /// agreement of the technical support plan you have with Azure. Note:
        /// 'Highest critical impact', also known as the 'Emergency - Severe
        /// impact' level in the Azure portal is reserved only for our Premium
        /// customers. Possible values include: 'minimal', 'moderate',
        /// 'critical', 'highestcriticalimpact'
        /// </summary>
        [JsonProperty(PropertyName = "properties.severity")]
        public string Severity { get; set; }

        /// <summary>
        /// Gets enrollment Id associated with the support ticket.
        /// </summary>
        [JsonProperty(PropertyName = "properties.enrollmentId")]
        public string EnrollmentId { get; private set; }

        /// <summary>
        /// Gets or sets indicates if this requires a 24x7 response from Azure.
        /// </summary>
        [JsonProperty(PropertyName = "properties.require24X7Response")]
        public bool? Require24X7Response { get; set; }

        /// <summary>
        /// Gets or sets contact information of the user requesting to create a
        /// support ticket.
        /// </summary>
        [JsonProperty(PropertyName = "properties.contactDetails")]
        public ContactProfile ContactDetails { get; set; }

        /// <summary>
        /// Gets or sets service Level Agreement information for this support
        /// ticket.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceLevelAgreement")]
        public ServiceLevelAgreement ServiceLevelAgreement { get; set; }

        /// <summary>
        /// Gets or sets information about the support engineer working on this
        /// support ticket.
        /// </summary>
        [JsonProperty(PropertyName = "properties.supportEngineer")]
        public SupportEngineer SupportEngineer { get; set; }

        /// <summary>
        /// Gets support plan type associated with the support ticket.
        /// </summary>
        [JsonProperty(PropertyName = "properties.supportPlanType")]
        public string SupportPlanType { get; private set; }

        /// <summary>
        /// Gets or sets title of the support ticket.
        /// </summary>
        [JsonProperty(PropertyName = "properties.title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets time in UTC (ISO 8601 format) when the problem
        /// started.
        /// </summary>
        [JsonProperty(PropertyName = "properties.problemStartTime")]
        public System.DateTime? ProblemStartTime { get; set; }

        /// <summary>
        /// Gets or sets this is the resource Id of the Azure service resource
        /// associated with the support ticket.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceId")]
        public string ServiceId { get; set; }

        /// <summary>
        /// Gets localized name of the Azure service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceDisplayName")]
        public string ServiceDisplayName { get; private set; }

        /// <summary>
        /// Gets status of the support ticket.
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets time in UTC (ISO 8601 format) when the support ticket was
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdDate")]
        public System.DateTime? CreatedDate { get; private set; }

        /// <summary>
        /// Gets time in UTC (ISO 8601 format) when the support ticket was last
        /// modified.
        /// </summary>
        [JsonProperty(PropertyName = "properties.modifiedDate")]
        public System.DateTime? ModifiedDate { get; private set; }

        /// <summary>
        /// Gets or sets additional ticket details associated with a technical
        /// support ticket request.
        /// </summary>
        [JsonProperty(PropertyName = "properties.technicalTicketDetails")]
        public TechnicalTicketDetails TechnicalTicketDetails { get; set; }

        /// <summary>
        /// Gets or sets additional ticket details associated with a quota
        /// support ticket request.
        /// </summary>
        [JsonProperty(PropertyName = "properties.quotaTicketDetails")]
        public QuotaTicketDetails QuotaTicketDetails { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Description == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Description");
            }
            if (ProblemClassificationId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProblemClassificationId");
            }
            if (Severity == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Severity");
            }
            if (ContactDetails == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContactDetails");
            }
            if (Title == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Title");
            }
            if (ServiceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ServiceId");
            }
            if (ContactDetails != null)
            {
                ContactDetails.Validate();
            }
        }
    }
}
