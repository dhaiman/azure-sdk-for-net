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
    using Models;
    using System.Threading;

    /// <summary>
    /// Extension methods for TaskRunsOperations.
    /// </summary>
    public static partial class TaskRunsOperationsExtensions
    {
            /// <summary>
            /// Gets the detailed information for a given task run.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='taskRunName'>
            /// The name of the task run.
            /// </param>
            public static TaskRun Get(this ITaskRunsOperations operations, string resourceGroupName, string registryName, string taskRunName)
            {
                return operations.GetAsync(resourceGroupName, registryName, taskRunName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the detailed information for a given task run.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='taskRunName'>
            /// The name of the task run.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<TaskRun> GetAsync(this ITaskRunsOperations operations, string resourceGroupName, string registryName, string taskRunName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, registryName, taskRunName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a task run for a container registry with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='taskRunName'>
            /// The name of the task run.
            /// </param>
            /// <param name='taskRun'>
            /// The parameters of a run that needs to scheduled.
            /// </param>
            public static TaskRun Create(this ITaskRunsOperations operations, string resourceGroupName, string registryName, string taskRunName, TaskRun taskRun)
            {
                return operations.CreateAsync(resourceGroupName, registryName, taskRunName, taskRun).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a task run for a container registry with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='taskRunName'>
            /// The name of the task run.
            /// </param>
            /// <param name='taskRun'>
            /// The parameters of a run that needs to scheduled.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<TaskRun> CreateAsync(this ITaskRunsOperations operations, string resourceGroupName, string registryName, string taskRunName, TaskRun taskRun, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, registryName, taskRunName, taskRun, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a specified task run resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='taskRunName'>
            /// The name of the task run.
            /// </param>
            public static void Delete(this ITaskRunsOperations operations, string resourceGroupName, string registryName, string taskRunName)
            {
                operations.DeleteAsync(resourceGroupName, registryName, taskRunName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a specified task run resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='taskRunName'>
            /// The name of the task run.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this ITaskRunsOperations operations, string resourceGroupName, string registryName, string taskRunName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, registryName, taskRunName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a task run with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='taskRunName'>
            /// The name of the task run.
            /// </param>
            /// <param name='updateParameters'>
            /// The parameters for updating a task run.
            /// </param>
            public static TaskRun Update(this ITaskRunsOperations operations, string resourceGroupName, string registryName, string taskRunName, TaskRunUpdateParameters updateParameters)
            {
                return operations.UpdateAsync(resourceGroupName, registryName, taskRunName, updateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a task run with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='taskRunName'>
            /// The name of the task run.
            /// </param>
            /// <param name='updateParameters'>
            /// The parameters for updating a task run.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<TaskRun> UpdateAsync(this ITaskRunsOperations operations, string resourceGroupName, string registryName, string taskRunName, TaskRunUpdateParameters updateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, registryName, taskRunName, updateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the detailed information for a given task run that includes all
            /// secrets.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='taskRunName'>
            /// The name of the task run.
            /// </param>
            public static TaskRun GetDetails(this ITaskRunsOperations operations, string resourceGroupName, string registryName, string taskRunName)
            {
                return operations.GetDetailsAsync(resourceGroupName, registryName, taskRunName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the detailed information for a given task run that includes all
            /// secrets.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='taskRunName'>
            /// The name of the task run.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<TaskRun> GetDetailsAsync(this ITaskRunsOperations operations, string resourceGroupName, string registryName, string taskRunName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetDetailsWithHttpMessagesAsync(resourceGroupName, registryName, taskRunName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the task runs for a specified container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            public static IPage<TaskRun> List(this ITaskRunsOperations operations, string resourceGroupName, string registryName)
            {
                return operations.ListAsync(resourceGroupName, registryName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the task runs for a specified container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<IPage<TaskRun>> ListAsync(this ITaskRunsOperations operations, string resourceGroupName, string registryName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, registryName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a task run for a container registry with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='taskRunName'>
            /// The name of the task run.
            /// </param>
            /// <param name='taskRun'>
            /// The parameters of a run that needs to scheduled.
            /// </param>
            public static TaskRun BeginCreate(this ITaskRunsOperations operations, string resourceGroupName, string registryName, string taskRunName, TaskRun taskRun)
            {
                return operations.BeginCreateAsync(resourceGroupName, registryName, taskRunName, taskRun).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a task run for a container registry with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='taskRunName'>
            /// The name of the task run.
            /// </param>
            /// <param name='taskRun'>
            /// The parameters of a run that needs to scheduled.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<TaskRun> BeginCreateAsync(this ITaskRunsOperations operations, string resourceGroupName, string registryName, string taskRunName, TaskRun taskRun, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, registryName, taskRunName, taskRun, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a specified task run resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='taskRunName'>
            /// The name of the task run.
            /// </param>
            public static void BeginDelete(this ITaskRunsOperations operations, string resourceGroupName, string registryName, string taskRunName)
            {
                operations.BeginDeleteAsync(resourceGroupName, registryName, taskRunName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a specified task run resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='taskRunName'>
            /// The name of the task run.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task BeginDeleteAsync(this ITaskRunsOperations operations, string resourceGroupName, string registryName, string taskRunName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, registryName, taskRunName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a task run with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='taskRunName'>
            /// The name of the task run.
            /// </param>
            /// <param name='updateParameters'>
            /// The parameters for updating a task run.
            /// </param>
            public static TaskRun BeginUpdate(this ITaskRunsOperations operations, string resourceGroupName, string registryName, string taskRunName, TaskRunUpdateParameters updateParameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, registryName, taskRunName, updateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a task run with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='taskRunName'>
            /// The name of the task run.
            /// </param>
            /// <param name='updateParameters'>
            /// The parameters for updating a task run.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<TaskRun> BeginUpdateAsync(this ITaskRunsOperations operations, string resourceGroupName, string registryName, string taskRunName, TaskRunUpdateParameters updateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, registryName, taskRunName, updateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the task runs for a specified container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<TaskRun> ListNext(this ITaskRunsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the task runs for a specified container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<IPage<TaskRun>> ListNextAsync(this ITaskRunsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
