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

    public class RegularNodePoolInfo : AbstractModel
    {
        
        /// <summary>
        /// LaunchConfigurationId configuration
        /// </summary>
        [JsonProperty("LaunchConfigurationId")]
        public string LaunchConfigurationId{ get; set; }

        /// <summary>
        /// Auto-scaling group ID
        /// </summary>
        [JsonProperty("AutoscalingGroupId")]
        public string AutoscalingGroupId{ get; set; }

        /// <summary>
        /// NodeCountSummary node list
        /// </summary>
        [JsonProperty("NodeCountSummary")]
        public NodeCountSummary NodeCountSummary{ get; set; }

        /// <summary>
        /// Status information
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AutoscalingGroupStatus")]
        public string AutoscalingGroupStatus{ get; set; }

        /// <summary>
        /// Maximum number of nodes
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MaxNodesNum")]
        public long? MaxNodesNum{ get; set; }

        /// <summary>
        /// Minimum number of nodes
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MinNodesNum")]
        public long? MinNodesNum{ get; set; }

        /// <summary>
        /// Desired number of nodes
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DesiredNodesNum")]
        public long? DesiredNodesNum{ get; set; }

        /// <summary>
        /// Node pool osName
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("NodePoolOs")]
        public string NodePoolOs{ get; set; }

        /// <summary>
        /// Node configuration
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("InstanceAdvancedSettings")]
        public InstanceAdvancedSettings InstanceAdvancedSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LaunchConfigurationId", this.LaunchConfigurationId);
            this.SetParamSimple(map, prefix + "AutoscalingGroupId", this.AutoscalingGroupId);
            this.SetParamObj(map, prefix + "NodeCountSummary.", this.NodeCountSummary);
            this.SetParamSimple(map, prefix + "AutoscalingGroupStatus", this.AutoscalingGroupStatus);
            this.SetParamSimple(map, prefix + "MaxNodesNum", this.MaxNodesNum);
            this.SetParamSimple(map, prefix + "MinNodesNum", this.MinNodesNum);
            this.SetParamSimple(map, prefix + "DesiredNodesNum", this.DesiredNodesNum);
            this.SetParamSimple(map, prefix + "NodePoolOs", this.NodePoolOs);
            this.SetParamObj(map, prefix + "InstanceAdvancedSettings.", this.InstanceAdvancedSettings);
        }
    }
}

