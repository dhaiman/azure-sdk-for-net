// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Blockchain
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// REST API for Azure Blockchain Service
    /// </summary>
    public partial interface IBlockchainManagementClient : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Credentials needed for the client to connect to Azure.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Client API Version.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// Gets the subscription Id which uniquely identifies the Microsoft
        /// Azure subscription. The subscription ID is part of the URI for
        /// every service call.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// The preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// The retry timeout in seconds for Long Running Operations. Default
        /// value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// Whether a unique x-ms-client-request-id should be generated. When
        /// set to true a unique x-ms-client-request-id value is generated and
        /// included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IBlockchainMembersOperations.
        /// </summary>
        IBlockchainMembersOperations BlockchainMembers { get; }

        /// <summary>
        /// Gets the IBlockchainMemberOperationResultsOperations.
        /// </summary>
        IBlockchainMemberOperationResultsOperations BlockchainMemberOperationResults { get; }

        /// <summary>
        /// Gets the ILocationsOperations.
        /// </summary>
        ILocationsOperations Locations { get; }

        /// <summary>
        /// Gets the IOperations.
        /// </summary>
        IOperations Operations { get; }

        /// <summary>
        /// Gets the ISkusOperations.
        /// </summary>
        ISkusOperations Skus { get; }

        /// <summary>
        /// Gets the ITransactionNodesOperations.
        /// </summary>
        ITransactionNodesOperations TransactionNodes { get; }

    }
}
