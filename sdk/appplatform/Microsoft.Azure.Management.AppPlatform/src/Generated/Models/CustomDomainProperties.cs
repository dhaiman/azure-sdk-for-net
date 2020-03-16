// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Custom domain of app resource payload.
    /// </summary>
    public partial class CustomDomainProperties
    {
        /// <summary>
        /// Initializes a new instance of the CustomDomainProperties class.
        /// </summary>
        public CustomDomainProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomDomainProperties class.
        /// </summary>
        /// <param name="name">The name of domain.</param>
        /// <param name="thumbprint">The thumbprint of bound
        /// ceritifcate.</param>
        /// <param name="appName">The app name of domain.</param>
        /// <param name="certName">The bound certificate name of
        /// domain.</param>
        public CustomDomainProperties(string name = default(string), string thumbprint = default(string), string appName = default(string), string certName = default(string))
        {
            Name = name;
            Thumbprint = thumbprint;
            AppName = appName;
            CertName = certName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of domain.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the thumbprint of bound ceritifcate.
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        public string Thumbprint { get; set; }

        /// <summary>
        /// Gets or sets the app name of domain.
        /// </summary>
        [JsonProperty(PropertyName = "appName")]
        public string AppName { get; set; }

        /// <summary>
        /// Gets or sets the bound certificate name of domain.
        /// </summary>
        [JsonProperty(PropertyName = "certName")]
        public string CertName { get; set; }

    }
}
