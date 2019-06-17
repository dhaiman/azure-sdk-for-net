// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The location of ftp server dataset.
    /// </summary>
    public partial class FtpServerLocation : DatasetLocation
    {
        /// <summary>
        /// Initializes a new instance of the FtpServerLocation class.
        /// </summary>
        public FtpServerLocation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FtpServerLocation class.
        /// </summary>
        /// <param name="type">Type of dataset storage location.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="folderPath">Specify the folder path of dataset. Type:
        /// string (or Expression with resultType string)</param>
        /// <param name="fileName">Specify the file name of dataset. Type:
        /// string (or Expression with resultType string).</param>
        public FtpServerLocation(string type, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object folderPath = default(object), object fileName = default(object))
            : base(type, additionalProperties, folderPath, fileName)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
