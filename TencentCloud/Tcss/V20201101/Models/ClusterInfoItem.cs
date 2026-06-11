/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterInfoItem : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Cluster name
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// Cluster version
        /// </summary>
        [JsonProperty("ClusterVersion")]
        public string ClusterVersion{ get; set; }

        /// <summary>
        /// Cluster OS
        /// </summary>
        [JsonProperty("ClusterOs")]
        public string ClusterOs{ get; set; }

        /// <summary>
        /// Cluster type
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// Number of nodes in the cluster
        /// </summary>
        [JsonProperty("ClusterNodeNum")]
        public ulong? ClusterNodeNum{ get; set; }

        /// <summary>
        /// Cluster region
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Protection Status 
        /// Defended 
        /// Unprotected
        /// Partially defended
        /// </summary>
        [JsonProperty("DefenderStatus")]
        public string DefenderStatus{ get; set; }

        /// <summary>
        /// Cluster status
        /// </summary>
        [JsonProperty("ClusterStatus")]
        public string ClusterStatus{ get; set; }

        /// <summary>
        /// Cluster operation sub-status.
        /// </summary>
        [JsonProperty("ClusterSubStatus")]
        public string ClusterSubStatus{ get; set; }

        /// <summary>
        /// Cluster check mode. Valid values: `Cluster_Normal`, `Cluster_Actived`.
        /// </summary>
        [JsonProperty("ClusterCheckMode")]
        public string ClusterCheckMode{ get; set; }

        /// <summary>
        /// Whether automatic and regular check is enabled
        /// </summary>
        [JsonProperty("ClusterAutoCheck")]
        public bool? ClusterAutoCheck{ get; set; }

        /// <summary>
        /// Cause of the failure to deploy the defender. When it is `UserDaemonSetNotReady`, `UnreadyNodeNum` is changed to "The defenders on N nodes are ready". If it is another value, the error message is directly displayed.
        /// </summary>
        [JsonProperty("DefenderErrorReason")]
        public string DefenderErrorReason{ get; set; }

        /// <summary>
        /// Number of nodes where the defender is not ready
        /// </summary>
        [JsonProperty("UnreadyNodeNum")]
        public ulong? UnreadyNodeNum{ get; set; }

        /// <summary>
        /// Number of critical check items
        /// </summary>
        [JsonProperty("SeriousRiskCount")]
        public long? SeriousRiskCount{ get; set; }

        /// <summary>
        /// Number of high-risk check items
        /// </summary>
        [JsonProperty("HighRiskCount")]
        public long? HighRiskCount{ get; set; }

        /// <summary>
        /// Number of medium-risk check items
        /// </summary>
        [JsonProperty("MiddleRiskCount")]
        public long? MiddleRiskCount{ get; set; }

        /// <summary>
        /// Number of prompt-risk check items
        /// </summary>
        [JsonProperty("HintRiskCount")]
        public long? HintRiskCount{ get; set; }

        /// <summary>
        /// Check failure cause
        /// </summary>
        [JsonProperty("CheckFailReason")]
        public string CheckFailReason{ get; set; }

        /// <summary>
        /// Check status. Valid values: `Task_Running`, `NoRisk`, `HasRisk`, `Uncheck`, `Task_Error`.
        /// </summary>
        [JsonProperty("CheckStatus")]
        public string CheckStatus{ get; set; }

        /// <summary>
        /// Task creation time and check time
        /// </summary>
        [JsonProperty("TaskCreateTime")]
        public string TaskCreateTime{ get; set; }

        /// <summary>
        /// Access status
        /// Not connected
        /// Defended
        /// Unprotected: AccessedInstalled
        /// Partial protection: AccessedPartialDefence
        /// Access exception: AccessedException
        /// Uninstallation Exception: AccessedUninstallException
        /// ACCESSING: installing
        /// Uninstalling: AccessedUninstalling
        /// </summary>
        [JsonProperty("AccessedStatus")]
        public string AccessedStatus{ get; set; }

        /// <summary>
        /// Reason for Access Failure
        /// </summary>
        [JsonProperty("AccessedSubStatus")]
        public string AccessedSubStatus{ get; set; }

        /// <summary>
        /// Access/Uninstallation failure reason.
        /// </summary>
        [JsonProperty("AccessedErrorReason")]
        public string AccessedErrorReason{ get; set; }

        /// <summary>
        /// Total number of nodes
        /// </summary>
        [JsonProperty("NodeCount")]
        public ulong? NodeCount{ get; set; }

        /// <summary>
        /// Offline Node Count
        /// </summary>
        [JsonProperty("OffLineNodeCount")]
        public ulong? OffLineNodeCount{ get; set; }

        /// <summary>
        /// Number of Nodes Without Agent Installed
        /// </summary>
        [JsonProperty("UnInstallAgentNodeCount")]
        public ulong? UnInstallAgentNodeCount{ get; set; }

        /// <summary>
        /// Number of billing cores (elastic billing cores + regular billing cores).
        /// </summary>
        [JsonProperty("ChargeCoresCnt")]
        public ulong? ChargeCoresCnt{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("MasterAddresses")]
        public string[] MasterAddresses{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CoresCnt")]
        public ulong? CoresCnt{ get; set; }

        /// <summary>
        /// Cluster audit switch status:
        /// Closed / Closing / CloseFailed / Opened / Opening / OpenFailed
        /// </summary>
        [JsonProperty("ClusterAuditStatus")]
        public string ClusterAuditStatus{ get; set; }

        /// <summary>
        /// Information on the failure to enable/disable cluster audit.
        /// </summary>
        [JsonProperty("ClusterAuditFailedInfo")]
        public string ClusterAuditFailedInfo{ get; set; }

        /// <summary>
        /// Owner name.
        /// </summary>
        [JsonProperty("OwnerName")]
        public string OwnerName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterVersion", this.ClusterVersion);
            this.SetParamSimple(map, prefix + "ClusterOs", this.ClusterOs);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "ClusterNodeNum", this.ClusterNodeNum);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "DefenderStatus", this.DefenderStatus);
            this.SetParamSimple(map, prefix + "ClusterStatus", this.ClusterStatus);
            this.SetParamSimple(map, prefix + "ClusterSubStatus", this.ClusterSubStatus);
            this.SetParamSimple(map, prefix + "ClusterCheckMode", this.ClusterCheckMode);
            this.SetParamSimple(map, prefix + "ClusterAutoCheck", this.ClusterAutoCheck);
            this.SetParamSimple(map, prefix + "DefenderErrorReason", this.DefenderErrorReason);
            this.SetParamSimple(map, prefix + "UnreadyNodeNum", this.UnreadyNodeNum);
            this.SetParamSimple(map, prefix + "SeriousRiskCount", this.SeriousRiskCount);
            this.SetParamSimple(map, prefix + "HighRiskCount", this.HighRiskCount);
            this.SetParamSimple(map, prefix + "MiddleRiskCount", this.MiddleRiskCount);
            this.SetParamSimple(map, prefix + "HintRiskCount", this.HintRiskCount);
            this.SetParamSimple(map, prefix + "CheckFailReason", this.CheckFailReason);
            this.SetParamSimple(map, prefix + "CheckStatus", this.CheckStatus);
            this.SetParamSimple(map, prefix + "TaskCreateTime", this.TaskCreateTime);
            this.SetParamSimple(map, prefix + "AccessedStatus", this.AccessedStatus);
            this.SetParamSimple(map, prefix + "AccessedSubStatus", this.AccessedSubStatus);
            this.SetParamSimple(map, prefix + "AccessedErrorReason", this.AccessedErrorReason);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamSimple(map, prefix + "OffLineNodeCount", this.OffLineNodeCount);
            this.SetParamSimple(map, prefix + "UnInstallAgentNodeCount", this.UnInstallAgentNodeCount);
            this.SetParamSimple(map, prefix + "ChargeCoresCnt", this.ChargeCoresCnt);
            this.SetParamArraySimple(map, prefix + "MasterAddresses.", this.MasterAddresses);
            this.SetParamSimple(map, prefix + "CoresCnt", this.CoresCnt);
            this.SetParamSimple(map, prefix + "ClusterAuditStatus", this.ClusterAuditStatus);
            this.SetParamSimple(map, prefix + "ClusterAuditFailedInfo", this.ClusterAuditFailedInfo);
            this.SetParamSimple(map, prefix + "OwnerName", this.OwnerName);
        }
    }
}

