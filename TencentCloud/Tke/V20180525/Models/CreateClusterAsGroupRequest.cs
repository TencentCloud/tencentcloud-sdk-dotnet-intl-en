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

    public class CreateClusterAsGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// Cluster ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// The pass-through parameters for scaling group creation, in the format of a JSON string. For more information, see the [CreateAutoScalingGroup](https://cloud.tencent.com/document/api/377/20440) API. The **LaunchConfigurationId** is created with the LaunchConfigurePara parameter, which does not support data entry.
        /// </summary>
        [JsonProperty("AutoScalingGroupPara")]
        public string AutoScalingGroupPara{ get; set; }

        /// <summary>
        /// The pass-through parameters for launch configuration creation, in the format of a JSON string. For more information, see the [CreateLaunchConfiguration](https://cloud.tencent.com/document/api/377/20447) API. **ImageId** is not required as it is already included in the cluster dimension. **UserData** is not required as it’s set through the **UserScript**.
        /// </summary>
        [JsonProperty("LaunchConfigurePara")]
        public string LaunchConfigurePara{ get; set; }

        /// <summary>
        /// Advanced configuration information of the node
        /// </summary>
        [JsonProperty("InstanceAdvancedSettings")]
        public InstanceAdvancedSettings InstanceAdvancedSettings{ get; set; }

        /// <summary>
        /// Node label array
        /// </summary>
        [JsonProperty("Labels")]
        public Label[] Labels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "AutoScalingGroupPara", this.AutoScalingGroupPara);
            this.SetParamSimple(map, prefix + "LaunchConfigurePara", this.LaunchConfigurePara);
            this.SetParamObj(map, prefix + "InstanceAdvancedSettings.", this.InstanceAdvancedSettings);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
        }
    }
}

