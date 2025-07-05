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

    public class DescribeClusterDetailResponse : AbstractModel
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
        /// Progress of the current cluster scan task. `100` indicates that the scan is completed.
        /// </summary>
        [JsonProperty("ScanTaskProgress")]
        public long? ScanTaskProgress{ get; set; }

        /// <summary>
        /// Cluster version
        /// </summary>
        [JsonProperty("ClusterVersion")]
        public string ClusterVersion{ get; set; }

        /// <summary>
        /// Runtime component
        /// </summary>
        [JsonProperty("ContainerRuntime")]
        public string ContainerRuntime{ get; set; }

        /// <summary>
        /// Number of nodes in the cluster
        /// </summary>
        [JsonProperty("ClusterNodeNum")]
        public ulong? ClusterNodeNum{ get; set; }

        /// <summary>
        /// Cluster status. Valid values: `Running`, `Creating`, `Abnormal`.
        /// </summary>
        [JsonProperty("ClusterStatus")]
        public string ClusterStatus{ get; set; }

        /// <summary>
        /// Cluster type. Valid values: `MANAGED_CLUSTER` (managed cluster); `INDEPENDENT_CLUSTER` (self-deployed cluster).
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// Cluster region
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Number of critical check items
        /// </summary>
        [JsonProperty("SeriousRiskCount")]
        public ulong? SeriousRiskCount{ get; set; }

        /// <summary>
        /// Number of high-risk check items
        /// </summary>
        [JsonProperty("HighRiskCount")]
        public ulong? HighRiskCount{ get; set; }

        /// <summary>
        /// Number of medium-risk check items
        /// </summary>
        [JsonProperty("MiddleRiskCount")]
        public ulong? MiddleRiskCount{ get; set; }

        /// <summary>
        /// Number of prompt-risk check items
        /// </summary>
        [JsonProperty("HintRiskCount")]
        public ulong? HintRiskCount{ get; set; }

        /// <summary>
        /// Status of the check task
        /// </summary>
        [JsonProperty("CheckStatus")]
        public string CheckStatus{ get; set; }

        /// <summary>
        /// Status of the defender
        /// </summary>
        [JsonProperty("DefenderStatus")]
        public string DefenderStatus{ get; set; }

        /// <summary>
        /// Creation time of the scan task
        /// </summary>
        [JsonProperty("TaskCreateTime")]
        public string TaskCreateTime{ get; set; }

        /// <summary>
        /// Network type. Valid values: `PublicNetwork` (public network); `VPCNetwork` (VPC).
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// API server address
        /// </summary>
        [JsonProperty("ApiServerAddress")]
        public string ApiServerAddress{ get; set; }

        /// <summary>
        /// Number of nodes
        /// </summary>
        [JsonProperty("NodeCount")]
        public ulong? NodeCount{ get; set; }

        /// <summary>
        /// Number of namespaces
        /// </summary>
        [JsonProperty("NamespaceCount")]
        public ulong? NamespaceCount{ get; set; }

        /// <summary>
        /// Number of workloads
        /// </summary>
        [JsonProperty("WorkloadCount")]
        public ulong? WorkloadCount{ get; set; }

        /// <summary>
        /// Number of Pods
        /// </summary>
        [JsonProperty("PodCount")]
        public ulong? PodCount{ get; set; }

        /// <summary>
        /// Number of Services
        /// </summary>
        [JsonProperty("ServiceCount")]
        public ulong? ServiceCount{ get; set; }

        /// <summary>
        /// Number of Ingresses
        /// </summary>
        [JsonProperty("IngressCount")]
        public ulong? IngressCount{ get; set; }

        /// <summary>
        /// IPs of the primary nodes
        /// </summary>
        [JsonProperty("MasterIps")]
        public string MasterIps{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ScanTaskProgress", this.ScanTaskProgress);
            this.SetParamSimple(map, prefix + "ClusterVersion", this.ClusterVersion);
            this.SetParamSimple(map, prefix + "ContainerRuntime", this.ContainerRuntime);
            this.SetParamSimple(map, prefix + "ClusterNodeNum", this.ClusterNodeNum);
            this.SetParamSimple(map, prefix + "ClusterStatus", this.ClusterStatus);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "SeriousRiskCount", this.SeriousRiskCount);
            this.SetParamSimple(map, prefix + "HighRiskCount", this.HighRiskCount);
            this.SetParamSimple(map, prefix + "MiddleRiskCount", this.MiddleRiskCount);
            this.SetParamSimple(map, prefix + "HintRiskCount", this.HintRiskCount);
            this.SetParamSimple(map, prefix + "CheckStatus", this.CheckStatus);
            this.SetParamSimple(map, prefix + "DefenderStatus", this.DefenderStatus);
            this.SetParamSimple(map, prefix + "TaskCreateTime", this.TaskCreateTime);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "ApiServerAddress", this.ApiServerAddress);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamSimple(map, prefix + "NamespaceCount", this.NamespaceCount);
            this.SetParamSimple(map, prefix + "WorkloadCount", this.WorkloadCount);
            this.SetParamSimple(map, prefix + "PodCount", this.PodCount);
            this.SetParamSimple(map, prefix + "ServiceCount", this.ServiceCount);
            this.SetParamSimple(map, prefix + "IngressCount", this.IngressCount);
            this.SetParamSimple(map, prefix + "MasterIps", this.MasterIps);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

