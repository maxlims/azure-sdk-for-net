// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

namespace Microsoft.Azure.Management.DataLake.Store
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for AccountOperations.
    /// </summary>
    public static partial class AccountOperationsExtensions
    {
        /// <summary>
        /// Gets the specified Data Lake Store firewall rule.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake Store
        /// account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Store account from which to get the firewall
        /// rule.
        /// </param>
        /// <param name='firewallRuleName'>
        /// The name of the firewall rule to retrieve.
        /// </param>
        public static bool FirewallRuleExists(this IAccountOperations operations, string resourceGroupName, string accountName, string firewallRuleName)
        {
            return Task.Factory.StartNew(s => ((IAccountOperations)s).FirewallRuleExistsAsync(resourceGroupName, accountName, firewallRuleName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the specified Data Lake Store firewall rule.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake Store
        /// account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Store account from which to get the firewall
        /// rule.
        /// </param>
        /// <param name='firewallRuleName'>
        /// The name of the firewall rule to retrieve.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<bool> FirewallRuleExistsAsync(this IAccountOperations operations, string resourceGroupName, string accountName, string firewallRuleName, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.FirewallRuleExistsWithHttpMessagesAsync(resourceGroupName, accountName, firewallRuleName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Gets the specified Data Lake Store account.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake Store
        /// account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Store account to retrieve.
        /// </param>
        public static bool Exists(this IAccountOperations operations, string resourceGroupName, string accountName)
        {
            return Task.Factory.StartNew(s => ((IAccountOperations)s).ExistsAsync(resourceGroupName, accountName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the specified Data Lake Store account.
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the Azure resource group that contains the Data Lake Store
        /// account.
        /// </param>
        /// <param name='accountName'>
        /// The name of the Data Lake Store account to retrieve.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async Task<bool> ExistsAsync(this IAccountOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await operations.ExistsWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
