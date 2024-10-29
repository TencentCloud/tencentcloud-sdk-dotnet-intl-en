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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClearLaunchConfigurationAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// Launch configuration ID
        /// </summary>
        [JsonProperty("LaunchConfigurationId")]
        public string LaunchConfigurationId{ get; set; }

        /// <summary>
        /// Whether to clear data disk information. This parameter is optional and the default value is `false`.
        /// Setting it to `true` will clear data disks, which means that CVM newly created on this launch configuration will have no data disk.
        /// </summary>
        [JsonProperty("ClearDataDisks")]
        public bool? ClearDataDisks{ get; set; }

        /// <summary>
        /// Whether to clear the CVM hostname settings. This parameter is optional and the default value is `false`.
        /// Setting it to `true` will clear the hostname settings, which means that CVM newly created on this launch configuration will have no hostname.
        /// </summary>
        [JsonProperty("ClearHostNameSettings")]
        public bool? ClearHostNameSettings{ get; set; }

        /// <summary>
        /// Whether to clear the CVM instance name settings. This parameter is optional and the default value is `false`.
        /// Setting it to `true` will clear the instance name settings, which means that CVM newly created on this launch configuration will be named in the “as-{{AutoScalingGroupName}} format.
        /// </summary>
        [JsonProperty("ClearInstanceNameSettings")]
        public bool? ClearInstanceNameSettings{ get; set; }

        /// <summary>
        /// Whether to clear placement group information. This parameter is optional. Default value: `false`.
        /// `True` means clearing placement group information. After that, no placement groups are specified for CVMs created based on the information.
        /// </summary>
        [JsonProperty("ClearDisasterRecoverGroupIds")]
        public bool? ClearDisasterRecoverGroupIds{ get; set; }

        /// <summary>
        /// Whether to clear the instance tag list. This parameter is optional, and its default value is false.
        /// If true is filled in, it indicates that the instance tag list should be cleared. After the list is cleared, the CVMs created based on this will not be bound to the tags in the list.
        /// </summary>
        [JsonProperty("ClearInstanceTags")]
        public bool? ClearInstanceTags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LaunchConfigurationId", this.LaunchConfigurationId);
            this.SetParamSimple(map, prefix + "ClearDataDisks", this.ClearDataDisks);
            this.SetParamSimple(map, prefix + "ClearHostNameSettings", this.ClearHostNameSettings);
            this.SetParamSimple(map, prefix + "ClearInstanceNameSettings", this.ClearInstanceNameSettings);
            this.SetParamSimple(map, prefix + "ClearDisasterRecoverGroupIds", this.ClearDisasterRecoverGroupIds);
            this.SetParamSimple(map, prefix + "ClearInstanceTags", this.ClearInstanceTags);
        }
    }
}

