// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ExpressRoutePortsLOAOperations.
    /// </summary>
    public static partial class ExpressRoutePortsLOAOperationsExtensions
    {
            /// <summary>
            /// Generate LOA for the requested ExpressRoutePort resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expressRoutePortName'>
            /// The name of ExpressRoutePort.
            /// </param>
            /// <param name='request'>
            /// Request parameters supplied to generate LOA.
            /// </param>
            public static GenerateExpressRoutePortsLOAResult Generation(this IExpressRoutePortsLOAOperations operations, string resourceGroupName, string expressRoutePortName, GenerateExpressRoutePortsLOARequest request)
            {
                return operations.GenerationAsync(resourceGroupName, expressRoutePortName, request).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generate LOA for the requested ExpressRoutePort resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='expressRoutePortName'>
            /// The name of ExpressRoutePort.
            /// </param>
            /// <param name='request'>
            /// Request parameters supplied to generate LOA.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GenerateExpressRoutePortsLOAResult> GenerationAsync(this IExpressRoutePortsLOAOperations operations, string resourceGroupName, string expressRoutePortName, GenerateExpressRoutePortsLOARequest request, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GenerationWithHttpMessagesAsync(resourceGroupName, expressRoutePortName, request, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
