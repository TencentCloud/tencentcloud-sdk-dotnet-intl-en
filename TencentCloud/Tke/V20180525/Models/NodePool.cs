/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class NodePool : AbstractModel
    {
        
        /// <summary>
        /// Node pool ID
        /// </summary>
        [JsonProperty("NodePoolId")]
        public string NodePoolId{ get; set; }

        /// <summary>
        /// Node pool name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Cluster instance ID
        /// </summary>
        [JsonProperty("ClusterInstanceId")]
        public string ClusterInstanceId{ get; set; }

        /// <summary>
        /// The lifecycle state of the current node pool. Valid values: `creating`, `normal`, `updating`, `deleting`, and `deleted`.
        /// </summary>
        [JsonProperty("LifeState")]
        public string LifeState{ get; set; }

        /// <summary>
        /// Launch configuration ID
        /// </summary>
        [JsonProperty("LaunchConfigurationId")]
        public string LaunchConfigurationId{ get; set; }

        /// <summary>
        /// Auto-scaling group ID
        /// </summary>
        [JsonProperty("AutoscalingGroupId")]
        public string AutoscalingGroupId{ get; set; }

        /// <summary>
        /// Labels
        /// </summary>
        [JsonProperty("Labels")]
        public Label[] Labels{ get; set; }

        /// <summary>
        /// Array of taint
        /// </summary>
        [JsonProperty("Taints")]
        public Taint[] Taints{ get; set; }

        /// <summary>
        /// Node Annotation List
        /// </summary>
        [JsonProperty("Annotations")]
        public AnnotationValue[] Annotations{ get; set; }

        /// <summary>
        /// Node list
        /// </summary>
        [JsonProperty("NodeCountSummary")]
        public NodeCountSummary NodeCountSummary{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("AutoscalingGroupStatus")]
        public string AutoscalingGroupStatus{ get; set; }

        /// <summary>
        /// Maximum number of nodes
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("MaxNodesNum")]
        public long? MaxNodesNum{ get; set; }

        /// <summary>
        /// Minimum number of nodes
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("MinNodesNum")]
        public long? MinNodesNum{ get; set; }

        /// <summary>
        /// Desired number of nodes
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("DesiredNodesNum")]
        public long? DesiredNodesNum{ get; set; }

        /// <summary>
        /// Runtime Description
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("RuntimeConfig")]
        public RuntimeConfig RuntimeConfig{ get; set; }

        /// <summary>
        /// The operating system of the node pool
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("NodePoolOs")]
        public string NodePoolOs{ get; set; }

        /// <summary>
        /// Container image tag, `DOCKER_CUSTOMIZE` (container customized tag), `GENERAL` (general tag, default value)
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("OsCustomizeType")]
        public string OsCustomizeType{ get; set; }

        /// <summary>
        /// Image ID
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// This parameter is required when the custom PodCIDR mode is enabled for the cluster.
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("DesiredPodNum")]
        public long? DesiredPodNum{ get; set; }

        /// <summary>
        /// Custom script
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("UserScript")]
        public string UserScript{ get; set; }

        /// <summary>
        /// Resource tag
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Whether Deletion Protection is enabled
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeletionProtection")]
        public bool? DeletionProtection{ get; set; }

        /// <summary>
        /// Node Configuration
        /// 
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ExtraArgs")]
        public InstanceExtraArgs ExtraArgs{ get; set; }

        /// <summary>
        /// GPU Driver-related Parameters
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("GPUArgs")]
        public GPUArgs GPUArgs{ get; set; }

        /// <summary>
        /// Specified value of dockerd --graph. Default value: /var/lib/docker
        /// 
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DockerGraphPath")]
        public string DockerGraphPath{ get; set; }

        /// <summary>
        /// Multiple Disk Data Disk Mount Information: When creating a new node, make sure that the CVM purchase parameters include the information of purchasing multiple data disks. For example, in the DataDisks under RunInstancesPara of CreateClusterInstances API, it must also be set to purchase multiple data disks. Refer to the example of adding cluster nodes (multiple data disks) of CreateClusterInstances API; when adding existing nodes, ensure that the specified partition information actually exists on the node.
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DataDisks")]
        public DataDisk[] DataDisks{ get; set; }

        /// <summary>
        /// Unschedulable or not
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Unschedulable")]
        public long? Unschedulable{ get; set; }

        /// <summary>
        /// Custom script, executed before UserScript
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("PreStartUserScript")]
        public string PreStartUserScript{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodePoolId", this.NodePoolId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ClusterInstanceId", this.ClusterInstanceId);
            this.SetParamSimple(map, prefix + "LifeState", this.LifeState);
            this.SetParamSimple(map, prefix + "LaunchConfigurationId", this.LaunchConfigurationId);
            this.SetParamSimple(map, prefix + "AutoscalingGroupId", this.AutoscalingGroupId);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamArrayObj(map, prefix + "Taints.", this.Taints);
            this.SetParamArrayObj(map, prefix + "Annotations.", this.Annotations);
            this.SetParamObj(map, prefix + "NodeCountSummary.", this.NodeCountSummary);
            this.SetParamSimple(map, prefix + "AutoscalingGroupStatus", this.AutoscalingGroupStatus);
            this.SetParamSimple(map, prefix + "MaxNodesNum", this.MaxNodesNum);
            this.SetParamSimple(map, prefix + "MinNodesNum", this.MinNodesNum);
            this.SetParamSimple(map, prefix + "DesiredNodesNum", this.DesiredNodesNum);
            this.SetParamObj(map, prefix + "RuntimeConfig.", this.RuntimeConfig);
            this.SetParamSimple(map, prefix + "NodePoolOs", this.NodePoolOs);
            this.SetParamSimple(map, prefix + "OsCustomizeType", this.OsCustomizeType);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "DesiredPodNum", this.DesiredPodNum);
            this.SetParamSimple(map, prefix + "UserScript", this.UserScript);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "DeletionProtection", this.DeletionProtection);
            this.SetParamObj(map, prefix + "ExtraArgs.", this.ExtraArgs);
            this.SetParamObj(map, prefix + "GPUArgs.", this.GPUArgs);
            this.SetParamSimple(map, prefix + "DockerGraphPath", this.DockerGraphPath);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
            this.SetParamSimple(map, prefix + "Unschedulable", this.Unschedulable);
            this.SetParamSimple(map, prefix + "PreStartUserScript", this.PreStartUserScript);
        }
    }
}

