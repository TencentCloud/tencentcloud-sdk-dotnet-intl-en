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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAutoScalingGroupFromInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// The scaling group name. It must be unique under your account. The name can only contain letters, numbers, underscore, hyphen "-" and periods. It cannot exceed 55 bytes.
        /// </summary>
        [JsonProperty("AutoScalingGroupName")]
        public string AutoScalingGroupName{ get; set; }

        /// <summary>
        /// Instance ID. you can get the instance ID by logging in to the [console](https://console.cloud.tencent.com/cvm/index) or making an api call to [DescribeInstances](https://intl.cloud.tencent.com/document/api/213/15728?from_cn_redirect=1) and retrieving the `InstanceId` from the returned information.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Minimum number of instances. value range: [0,2000]. to meet MaxSize >= DesiredCapacity >= MinSize at the same time.
        /// </summary>
        [JsonProperty("MinSize")]
        public long? MinSize{ get; set; }

        /// <summary>
        /// Maximum instance count. value range [0,2000]. to meet MaxSize >= DesiredCapacity >= MinSize.
        /// </summary>
        [JsonProperty("MaxSize")]
        public long? MaxSize{ get; set; }

        /// <summary>
        /// Expected number of instances, value ranges from 0 to 2000, default value equals current MinSize, to meet MaxSize >= DesiredCapacity >= MinSize.
        /// </summary>
        [JsonProperty("DesiredCapacity")]
        public long? DesiredCapacity{ get; set; }

        /// <summary>
        /// Whether to inherit the instance tag. Default value: False
        /// </summary>
        [JsonProperty("InheritInstanceTag")]
        public bool? InheritInstanceTag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoScalingGroupName", this.AutoScalingGroupName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "MinSize", this.MinSize);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
            this.SetParamSimple(map, prefix + "DesiredCapacity", this.DesiredCapacity);
            this.SetParamSimple(map, prefix + "InheritInstanceTag", this.InheritInstanceTag);
        }
    }
}

