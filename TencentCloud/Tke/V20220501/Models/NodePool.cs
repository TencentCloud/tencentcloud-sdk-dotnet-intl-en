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

namespace TencentCloud.Tke.V20220501.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NodePool : AbstractModel
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
        /// Node tags
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public TagSpecification[] Tags{ get; set; }

        /// <summary>
        /// Node taint
        /// 
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Taints")]
        public Taint[] Taints{ get; set; }

        /// <summary>
        /// Whether to enable deletion protection
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DeletionProtection")]
        public bool? DeletionProtection{ get; set; }

        /// <summary>
        /// Whether the node is unschedulable
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Unschedulable")]
        public bool? Unschedulable{ get; set; }

        /// <summary>
        /// Node pool type
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Node Labels
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Labels")]
        public Label[] Labels{ get; set; }

        /// <summary>
        /// Node pool status
        /// </summary>
        [JsonProperty("LifeState")]
        public string LifeState{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// Node pool name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Native node pool parameters
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Native")]
        public NativeNodePoolInfo Native{ get; set; }

        /// <summary>
        /// Node annotation list
        /// 
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Annotations")]
        public Annotation[] Annotations{ get; set; }

        /// <summary>
        /// Super node pool parameter, which has a value only when Type equals Super
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Super")]
        public SuperNodePoolInfo Super{ get; set; }

        /// <summary>
        /// General node pool parameter, which has a value only when Type equals Regular
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Regular")]
        public RegularNodePoolInfo Regular{ get; set; }

        /// <summary>
        /// Third-party node pool parameter, which has a value only when Type equals External
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("External")]
        public ExternalNodePoolInfo External{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "NodePoolId", this.NodePoolId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "Taints.", this.Taints);
            this.SetParamSimple(map, prefix + "DeletionProtection", this.DeletionProtection);
            this.SetParamSimple(map, prefix + "Unschedulable", this.Unschedulable);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
            this.SetParamSimple(map, prefix + "LifeState", this.LifeState);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamObj(map, prefix + "Native.", this.Native);
            this.SetParamArrayObj(map, prefix + "Annotations.", this.Annotations);
            this.SetParamObj(map, prefix + "Super.", this.Super);
            this.SetParamObj(map, prefix + "Regular.", this.Regular);
            this.SetParamObj(map, prefix + "External.", this.External);
        }
    }
}

