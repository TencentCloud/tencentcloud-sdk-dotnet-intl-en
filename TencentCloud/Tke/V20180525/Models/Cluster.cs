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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Cluster : AbstractModel
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
        /// Cluster description
        /// </summary>
        [JsonProperty("ClusterDescription")]
        public string ClusterDescription{ get; set; }

        /// <summary>
        /// Cluster version. The default value is 1.10.5.
        /// </summary>
        [JsonProperty("ClusterVersion")]
        public string ClusterVersion{ get; set; }

        /// <summary>
        /// Cluster operating system. centOS 7.2x86_64 or ubuntu 16.04.1 LTSx86_64. Default value: ubuntu 16.04.1 LTSx86_64
        /// </summary>
        [JsonProperty("ClusterOs")]
        public string ClusterOs{ get; set; }

        /// <summary>
        /// Cluster type. Managed cluster: MANAGED_CLUSTER; Self-deployed cluster: INDEPENDENT_CLUSTER.
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// Cluster network-related parameters
        /// </summary>
        [JsonProperty("ClusterNetworkSettings")]
        public ClusterNetworkSettings ClusterNetworkSettings{ get; set; }

        /// <summary>
        /// Current number of nodes in the cluster
        /// </summary>
        [JsonProperty("ClusterNodeNum")]
        public ulong? ClusterNodeNum{ get; set; }

        /// <summary>
        /// ID of the project to which the cluster belongs
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// Tag description list.
        /// </summary>
        [JsonProperty("TagSpecification")]
        public TagSpecification[] TagSpecification{ get; set; }

        /// <summary>
        /// Cluster status. Values: `Trading` (Preparing), `Creating`, `Running`, `Deleting`, `Idling` (Idle), `Recovering`, `Scaling`, `Upgrading` (Upgrading the cluster), `WaittingForConnect` (Pending registration), `Pause` (Cluster upgrade paused), `NodeUpgrading` (Upgrading the node), `RuntimeUpgrading` (Upgrading the node runtime), `MasterScaling` (Scaling Master), `ClusterLevelUpgrading` (Adjusting cluster specification level), `ResourceIsolate` (Isolating), `ResourceIsolated` (Isolated), `ResourceReverse` (Overdue payment made. Recovering the cluster), and `Abnormal`.
        /// </summary>
        [JsonProperty("ClusterStatus")]
        public string ClusterStatus{ get; set; }

        /// <summary>
        /// Cluster attributes (including a map of different cluster attributes, with attribute fields including NodeNameType (lan-ip mode and hostname mode, with lan-ip mode as default))
        /// </summary>
        [JsonProperty("Property")]
        public string Property{ get; set; }

        /// <summary>
        /// Number of primary nodes currently in the cluster
        /// </summary>
        [JsonProperty("ClusterMaterNodeNum")]
        public ulong? ClusterMaterNodeNum{ get; set; }

        /// <summary>
        /// ID of the image used by the cluster
        /// Note: this field may return null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// Container image tag
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("OsCustomizeType")]
        public string OsCustomizeType{ get; set; }

        /// <summary>
        /// Runtime environment of the cluster. Values can be `docker` or `containerd`.
        /// Note: this field may return null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("ContainerRuntime")]
        public string ContainerRuntime{ get; set; }

        /// <summary>
        /// Creation time
        /// Note: this field may return null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// Whether Deletion Protection is enabled
        /// Note: this field may return null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("DeletionProtection")]
        public bool? DeletionProtection{ get; set; }

        /// <summary>
        /// Specifies whether the cluster supports external nodes.
        /// Note: this field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("EnableExternalNode")]
        public bool? EnableExternalNode{ get; set; }

        /// <summary>
        /// Cluster models. It’s valid for managed clusters.
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClusterLevel")]
        public string ClusterLevel{ get; set; }

        /// <summary>
        /// The target cluster model for auto-upgrade
        /// Note: this field may return null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("AutoUpgradeClusterLevel")]
        public bool? AutoUpgradeClusterLevel{ get; set; }

        /// <summary>
        /// Whether to enable qGPU Sharing
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("QGPUShareEnable")]
        public bool? QGPUShareEnable{ get; set; }

        /// <summary>
        /// Runtime version
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RuntimeVersion")]
        public string RuntimeVersion{ get; set; }

        /// <summary>
        /// Number of current etcd in the cluster
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClusterEtcdNodeNum")]
        public ulong? ClusterEtcdNodeNum{ get; set; }

        /// <summary>
        /// CDC Id
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterDescription", this.ClusterDescription);
            this.SetParamSimple(map, prefix + "ClusterVersion", this.ClusterVersion);
            this.SetParamSimple(map, prefix + "ClusterOs", this.ClusterOs);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamObj(map, prefix + "ClusterNetworkSettings.", this.ClusterNetworkSettings);
            this.SetParamSimple(map, prefix + "ClusterNodeNum", this.ClusterNodeNum);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArrayObj(map, prefix + "TagSpecification.", this.TagSpecification);
            this.SetParamSimple(map, prefix + "ClusterStatus", this.ClusterStatus);
            this.SetParamSimple(map, prefix + "Property", this.Property);
            this.SetParamSimple(map, prefix + "ClusterMaterNodeNum", this.ClusterMaterNodeNum);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "OsCustomizeType", this.OsCustomizeType);
            this.SetParamSimple(map, prefix + "ContainerRuntime", this.ContainerRuntime);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "DeletionProtection", this.DeletionProtection);
            this.SetParamSimple(map, prefix + "EnableExternalNode", this.EnableExternalNode);
            this.SetParamSimple(map, prefix + "ClusterLevel", this.ClusterLevel);
            this.SetParamSimple(map, prefix + "AutoUpgradeClusterLevel", this.AutoUpgradeClusterLevel);
            this.SetParamSimple(map, prefix + "QGPUShareEnable", this.QGPUShareEnable);
            this.SetParamSimple(map, prefix + "RuntimeVersion", this.RuntimeVersion);
            this.SetParamSimple(map, prefix + "ClusterEtcdNodeNum", this.ClusterEtcdNodeNum);
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
        }
    }
}

