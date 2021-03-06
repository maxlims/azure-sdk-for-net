// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.StreamAnalytics
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for TransformationsOperations.
    /// </summary>
    public static partial class TransformationsOperationsExtensions
    {
            /// <summary>
            /// Creates a transformation or replaces an already existing transformation
            /// under an existing streaming job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='transformation'>
            /// The definition of the transformation that will be used to create a new
            /// transformation or replace the existing one under the streaming job.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='jobName'>
            /// The name of the streaming job.
            /// </param>
            /// <param name='transformationName'>
            /// The name of the transformation.
            /// </param>
            /// <param name='ifMatch'>
            /// The ETag of the transformation. Omit this value to always overwrite the
            /// current transformation. Specify the last-seen ETag value to prevent
            /// accidentally overwritting concurrent changes.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// Set to '*' to allow a new transformation to be created, but to prevent
            /// updating an existing transformation. Other values will result in a 412
            /// Pre-condition Failed response.
            /// </param>
            public static Transformation CreateOrReplace(this ITransformationsOperations operations, Transformation transformation, string resourceGroupName, string jobName, string transformationName, string ifMatch = default(string), string ifNoneMatch = default(string))
            {
                return operations.CreateOrReplaceAsync(transformation, resourceGroupName, jobName, transformationName, ifMatch, ifNoneMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a transformation or replaces an already existing transformation
            /// under an existing streaming job.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='transformation'>
            /// The definition of the transformation that will be used to create a new
            /// transformation or replace the existing one under the streaming job.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='jobName'>
            /// The name of the streaming job.
            /// </param>
            /// <param name='transformationName'>
            /// The name of the transformation.
            /// </param>
            /// <param name='ifMatch'>
            /// The ETag of the transformation. Omit this value to always overwrite the
            /// current transformation. Specify the last-seen ETag value to prevent
            /// accidentally overwritting concurrent changes.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// Set to '*' to allow a new transformation to be created, but to prevent
            /// updating an existing transformation. Other values will result in a 412
            /// Pre-condition Failed response.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Transformation> CreateOrReplaceAsync(this ITransformationsOperations operations, Transformation transformation, string resourceGroupName, string jobName, string transformationName, string ifMatch = default(string), string ifNoneMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrReplaceWithHttpMessagesAsync(transformation, resourceGroupName, jobName, transformationName, ifMatch, ifNoneMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates an existing transformation under an existing streaming job. This
            /// can be used to partially update (ie. update one or two properties) a
            /// transformation without affecting the rest the job or transformation
            /// definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='transformation'>
            /// A Transformation object. The properties specified here will overwrite the
            /// corresponding properties in the existing transformation (ie. Those
            /// properties will be updated). Any properties that are set to null here will
            /// mean that the corresponding property in the existing transformation will
            /// remain the same and not change as a result of this PATCH operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='jobName'>
            /// The name of the streaming job.
            /// </param>
            /// <param name='transformationName'>
            /// The name of the transformation.
            /// </param>
            /// <param name='ifMatch'>
            /// The ETag of the transformation. Omit this value to always overwrite the
            /// current transformation. Specify the last-seen ETag value to prevent
            /// accidentally overwritting concurrent changes.
            /// </param>
            public static Transformation Update(this ITransformationsOperations operations, Transformation transformation, string resourceGroupName, string jobName, string transformationName, string ifMatch = default(string))
            {
                return operations.UpdateAsync(transformation, resourceGroupName, jobName, transformationName, ifMatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing transformation under an existing streaming job. This
            /// can be used to partially update (ie. update one or two properties) a
            /// transformation without affecting the rest the job or transformation
            /// definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='transformation'>
            /// A Transformation object. The properties specified here will overwrite the
            /// corresponding properties in the existing transformation (ie. Those
            /// properties will be updated). Any properties that are set to null here will
            /// mean that the corresponding property in the existing transformation will
            /// remain the same and not change as a result of this PATCH operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='jobName'>
            /// The name of the streaming job.
            /// </param>
            /// <param name='transformationName'>
            /// The name of the transformation.
            /// </param>
            /// <param name='ifMatch'>
            /// The ETag of the transformation. Omit this value to always overwrite the
            /// current transformation. Specify the last-seen ETag value to prevent
            /// accidentally overwritting concurrent changes.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Transformation> UpdateAsync(this ITransformationsOperations operations, Transformation transformation, string resourceGroupName, string jobName, string transformationName, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(transformation, resourceGroupName, jobName, transformationName, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets details about the specified transformation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='jobName'>
            /// The name of the streaming job.
            /// </param>
            /// <param name='transformationName'>
            /// The name of the transformation.
            /// </param>
            public static Transformation Get(this ITransformationsOperations operations, string resourceGroupName, string jobName, string transformationName)
            {
                return operations.GetAsync(resourceGroupName, jobName, transformationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets details about the specified transformation.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='jobName'>
            /// The name of the streaming job.
            /// </param>
            /// <param name='transformationName'>
            /// The name of the transformation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Transformation> GetAsync(this ITransformationsOperations operations, string resourceGroupName, string jobName, string transformationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, jobName, transformationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
