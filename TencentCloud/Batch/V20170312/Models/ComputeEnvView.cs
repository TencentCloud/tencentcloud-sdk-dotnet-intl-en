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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ComputeEnvView : AbstractModel
    {
        
        /// <summary>
        /// Compute environment ID
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// Compute environment name
        /// </summary>
        [JsonProperty("EnvName")]
        public string EnvName{ get; set; }

        /// <summary>
        /// Location information
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Compute node statistical metrics
        /// </summary>
        [JsonProperty("ComputeNodeMetrics")]
        public ComputeNodeMetrics ComputeNodeMetrics{ get; set; }

        /// <summary>
        /// Compute environment type
        /// </summary>
        [JsonProperty("EnvType")]
        public string EnvType{ get; set; }

        /// <summary>
        /// Number of desired compute nodes
        /// </summary>
        [JsonProperty("DesiredComputeNodeCount")]
        public ulong? DesiredComputeNodeCount{ get; set; }

        /// <summary>
        /// Compute environment resource type. Values: `CVM`, `CPM` (Bare Metal)
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// Next action
        /// </summary>
        [JsonProperty("NextAction")]
        public string NextAction{ get; set; }

        /// <summary>
        /// Number of compute nodes added to the compute environment
        /// </summary>
        [JsonProperty("AttachedComputeNodeCount")]
        public ulong? AttachedComputeNodeCount{ get; set; }

        /// <summary>
        /// Tag list bound to the compute environment.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "EnvName", this.EnvName);
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamObj(map, prefix + "ComputeNodeMetrics.", this.ComputeNodeMetrics);
            this.SetParamSimple(map, prefix + "EnvType", this.EnvType);
            this.SetParamSimple(map, prefix + "DesiredComputeNodeCount", this.DesiredComputeNodeCount);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "NextAction", this.NextAction);
            this.SetParamSimple(map, prefix + "AttachedComputeNodeCount", this.AttachedComputeNodeCount);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

