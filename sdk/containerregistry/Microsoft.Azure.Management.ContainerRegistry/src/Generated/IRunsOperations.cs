// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;

    /// <summary>
    /// RunsOperations operations.
    /// </summary>
    public partial interface IRunsOperations
    {
        /// <summary>
        /// Gets all the runs for a registry.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorSchemaException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse<IPage<Run>>> ListWithHttpMessagesAsync(string resourceGroupName, string registryName, ODataQuery<RunFilter> odataQuery = default(ODataQuery<RunFilter>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the detailed information for a given run.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='runId'>
        /// The run ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorSchemaException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse<Run>> GetWithHttpMessagesAsync(string resourceGroupName, string registryName, string runId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Patch the run properties.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='runId'>
        /// The run ID.
        /// </param>
        /// <param name='isArchiveEnabled'>
        /// The value that indicates whether archiving is enabled or not.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorSchemaException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse<Run>> UpdateWithHttpMessagesAsync(string resourceGroupName, string registryName, string runId, bool? isArchiveEnabled = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a link to download the run logs.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='runId'>
        /// The run ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorSchemaException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse<RunGetLogResult>> GetLogSasUrlWithHttpMessagesAsync(string resourceGroupName, string registryName, string runId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Cancel an existing run.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='runId'>
        /// The run ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorSchemaException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse> CancelWithHttpMessagesAsync(string resourceGroupName, string registryName, string runId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Patch the run properties.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='runId'>
        /// The run ID.
        /// </param>
        /// <param name='isArchiveEnabled'>
        /// The value that indicates whether archiving is enabled or not.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorSchemaException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse<Run>> BeginUpdateWithHttpMessagesAsync(string resourceGroupName, string registryName, string runId, bool? isArchiveEnabled = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Cancel an existing run.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to which the container registry
        /// belongs.
        /// </param>
        /// <param name='registryName'>
        /// The name of the container registry.
        /// </param>
        /// <param name='runId'>
        /// The run ID.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorSchemaException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse> BeginCancelWithHttpMessagesAsync(string resourceGroupName, string registryName, string runId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets all the runs for a registry.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorSchemaException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<AzureOperationResponse<IPage<Run>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
