// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ReplicationProtectedItemOperation.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReplicationProtectedItemOperation
    {
        [EnumMember(Value = "ReverseReplicate")]
        ReverseReplicate,
        [EnumMember(Value = "Commit")]
        Commit,
        [EnumMember(Value = "PlannedFailover")]
        PlannedFailover,
        [EnumMember(Value = "UnplannedFailover")]
        UnplannedFailover,
        [EnumMember(Value = "DisableProtection")]
        DisableProtection,
        [EnumMember(Value = "TestFailover")]
        TestFailover,
        [EnumMember(Value = "TestFailoverCleanup")]
        TestFailoverCleanup,
        [EnumMember(Value = "Failback")]
        Failback,
        [EnumMember(Value = "FinalizeFailback")]
        FinalizeFailback,
        [EnumMember(Value = "ChangePit")]
        ChangePit,
        [EnumMember(Value = "RepairReplication")]
        RepairReplication,
        [EnumMember(Value = "SwitchProtection")]
        SwitchProtection,
        [EnumMember(Value = "CompleteMigration")]
        CompleteMigration
    }
}
