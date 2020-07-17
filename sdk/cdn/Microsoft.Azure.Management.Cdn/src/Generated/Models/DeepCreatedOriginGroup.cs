// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The origin group for CDN content which is added when creating a CDN
    /// endpoint. Traffic is sent to the origins within the origin group based
    /// on origin health.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DeepCreatedOriginGroup : IResource
    {
        /// <summary>
        /// Initializes a new instance of the DeepCreatedOriginGroup class.
        /// </summary>
        public DeepCreatedOriginGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeepCreatedOriginGroup class.
        /// </summary>
        /// <param name="name">Origin group name which must be unique within
        /// the endpoint.</param>
        /// <param name="origins">The source of the content being delivered via
        /// CDN within given origin group.</param>
        /// <param name="healthProbeSettings">Health probe settings to the
        /// origin that is used to determine the health of the origin.</param>
        /// <param
        /// name="trafficRestorationTimeToHealedOrNewEndpointsInMinutes">Time
        /// in minutes to shift the traffic to the endpoint gradually when an
        /// unhealthy endpoint comes healthy or a new endpoint is added.
        /// Default is 10 mins. This property is currently not
        /// supported.</param>
        /// <param name="responseBasedOriginErrorDetectionSettings">The JSON
        /// object that contains the properties to determine origin health
        /// using real requests/responses.This property is currently not
        /// supported.</param>
        public DeepCreatedOriginGroup(string name, IList<ResourceReference> origins, HealthProbeParameters healthProbeSettings = default(HealthProbeParameters), int? trafficRestorationTimeToHealedOrNewEndpointsInMinutes = default(int?), ResponseBasedOriginErrorDetectionParameters responseBasedOriginErrorDetectionSettings = default(ResponseBasedOriginErrorDetectionParameters))
        {
            Name = name;
            HealthProbeSettings = healthProbeSettings;
            Origins = origins;
            TrafficRestorationTimeToHealedOrNewEndpointsInMinutes = trafficRestorationTimeToHealedOrNewEndpointsInMinutes;
            ResponseBasedOriginErrorDetectionSettings = responseBasedOriginErrorDetectionSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets origin group name which must be unique within the
        /// endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets health probe settings to the origin that is used to
        /// determine the health of the origin.
        /// </summary>
        [JsonProperty(PropertyName = "properties.healthProbeSettings")]
        public HealthProbeParameters HealthProbeSettings { get; set; }

        /// <summary>
        /// Gets or sets the source of the content being delivered via CDN
        /// within given origin group.
        /// </summary>
        [JsonProperty(PropertyName = "properties.origins")]
        public IList<ResourceReference> Origins { get; set; }

        /// <summary>
        /// Gets or sets time in minutes to shift the traffic to the endpoint
        /// gradually when an unhealthy endpoint comes healthy or a new
        /// endpoint is added. Default is 10 mins. This property is currently
        /// not supported.
        /// </summary>
        [JsonProperty(PropertyName = "properties.trafficRestorationTimeToHealedOrNewEndpointsInMinutes")]
        public int? TrafficRestorationTimeToHealedOrNewEndpointsInMinutes { get; set; }

        /// <summary>
        /// Gets or sets the JSON object that contains the properties to
        /// determine origin health using real requests/responses.This property
        /// is currently not supported.
        /// </summary>
        [JsonProperty(PropertyName = "properties.responseBasedOriginErrorDetectionSettings")]
        public ResponseBasedOriginErrorDetectionParameters ResponseBasedOriginErrorDetectionSettings { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Origins == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Origins");
            }
            if (HealthProbeSettings != null)
            {
                HealthProbeSettings.Validate();
            }
            if (TrafficRestorationTimeToHealedOrNewEndpointsInMinutes > 50)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "TrafficRestorationTimeToHealedOrNewEndpointsInMinutes", 50);
            }
            if (TrafficRestorationTimeToHealedOrNewEndpointsInMinutes < 0)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "TrafficRestorationTimeToHealedOrNewEndpointsInMinutes", 0);
            }
            if (ResponseBasedOriginErrorDetectionSettings != null)
            {
                ResponseBasedOriginErrorDetectionSettings.Validate();
            }
        }
    }
}
