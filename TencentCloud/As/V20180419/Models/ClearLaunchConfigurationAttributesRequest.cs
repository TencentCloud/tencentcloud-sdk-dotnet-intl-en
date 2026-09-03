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

    public class ClearLaunchConfigurationAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Launch configuration ID. Obtain it in the following ways:</p><li>Log in to the [console](https://console.cloud.tencent.com/autoscaling/config) and query the launch configuration ID.</li><li>Call the API [DescribeLaunchConfigurations](https://www.tencentcloud.com/document/api/377/20445?from_cn_redirect=1) and obtain the launch configuration ID from the `LaunchConfigurationId` in the returned information.</li>
        /// </summary>
        [JsonProperty("LaunchConfigurationId")]
        public string LaunchConfigurationId{ get; set; }

        /// <summary>
        /// <p>Whether to clear data disk information. This parameter is optional and defaults to false.<br>Enter true to clear "data disk" information. After clearing, newly created CVMs will not contain any data disk.</p>
        /// </summary>
        [JsonProperty("ClearDataDisks")]
        public bool? ClearDataDisks{ get; set; }

        /// <summary>
        /// <p>Whether to clear the MachineName-related settings of the CVM. Optional. It is false by default.<br>Set to true to clear the host name settings. After clearing, newly created CVMs will not have a host name configured.</p>
        /// </summary>
        [JsonProperty("ClearHostNameSettings")]
        public bool? ClearHostNameSettings{ get; set; }

        /// <summary>
        /// <p>Whether to clear the CVM instance name related settings. This parameter is optional and is false by default.<br>If set to true, the host name setting information is cleared. After clearing, newly created CVMs will be configured based on "as-{{ scaling group AutoScalingGroupName }}".</p>
        /// </summary>
        [JsonProperty("ClearInstanceNameSettings")]
        public bool? ClearInstanceNameSettings{ get; set; }

        /// <summary>
        /// <p>Whether to clear the placement group information. This parameter is optional and defaults to false.<br>Set it to true to clear the placement group information. After clearing, newly created hosts will not be assigned to any placement group.</p>
        /// </summary>
        [JsonProperty("ClearDisasterRecoverGroupIds")]
        public bool? ClearDisasterRecoverGroupIds{ get; set; }

        /// <summary>
        /// <p>Whether to clear the instance tag list. This parameter is optional and is false by default.<br>If true is filled in, it indicates that the instance tag list should be cleared. After the list is cleared, the CVMs created based on this will not be bound to the tags in the list.</p>
        /// </summary>
        [JsonProperty("ClearInstanceTags")]
        public bool? ClearInstanceTags{ get; set; }

        /// <summary>
        /// <p>Whether to clear MetaData. This parameter is optional and defaults to false. Enter true to clear MetaData. After clearing, newly created CVMs will not associate custom Metadata.</p>
        /// </summary>
        [JsonProperty("ClearMetadata")]
        public bool? ClearMetadata{ get; set; }

        /// <summary>
        /// <p>Whether to clear the NetworkInterfaces in the launch configuration. If the value is TRUE, clear it; if not passed or FALSE, this field will not be processed.</p>
        /// </summary>
        [JsonProperty("ClearNetworkInterfaces")]
        public bool? ClearNetworkInterfaces{ get; set; }


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
            this.SetParamSimple(map, prefix + "ClearMetadata", this.ClearMetadata);
            this.SetParamSimple(map, prefix + "ClearNetworkInterfaces", this.ClearNetworkInterfaces);
        }
    }
}

