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
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ConsumerSourceDataSetsOperations.
    /// </summary>
    public static partial class ConsumerSourceDataSetsOperationsExtensions
    {
            /// <summary>
            /// Get source dataSets of a shareSubscription.
            /// </summary>
            /// <remarks>
            /// Get source dataSets of a shareSubscription
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareSubscriptionName'>
            /// The name of the shareSubscription.
            /// </param>
            /// <param name='skipToken'>
            /// Continuation token
            /// </param>
            public static IPage<ConsumerSourceDataSet> ListByShareSubscription(this IConsumerSourceDataSetsOperations operations, string resourceGroupName, string accountName, string shareSubscriptionName, string skipToken = default(string))
            {
                return operations.ListByShareSubscriptionAsync(resourceGroupName, accountName, shareSubscriptionName, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get source dataSets of a shareSubscription.
            /// </summary>
            /// <remarks>
            /// Get source dataSets of a shareSubscription
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='accountName'>
            /// The name of the share account.
            /// </param>
            /// <param name='shareSubscriptionName'>
            /// The name of the shareSubscription.
            /// </param>
            /// <param name='skipToken'>
            /// Continuation token
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ConsumerSourceDataSet>> ListByShareSubscriptionAsync(this IConsumerSourceDataSetsOperations operations, string resourceGroupName, string accountName, string shareSubscriptionName, string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByShareSubscriptionWithHttpMessagesAsync(resourceGroupName, accountName, shareSubscriptionName, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get source dataSets of a shareSubscription.
            /// </summary>
            /// <remarks>
            /// Get source dataSets of a shareSubscription
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ConsumerSourceDataSet> ListByShareSubscriptionNext(this IConsumerSourceDataSetsOperations operations, string nextPageLink)
            {
                return operations.ListByShareSubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get source dataSets of a shareSubscription.
            /// </summary>
            /// <remarks>
            /// Get source dataSets of a shareSubscription
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ConsumerSourceDataSet>> ListByShareSubscriptionNextAsync(this IConsumerSourceDataSetsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByShareSubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
