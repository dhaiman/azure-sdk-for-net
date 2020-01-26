// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{

    /// <summary>
    /// Defines values for EntitiesMatchingMethod.
    /// </summary>
    public static class EntitiesMatchingMethod
    {
        /// <summary>
        /// Grouping alerts into a single incident if all the entities match
        /// </summary>
        public const string All = "All";
        /// <summary>
        /// Grouping all alerts triggered by this rule into a single incident
        /// </summary>
        public const string None = "None";
        /// <summary>
        /// Grouping alerts into a single incident if the selected entities
        /// match
        /// </summary>
        public const string Custom = "Custom";
    }
}
