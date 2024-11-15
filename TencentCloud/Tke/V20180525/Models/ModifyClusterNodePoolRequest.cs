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

    public class ModifyClusterNodePoolRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Node pool ID
        /// </summary>
        [JsonProperty("NodePoolId")]
        public string NodePoolId{ get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Maximum number of nodes
        /// </summary>
        [JsonProperty("MaxNodesNum")]
        public long? MaxNodesNum{ get; set; }

        /// <summary>
        /// Minimum number of nodes
        /// </summary>
        [JsonProperty("MinNodesNum")]
        public long? MinNodesNum{ get; set; }

        /// <summary>
        /// Labels
        /// </summary>
        [JsonProperty("Labels")]
        public Label[] Labels{ get; set; }

        /// <summary>
        /// Taints
        /// </summary>
        [JsonProperty("Taints")]
        public Taint[] Taints{ get; set; }

        /// <summary>
        /// Node Annotation List
        /// </summary>
        [JsonProperty("Annotations")]
        public AnnotationValue[] Annotations{ get; set; }

        /// <summary>
        /// Indicates whether auto scaling is enabled.
        /// </summary>
        [JsonProperty("EnableAutoscale")]
        public bool? EnableAutoscale{ get; set; }

        /// <summary>
        /// Operating system name
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// Image tag, `DOCKER_CUSTOMIZE` (container customized tag), `GENERAL` (general tag, default value)
        /// </summary>
        [JsonProperty("OsCustomizeType")]
        public string OsCustomizeType{ get; set; }

        /// <summary>
        /// GPU driver version, CUDA version, cuDNN version and wether to enable MIG
        /// </summary>
        [JsonProperty("GPUArgs")]
        public GPUArgs GPUArgs{ get; set; }

        /// <summary>
        /// Base64-encoded custom script
        /// </summary>
        [JsonProperty("UserScript")]
        public string UserScript{ get; set; }

        /// <summary>
        /// Ignore existing nodes when update `Label` and `Taint`
        /// </summary>
        [JsonProperty("IgnoreExistedNode")]
        public bool? IgnoreExistedNode{ get; set; }

        /// <summary>
        /// Node custom parameter
        /// </summary>
        [JsonProperty("ExtraArgs")]
        public InstanceExtraArgs ExtraArgs{ get; set; }

        /// <summary>
        /// Resource tag
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Sets whether the added node is schedulable. 0 (default): schedulable; other values: unschedulable. After node initialization is completed, you can run `kubectl uncordon nodename` to enable this node for scheduling.
        /// </summary>
        [JsonProperty("Unschedulable")]
        public long? Unschedulable{ get; set; }

        /// <summary>
        /// Whether Deletion Protection is enabled
        /// </summary>
        [JsonProperty("DeletionProtection")]
        public bool? DeletionProtection{ get; set; }

        /// <summary>
        /// Specified value of dockerd --graph. Default value: /var/lib/docker
        /// </summary>
        [JsonProperty("DockerGraphPath")]
        public string DockerGraphPath{ get; set; }

        /// <summary>
        /// Base64-encoded custom script
        /// </summary>
        [JsonProperty("PreStartUserScript")]
        public string PreStartUserScript{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "NodePoolId", this.NodePoolId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "MaxNodesNum", this.MaxNodesNum);
            this.SetParamSimple(map, prefix + "MinNodesNum", this.MinNodesNum);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamArrayObj(map, prefix + "Taints.", this.Taints);
            this.SetParamArrayObj(map, prefix + "Annotations.", this.Annotations);
            this.SetParamSimple(map, prefix + "EnableAutoscale", this.EnableAutoscale);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "OsCustomizeType", this.OsCustomizeType);
            this.SetParamObj(map, prefix + "GPUArgs.", this.GPUArgs);
            this.SetParamSimple(map, prefix + "UserScript", this.UserScript);
            this.SetParamSimple(map, prefix + "IgnoreExistedNode", this.IgnoreExistedNode);
            this.SetParamObj(map, prefix + "ExtraArgs.", this.ExtraArgs);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Unschedulable", this.Unschedulable);
            this.SetParamSimple(map, prefix + "DeletionProtection", this.DeletionProtection);
            this.SetParamSimple(map, prefix + "DockerGraphPath", this.DockerGraphPath);
            this.SetParamSimple(map, prefix + "PreStartUserScript", this.PreStartUserScript);
        }
    }
}

