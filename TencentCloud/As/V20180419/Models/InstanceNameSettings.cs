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

    public class InstanceNameSettings : AbstractModel
    {
        
        /// <summary>
        /// CVM instance name.
        /// 
        /// The InstanceName cannot start or end with a period (.) or hyphen (-), and cannot contain consecutive periods and hyphens.
        /// 
        /// Other types (such as Linux) of instances: The name should be a combination of 2 to 40 characters, supporting multiple periods (.). The piece between two periods is composed of letters (case insensitive), numbers, and hyphens (-).
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Type of CVM instance name. Valid values: "ORIGINAL" and "UNIQUE". Default value: "ORIGINAL".
        /// 
        /// ORIGINAL: Auto Scaling transfers the input parameter `InstanceName` to the CVM directly. The CVM may append a serial number to the `InstanceName`. The `InstanceName` of the instances within the auto scaling group may conflict.
        /// 
        /// UNIQUE: the input parameter `InstanceName` is the prefix of an instance name. Auto Scaling and CVM expand it. The `InstanceName` of an instance in the auto scaling group is unique.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceNameStyle")]
        public string InstanceNameStyle{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceNameStyle", this.InstanceNameStyle);
        }
    }
}

