// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ManagedServices
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RegistrationAssignmentsOperations.
    /// </summary>
    public static partial class RegistrationAssignmentsOperationsExtensions
    {
            /// <summary>
            /// Gets the details of specified registration assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            /// <param name='registrationAssignmentId'>
            /// Guid of the registration assignment.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='expandRegistrationDefinition'>
            /// Tells whether to return registration definition details also along with
            /// registration assignment details.
            /// </param>
            public static RegistrationAssignment Get(this IRegistrationAssignmentsOperations operations, string scope, string registrationAssignmentId, string apiVersion, bool? expandRegistrationDefinition = default(bool?))
            {
                return operations.GetAsync(scope, registrationAssignmentId, apiVersion, expandRegistrationDefinition).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the details of specified registration assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            /// <param name='registrationAssignmentId'>
            /// Guid of the registration assignment.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='expandRegistrationDefinition'>
            /// Tells whether to return registration definition details also along with
            /// registration assignment details.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RegistrationAssignment> GetAsync(this IRegistrationAssignmentsOperations operations, string scope, string registrationAssignmentId, string apiVersion, bool? expandRegistrationDefinition = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(scope, registrationAssignmentId, apiVersion, expandRegistrationDefinition, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified registration assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            /// <param name='registrationAssignmentId'>
            /// Guid of the registration assignment.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            public static void Delete(this IRegistrationAssignmentsOperations operations, string scope, string registrationAssignmentId, string apiVersion)
            {
                operations.DeleteAsync(scope, registrationAssignmentId, apiVersion).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified registration assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            /// <param name='registrationAssignmentId'>
            /// Guid of the registration assignment.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IRegistrationAssignmentsOperations operations, string scope, string registrationAssignmentId, string apiVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(scope, registrationAssignmentId, apiVersion, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates a registration assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            /// <param name='registrationAssignmentId'>
            /// Guid of the registration assignment.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='requestBody'>
            /// The parameters required to create new registration assignment.
            /// </param>
            public static RegistrationAssignment CreateOrUpdate(this IRegistrationAssignmentsOperations operations, string scope, string registrationAssignmentId, string apiVersion, RegistrationAssignment requestBody)
            {
                return operations.CreateOrUpdateAsync(scope, registrationAssignmentId, apiVersion, requestBody).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a registration assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            /// <param name='registrationAssignmentId'>
            /// Guid of the registration assignment.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='requestBody'>
            /// The parameters required to create new registration assignment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RegistrationAssignment> CreateOrUpdateAsync(this IRegistrationAssignmentsOperations operations, string scope, string registrationAssignmentId, string apiVersion, RegistrationAssignment requestBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(scope, registrationAssignmentId, apiVersion, requestBody, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of the registration assignments.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='expandRegistrationDefinition'>
            /// Tells whether to return registration definition details also along with
            /// registration assignment details.
            /// </param>
            public static IPage<RegistrationAssignment> List(this IRegistrationAssignmentsOperations operations, string scope, string apiVersion, bool? expandRegistrationDefinition = default(bool?))
            {
                return operations.ListAsync(scope, apiVersion, expandRegistrationDefinition).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of the registration assignments.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='expandRegistrationDefinition'>
            /// Tells whether to return registration definition details also along with
            /// registration assignment details.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RegistrationAssignment>> ListAsync(this IRegistrationAssignmentsOperations operations, string scope, string apiVersion, bool? expandRegistrationDefinition = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(scope, apiVersion, expandRegistrationDefinition, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified registration assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            /// <param name='registrationAssignmentId'>
            /// Guid of the registration assignment.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            public static void BeginDelete(this IRegistrationAssignmentsOperations operations, string scope, string registrationAssignmentId, string apiVersion)
            {
                operations.BeginDeleteAsync(scope, registrationAssignmentId, apiVersion).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified registration assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            /// <param name='registrationAssignmentId'>
            /// Guid of the registration assignment.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IRegistrationAssignmentsOperations operations, string scope, string registrationAssignmentId, string apiVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(scope, registrationAssignmentId, apiVersion, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates or updates a registration assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            /// <param name='registrationAssignmentId'>
            /// Guid of the registration assignment.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='requestBody'>
            /// The parameters required to create new registration assignment.
            /// </param>
            public static RegistrationAssignment BeginCreateOrUpdate(this IRegistrationAssignmentsOperations operations, string scope, string registrationAssignmentId, string apiVersion, RegistrationAssignment requestBody)
            {
                return operations.BeginCreateOrUpdateAsync(scope, registrationAssignmentId, apiVersion, requestBody).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a registration assignment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            /// <param name='registrationAssignmentId'>
            /// Guid of the registration assignment.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='requestBody'>
            /// The parameters required to create new registration assignment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RegistrationAssignment> BeginCreateOrUpdateAsync(this IRegistrationAssignmentsOperations operations, string scope, string registrationAssignmentId, string apiVersion, RegistrationAssignment requestBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(scope, registrationAssignmentId, apiVersion, requestBody, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of the registration assignments.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RegistrationAssignment> ListNext(this IRegistrationAssignmentsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of the registration assignments.
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
            public static async Task<IPage<RegistrationAssignment>> ListNextAsync(this IRegistrationAssignmentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
