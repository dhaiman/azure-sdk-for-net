// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PolicyAssignmentsOperations operations.
    /// </summary>
    public partial interface IPolicyAssignmentsOperations
    {
        /// <summary>
        /// Deletes a policy assignment.
        /// </summary>
        /// <remarks>
        /// This operation deletes a policy assignment, given its name and the
        /// scope it was created in. The scope of a policy assignment is the
        /// part of its ID preceding
        /// '/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}'.
        /// </remarks>
        /// <param name='scope'>
        /// The scope of the policy assignment. Valid scopes are: management
        /// group (format:
        /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
        /// subscription (format: '/subscriptions/{subscriptionId}'), resource
        /// group (format:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}',
        /// or resource (format:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/[{parentResourcePath}/]{resourceType}/{resourceName}'
        /// </param>
        /// <param name='policyAssignmentName'>
        /// The name of the policy assignment to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PolicyAssignment>> DeleteWithHttpMessagesAsync(string scope, string policyAssignmentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a policy assignment.
        /// </summary>
        /// <remarks>
        /// This operation creates or updates a policy assignment with the
        /// given scope and name. Policy assignments apply to all resources
        /// contained within their scope. For example, when you assign a policy
        /// at resource group scope, that policy applies to all resources in
        /// the group.
        /// </remarks>
        /// <param name='scope'>
        /// The scope of the policy assignment. Valid scopes are: management
        /// group (format:
        /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
        /// subscription (format: '/subscriptions/{subscriptionId}'), resource
        /// group (format:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}',
        /// or resource (format:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/[{parentResourcePath}/]{resourceType}/{resourceName}'
        /// </param>
        /// <param name='policyAssignmentName'>
        /// The name of the policy assignment.
        /// </param>
        /// <param name='parameters'>
        /// Parameters for the policy assignment.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PolicyAssignment>> CreateWithHttpMessagesAsync(string scope, string policyAssignmentName, PolicyAssignment parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves a policy assignment.
        /// </summary>
        /// <remarks>
        /// This operation retrieves a single policy assignment, given its name
        /// and the scope it was created at.
        /// </remarks>
        /// <param name='scope'>
        /// The scope of the policy assignment. Valid scopes are: management
        /// group (format:
        /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
        /// subscription (format: '/subscriptions/{subscriptionId}'), resource
        /// group (format:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}',
        /// or resource (format:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/[{parentResourcePath}/]{resourceType}/{resourceName}'
        /// </param>
        /// <param name='policyAssignmentName'>
        /// The name of the policy assignment to get.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PolicyAssignment>> GetWithHttpMessagesAsync(string scope, string policyAssignmentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves all policy assignments that apply to a resource group.
        /// </summary>
        /// <remarks>
        /// This operation retrieves the list of all policy assignments
        /// associated with the given resource group in the given subscription
        /// that match the optional given $filter. Valid values for $filter
        /// are: 'atScope()' or 'policyDefinitionId eq '{value}''. If $filter
        /// is not provided, the unfiltered list includes all policy
        /// assignments associated with the resource group, including those
        /// that apply directly or apply from containing scopes, as well as any
        /// applied to resources contained within the resource group. If
        /// $filter=atScope() is provided, the returned list includes all
        /// policy assignments that apply to the resource group, which is
        /// everything in the unfiltered list except those applied to resources
        /// contained within the resource group. If $filter=policyDefinitionId
        /// eq '{value}' is provided, the returned list includes all policy
        /// assignments of the policy definition whose id is {value} that apply
        /// to the resource group.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group that contains policy assignments.
        /// </param>
        /// <param name='filter'>
        /// The filter to apply on the operation. Valid values for $filter are:
        /// 'atScope()' or 'policyDefinitionId eq '{value}''. If $filter is not
        /// provided, no filtering is performed.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PolicyAssignment>>> ListForResourceGroupWithHttpMessagesAsync(string resourceGroupName, string filter = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves all policy assignments that apply to a resource.
        /// </summary>
        /// <remarks>
        /// This operation retrieves the list of all policy assignments
        /// associated with the specified resource in the given resource group
        /// and subscription that match the optional given $filter. Valid
        /// values for $filter are: 'atScope()' or 'policyDefinitionId eq
        /// '{value}''. If $filter is not provided, the unfiltered list
        /// includes all policy assignments associated with the resource,
        /// including those that apply directly or from all containing scopes,
        /// as well as any applied to resources contained within the resource.
        /// If $filter=atScope() is provided, the returned list includes all
        /// policy assignments that apply to the resource, which is everything
        /// in the unfiltered list except those applied to resources contained
        /// within the resource. If $filter=policyDefinitionId eq '{value}' is
        /// provided, the returned list includes all policy assignments of the
        /// policy definition whose id is {value} that apply to the resource.
        /// Three parameters plus the resource name are used to identify a
        /// specific resource. If the resource is not part of a parent resource
        /// (the more common case), the parent resource path should not be
        /// provided (or provided as ''). For example a web app could be
        /// specified as ({resourceProviderNamespace} == 'Microsoft.Web',
        /// {parentResourcePath} == '', {resourceType} == 'sites',
        /// {resourceName} == 'MyWebApp'). If the resource is part of a parent
        /// resource, then all parameters should be provided. For example a
        /// virtual machine DNS name could be specified as
        /// ({resourceProviderNamespace} == 'Microsoft.Compute',
        /// {parentResourcePath} == 'virtualMachines/MyVirtualMachine',
        /// {resourceType} == 'domainNames', {resourceName} ==
        /// 'MyComputerName'). A convenient alternative to providing the
        /// namespace and type name separately is to provide both in the
        /// {resourceType} parameter, format: ({resourceProviderNamespace} ==
        /// '', {parentResourcePath} == '', {resourceType} ==
        /// 'Microsoft.Web/sites', {resourceName} == 'MyWebApp').
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the resource.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The namespace of the resource provider. For example, the namespace
        /// of a virtual machine is Microsoft.Compute (from
        /// Microsoft.Compute/virtualMachines)
        /// </param>
        /// <param name='parentResourcePath'>
        /// The parent resource path. Use empty string if there is none.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type name. For example the type name of a web app is
        /// 'sites' (from Microsoft.Web/sites).
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource.
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
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PolicyAssignment>>> ListForResourceWithHttpMessagesAsync(string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, ODataQuery<PolicyAssignment> odataQuery = default(ODataQuery<PolicyAssignment>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves all policy assignments that apply to a management group.
        /// </summary>
        /// <remarks>
        /// This operation retrieves the list of all policy assignments
        /// applicable to the management group that match the given $filter.
        /// Valid values for $filter are: 'atScope()' or 'policyDefinitionId eq
        /// '{value}''. If $filter=atScope() is provided, the returned list
        /// includes all policy assignments that are assigned to the management
        /// group or the management group's ancestors. If
        /// $filter=policyDefinitionId eq '{value}' is provided, the returned
        /// list includes all policy assignments of the policy definition whose
        /// id is {value} that apply to the management group.
        /// </remarks>
        /// <param name='managementGroupId'>
        /// The ID of the management group.
        /// </param>
        /// <param name='filter'>
        /// The filter to apply on the operation. Valid values for $filter are:
        /// 'atScope()' or 'policyDefinitionId eq '{value}''. A filter is
        /// required when listing policy assignments at management group scope.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PolicyAssignment>>> ListForManagementGroupWithHttpMessagesAsync(string managementGroupId, string filter, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves all policy assignments that apply to a subscription.
        /// </summary>
        /// <remarks>
        /// This operation retrieves the list of all policy assignments
        /// associated with the given subscription that match the optional
        /// given $filter. Valid values for $filter are: 'atScope()' or
        /// 'policyDefinitionId eq '{value}''. If $filter is not provided, the
        /// unfiltered list includes all policy assignments associated with the
        /// subscription, including those that apply directly or from
        /// management groups that contain the given subscription, as well as
        /// any applied to objects contained within the subscription. If
        /// $filter=atScope() is provided, the returned list includes all
        /// policy assignments that apply to the subscription, which is
        /// everything in the unfiltered list except those applied to objects
        /// contained within the subscription. If $filter=policyDefinitionId eq
        /// '{value}' is provided, the returned list includes all policy
        /// assignments of the policy definition whose id is {value}.
        /// </remarks>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PolicyAssignment>>> ListWithHttpMessagesAsync(ODataQuery<PolicyAssignment> odataQuery = default(ODataQuery<PolicyAssignment>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a policy assignment.
        /// </summary>
        /// <remarks>
        /// This operation deletes the policy with the given ID. Policy
        /// assignment IDs have this format:
        /// '{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}'.
        /// Valid formats for {scope} are:
        /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'
        /// (management group), '/subscriptions/{subscriptionId}'
        /// (subscription),
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}'
        /// (resource group), or
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/[{parentResourcePath}/]{resourceType}/{resourceName}'
        /// (resource).
        /// </remarks>
        /// <param name='policyAssignmentId'>
        /// The ID of the policy assignment to delete. Use the format
        /// '{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}'.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PolicyAssignment>> DeleteByIdWithHttpMessagesAsync(string policyAssignmentId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates or updates a policy assignment.
        /// </summary>
        /// <remarks>
        /// This operation creates or updates the policy assignment with the
        /// given ID. Policy assignments made on a scope apply to all resources
        /// contained in that scope. For example, when you assign a policy to a
        /// resource group that policy applies to all resources in the group.
        /// Policy assignment IDs have this format:
        /// '{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}'.
        /// Valid scopes are: management group (format:
        /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
        /// subscription (format: '/subscriptions/{subscriptionId}'), resource
        /// group (format:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}',
        /// or resource (format:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/[{parentResourcePath}/]{resourceType}/{resourceName}'.
        /// </remarks>
        /// <param name='policyAssignmentId'>
        /// The ID of the policy assignment to create. Use the format
        /// '{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}'.
        /// </param>
        /// <param name='parameters'>
        /// Parameters for policy assignment.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PolicyAssignment>> CreateByIdWithHttpMessagesAsync(string policyAssignmentId, PolicyAssignment parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves the policy assignment with the given ID.
        /// </summary>
        /// <remarks>
        /// The operation retrieves the policy assignment with the given ID.
        /// Policy assignment IDs have this format:
        /// '{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}'.
        /// Valid scopes are: management group (format:
        /// '/providers/Microsoft.Management/managementGroups/{managementGroup}'),
        /// subscription (format: '/subscriptions/{subscriptionId}'), resource
        /// group (format:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}',
        /// or resource (format:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/[{parentResourcePath}/]{resourceType}/{resourceName}'.
        /// </remarks>
        /// <param name='policyAssignmentId'>
        /// The ID of the policy assignment to get. Use the format
        /// '{scope}/providers/Microsoft.Authorization/policyAssignments/{policyAssignmentName}'.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<PolicyAssignment>> GetByIdWithHttpMessagesAsync(string policyAssignmentId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves all policy assignments that apply to a resource group.
        /// </summary>
        /// <remarks>
        /// This operation retrieves the list of all policy assignments
        /// associated with the given resource group in the given subscription
        /// that match the optional given $filter. Valid values for $filter
        /// are: 'atScope()' or 'policyDefinitionId eq '{value}''. If $filter
        /// is not provided, the unfiltered list includes all policy
        /// assignments associated with the resource group, including those
        /// that apply directly or apply from containing scopes, as well as any
        /// applied to resources contained within the resource group. If
        /// $filter=atScope() is provided, the returned list includes all
        /// policy assignments that apply to the resource group, which is
        /// everything in the unfiltered list except those applied to resources
        /// contained within the resource group. If $filter=policyDefinitionId
        /// eq '{value}' is provided, the returned list includes all policy
        /// assignments of the policy definition whose id is {value} that apply
        /// to the resource group.
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
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PolicyAssignment>>> ListForResourceGroupNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves all policy assignments that apply to a resource.
        /// </summary>
        /// <remarks>
        /// This operation retrieves the list of all policy assignments
        /// associated with the specified resource in the given resource group
        /// and subscription that match the optional given $filter. Valid
        /// values for $filter are: 'atScope()' or 'policyDefinitionId eq
        /// '{value}''. If $filter is not provided, the unfiltered list
        /// includes all policy assignments associated with the resource,
        /// including those that apply directly or from all containing scopes,
        /// as well as any applied to resources contained within the resource.
        /// If $filter=atScope() is provided, the returned list includes all
        /// policy assignments that apply to the resource, which is everything
        /// in the unfiltered list except those applied to resources contained
        /// within the resource. If $filter=policyDefinitionId eq '{value}' is
        /// provided, the returned list includes all policy assignments of the
        /// policy definition whose id is {value} that apply to the resource.
        /// Three parameters plus the resource name are used to identify a
        /// specific resource. If the resource is not part of a parent resource
        /// (the more common case), the parent resource path should not be
        /// provided (or provided as ''). For example a web app could be
        /// specified as ({resourceProviderNamespace} == 'Microsoft.Web',
        /// {parentResourcePath} == '', {resourceType} == 'sites',
        /// {resourceName} == 'MyWebApp'). If the resource is part of a parent
        /// resource, then all parameters should be provided. For example a
        /// virtual machine DNS name could be specified as
        /// ({resourceProviderNamespace} == 'Microsoft.Compute',
        /// {parentResourcePath} == 'virtualMachines/MyVirtualMachine',
        /// {resourceType} == 'domainNames', {resourceName} ==
        /// 'MyComputerName'). A convenient alternative to providing the
        /// namespace and type name separately is to provide both in the
        /// {resourceType} parameter, format: ({resourceProviderNamespace} ==
        /// '', {parentResourcePath} == '', {resourceType} ==
        /// 'Microsoft.Web/sites', {resourceName} == 'MyWebApp').
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
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PolicyAssignment>>> ListForResourceNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves all policy assignments that apply to a management group.
        /// </summary>
        /// <remarks>
        /// This operation retrieves the list of all policy assignments
        /// applicable to the management group that match the given $filter.
        /// Valid values for $filter are: 'atScope()' or 'policyDefinitionId eq
        /// '{value}''. If $filter=atScope() is provided, the returned list
        /// includes all policy assignments that are assigned to the management
        /// group or the management group's ancestors. If
        /// $filter=policyDefinitionId eq '{value}' is provided, the returned
        /// list includes all policy assignments of the policy definition whose
        /// id is {value} that apply to the management group.
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
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PolicyAssignment>>> ListForManagementGroupNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves all policy assignments that apply to a subscription.
        /// </summary>
        /// <remarks>
        /// This operation retrieves the list of all policy assignments
        /// associated with the given subscription that match the optional
        /// given $filter. Valid values for $filter are: 'atScope()' or
        /// 'policyDefinitionId eq '{value}''. If $filter is not provided, the
        /// unfiltered list includes all policy assignments associated with the
        /// subscription, including those that apply directly or from
        /// management groups that contain the given subscription, as well as
        /// any applied to objects contained within the subscription. If
        /// $filter=atScope() is provided, the returned list includes all
        /// policy assignments that apply to the subscription, which is
        /// everything in the unfiltered list except those applied to objects
        /// contained within the subscription. If $filter=policyDefinitionId eq
        /// '{value}' is provided, the returned list includes all policy
        /// assignments of the policy definition whose id is {value}.
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
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<PolicyAssignment>>> ListNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
