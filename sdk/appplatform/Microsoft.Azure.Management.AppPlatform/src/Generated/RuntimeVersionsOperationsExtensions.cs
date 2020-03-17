// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RuntimeVersionsOperations.
    /// </summary>
    public static partial class RuntimeVersionsOperationsExtensions
    {
            /// <summary>
            /// List all of the available deployment runtime versions (e.g. "Java_8",
            /// "NetCore_31", etc.).
            /// You can directly pass "{value[i].value}" attribute (in the response) to all
            /// deployment CRUD operations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static AvailableRuntimeVersions ListRuntimeVersions(this IRuntimeVersionsOperations operations)
            {
                return operations.ListRuntimeVersionsAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all of the available deployment runtime versions (e.g. "Java_8",
            /// "NetCore_31", etc.).
            /// You can directly pass "{value[i].value}" attribute (in the response) to all
            /// deployment CRUD operations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AvailableRuntimeVersions> ListRuntimeVersionsAsync(this IRuntimeVersionsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListRuntimeVersionsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
