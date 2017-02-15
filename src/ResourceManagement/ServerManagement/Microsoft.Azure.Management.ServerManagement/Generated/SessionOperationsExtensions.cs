// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServerManagement
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for SessionOperations.
    /// </summary>
    public static partial class SessionOperationsExtensions
    {
            /// <summary>
            /// Creates a session for a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='userName'>
            /// encrypted User name to be used to connect to node
            /// </param>
            /// <param name='password'>
            /// encrypted Password associated with user name
            /// </param>
            /// <param name='retentionPeriod'>
            /// session retention period. Possible values include: 'Session', 'Persistent'
            /// </param>
            /// <param name='credentialDataFormat'>
            /// credential data format. Possible values include: 'RsaEncrypted'
            /// </param>
            /// <param name='encryptionCertificateThumbprint'>
            /// encryption certificate thumbprint
            /// </param>
            public static SessionResource Create(this ISessionOperations operations, string resourceGroupName, string nodeName, string session, string userName = default(string), string password = default(string), RetentionPeriod? retentionPeriod = default(RetentionPeriod?), CredentialDataFormat? credentialDataFormat = default(CredentialDataFormat?), string encryptionCertificateThumbprint = default(string))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISessionOperations)s).CreateAsync(resourceGroupName, nodeName, session, userName, password, retentionPeriod, credentialDataFormat, encryptionCertificateThumbprint), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a session for a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='userName'>
            /// encrypted User name to be used to connect to node
            /// </param>
            /// <param name='password'>
            /// encrypted Password associated with user name
            /// </param>
            /// <param name='retentionPeriod'>
            /// session retention period. Possible values include: 'Session', 'Persistent'
            /// </param>
            /// <param name='credentialDataFormat'>
            /// credential data format. Possible values include: 'RsaEncrypted'
            /// </param>
            /// <param name='encryptionCertificateThumbprint'>
            /// encryption certificate thumbprint
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<SessionResource> CreateAsync(this ISessionOperations operations, string resourceGroupName, string nodeName, string session, string userName = default(string), string password = default(string), RetentionPeriod? retentionPeriod = default(RetentionPeriod?), CredentialDataFormat? credentialDataFormat = default(CredentialDataFormat?), string encryptionCertificateThumbprint = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, nodeName, session, userName, password, retentionPeriod, credentialDataFormat, encryptionCertificateThumbprint, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a session for a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='userName'>
            /// encrypted User name to be used to connect to node
            /// </param>
            /// <param name='password'>
            /// encrypted Password associated with user name
            /// </param>
            /// <param name='retentionPeriod'>
            /// session retention period. Possible values include: 'Session', 'Persistent'
            /// </param>
            /// <param name='credentialDataFormat'>
            /// credential data format. Possible values include: 'RsaEncrypted'
            /// </param>
            /// <param name='encryptionCertificateThumbprint'>
            /// encryption certificate thumbprint
            /// </param>
            public static SessionResource BeginCreate(this ISessionOperations operations, string resourceGroupName, string nodeName, string session, string userName = default(string), string password = default(string), RetentionPeriod? retentionPeriod = default(RetentionPeriod?), CredentialDataFormat? credentialDataFormat = default(CredentialDataFormat?), string encryptionCertificateThumbprint = default(string))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISessionOperations)s).BeginCreateAsync(resourceGroupName, nodeName, session, userName, password, retentionPeriod, credentialDataFormat, encryptionCertificateThumbprint), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a session for a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='userName'>
            /// encrypted User name to be used to connect to node
            /// </param>
            /// <param name='password'>
            /// encrypted Password associated with user name
            /// </param>
            /// <param name='retentionPeriod'>
            /// session retention period. Possible values include: 'Session', 'Persistent'
            /// </param>
            /// <param name='credentialDataFormat'>
            /// credential data format. Possible values include: 'RsaEncrypted'
            /// </param>
            /// <param name='encryptionCertificateThumbprint'>
            /// encryption certificate thumbprint
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<SessionResource> BeginCreateAsync(this ISessionOperations operations, string resourceGroupName, string nodeName, string session, string userName = default(string), string password = default(string), RetentionPeriod? retentionPeriod = default(RetentionPeriod?), CredentialDataFormat? credentialDataFormat = default(CredentialDataFormat?), string encryptionCertificateThumbprint = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, nodeName, session, userName, password, retentionPeriod, credentialDataFormat, encryptionCertificateThumbprint, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a session for a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            public static void Delete(this ISessionOperations operations, string resourceGroupName, string nodeName, string session)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((ISessionOperations)s).DeleteAsync(resourceGroupName, nodeName, session), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a session for a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this ISessionOperations operations, string resourceGroupName, string nodeName, string session, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, nodeName, session, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets a session for a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            public static SessionResource Get(this ISessionOperations operations, string resourceGroupName, string nodeName, string session)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISessionOperations)s).GetAsync(resourceGroupName, nodeName, session), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a session for a node
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name uniquely identifies the resource group within the
            /// user subscriptionId.
            /// </param>
            /// <param name='nodeName'>
            /// The node name (256 characters maximum).
            /// </param>
            /// <param name='session'>
            /// The sessionId from the user
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<SessionResource> GetAsync(this ISessionOperations operations, string resourceGroupName, string nodeName, string session, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, nodeName, session, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}