// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Web App stack runtimes.
    /// </summary>
    public partial class WebAppRuntimes
    {
        /// <summary>
        /// Initializes a new instance of the WebAppRuntimes class.
        /// </summary>
        public WebAppRuntimes()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebAppRuntimes class.
        /// </summary>
        /// <param name="linuxRuntimeSettings">Linux-specific settings
        /// associated with the minor version.</param>
        /// <param name="windowsRuntimeSettings">Windows-specific settings
        /// associated with the minor version.</param>
        /// <param name="linuxContainerSettings">Linux-specific settings
        /// associated with the Java container minor version.</param>
        /// <param name="windowsContainerSettings">Windows-specific settings
        /// associated with the Java container minor version.</param>
        public WebAppRuntimes(WebAppRuntimeSettings linuxRuntimeSettings = default(WebAppRuntimeSettings), WebAppRuntimeSettings windowsRuntimeSettings = default(WebAppRuntimeSettings), LinuxJavaContainerSettings linuxContainerSettings = default(LinuxJavaContainerSettings), WindowsJavaContainerSettings windowsContainerSettings = default(WindowsJavaContainerSettings))
        {
            LinuxRuntimeSettings = linuxRuntimeSettings;
            WindowsRuntimeSettings = windowsRuntimeSettings;
            LinuxContainerSettings = linuxContainerSettings;
            WindowsContainerSettings = windowsContainerSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets linux-specific settings associated with the minor
        /// version.
        /// </summary>
        [JsonProperty(PropertyName = "linuxRuntimeSettings")]
        public WebAppRuntimeSettings LinuxRuntimeSettings { get; set; }

        /// <summary>
        /// Gets or sets windows-specific settings associated with the minor
        /// version.
        /// </summary>
        [JsonProperty(PropertyName = "windowsRuntimeSettings")]
        public WebAppRuntimeSettings WindowsRuntimeSettings { get; set; }

        /// <summary>
        /// Gets or sets linux-specific settings associated with the Java
        /// container minor version.
        /// </summary>
        [JsonProperty(PropertyName = "linuxContainerSettings")]
        public LinuxJavaContainerSettings LinuxContainerSettings { get; set; }

        /// <summary>
        /// Gets or sets windows-specific settings associated with the Java
        /// container minor version.
        /// </summary>
        [JsonProperty(PropertyName = "windowsContainerSettings")]
        public WindowsJavaContainerSettings WindowsContainerSettings { get; set; }

    }
}
