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

    public class HostNameSettings : AbstractModel
    {
        
        /// <summary>
        /// Hostname of a CVM
        /// <br><li>The `HostName` cannot start or end with a period (.) or hyphen (-), and cannot contain consecutive periods and hyphens.
        /// <br><li>This field is unavailable to CVM instances.
        /// <br><li>Other types of instances (such as Linux): the name contains 2 to 40 characters, and supports multiple periods (.). The string between two periods can consist of letters (case insensitive), numbers, and hyphens (-), and cannot be all numbers.
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// Type of CVM host name. Valid values: "ORIGINAL" and "UNIQUE". Default value: "ORIGINAL"
        /// <br><li> ORIGINAL. Auto Scaling transfers the HostName set in input parameters to the CVM directly. CVM may adds serial numbers for the HostName. The HostName of instances within the auto scaling group may conflict.
        /// <br><li> UNIQUE. The HostName set in input parameters is the prefix of a host name. Auto Scaling and CVM expand it. The HostName of an instance in the auto scaling group is unique.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HostNameStyle")]
        public string HostNameStyle{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "HostNameStyle", this.HostNameStyle);
        }
    }
}

