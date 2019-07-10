// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataShare
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// SynchronizationSettingsOperations operations.
    /// </summary>
    public partial interface ISynchronizationSettingsOperations
    {
        /// <summary>
        /// Get synchronizationSetting in a share.
        /// </summary>
        /// <remarks>
        /// Get a synchronizationSetting in a share
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        /// <param name='shareName'>
        /// The name of the share.
        /// </param>
        /// <param name='synchronizationSettingName'>
        /// The name of the synchronizationSetting.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DataShareErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SynchronizationSetting>> GetWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, string synchronizationSettingName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Adds a new synchronization setting to an existing share or updates
        /// it if existing.
        /// </summary>
        /// <remarks>
        /// Create or update a synchronizationSetting
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        /// <param name='shareName'>
        /// The name of the share to add the synchronization setting to.
        /// </param>
        /// <param name='synchronizationSettingName'>
        /// The name of the synchronizationSetting.
        /// </param>
        /// <param name='synchronizationSetting'>
        /// The new synchronization setting information.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DataShareErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<SynchronizationSetting>> CreateWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, string synchronizationSettingName, SynchronizationSetting synchronizationSetting, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete synchronizationSetting in a share.
        /// </summary>
        /// <remarks>
        /// Delete a synchronizationSetting in a share
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        /// <param name='shareName'>
        /// The name of the share.
        /// </param>
        /// <param name='synchronizationSettingName'>
        /// The name of the synchronizationSetting .
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DataShareErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<OperationResponse>> DeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, string synchronizationSettingName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List synchronizationSettings in a share.
        /// </summary>
        /// <remarks>
        /// List synchronizationSettings in a share
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        /// <param name='shareName'>
        /// The name of the share.
        /// </param>
        /// <param name='skipToken'>
        /// continuation token
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DataShareErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SynchronizationSetting>>> ListByShareWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, string skipToken = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete synchronizationSetting in a share.
        /// </summary>
        /// <remarks>
        /// Delete a synchronizationSetting in a share
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='accountName'>
        /// The name of the share account.
        /// </param>
        /// <param name='shareName'>
        /// The name of the share.
        /// </param>
        /// <param name='synchronizationSettingName'>
        /// The name of the synchronizationSetting .
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DataShareErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<OperationResponse>> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string accountName, string shareName, string synchronizationSettingName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// List synchronizationSettings in a share.
        /// </summary>
        /// <remarks>
        /// List synchronizationSettings in a share
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="DataShareErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<SynchronizationSetting>>> ListByShareNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
