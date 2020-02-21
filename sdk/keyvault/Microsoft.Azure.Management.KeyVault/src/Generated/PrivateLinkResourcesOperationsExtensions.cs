// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.KeyVault
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PrivateLinkResourcesOperations.
    /// </summary>
    public static partial class PrivateLinkResourcesOperationsExtensions
    {
            /// <summary>
            /// Gets the private link resources supported for the key vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the key vault.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the key vault.
            /// </param>
            public static PrivateLinkResourceListResult ListByVault(this IPrivateLinkResourcesOperations operations, string resourceGroupName, string vaultName)
            {
                return operations.ListByVaultAsync(resourceGroupName, vaultName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the private link resources supported for the key vault.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group that contains the key vault.
            /// </param>
            /// <param name='vaultName'>
            /// The name of the key vault.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateLinkResourceListResult> ListByVaultAsync(this IPrivateLinkResourcesOperations operations, string resourceGroupName, string vaultName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByVaultWithHttpMessagesAsync(resourceGroupName, vaultName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
