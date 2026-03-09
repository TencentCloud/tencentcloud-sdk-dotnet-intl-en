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

    public class InstanceNameSettings : AbstractModel
    {
        
        /// <summary>
        /// CVM instance name. Value range: 2-108.
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// Type of CVM instance name. Valid values: `ORIGINAL` and `UNIQUE`. Default value: `ORIGINAL`.
        /// 
        /// `ORIGINAL`: Auto Scaling sends the input parameter `InstanceName` to the CVM directly. The CVM may append a serial number to the `InstanceName`. The `InstanceName` of the instances within the scaling group may conflict.
        /// 
        /// `UNIQUE`: the input parameter `InstanceName` is the prefix of an instance name. Auto Scaling and CVM expand it. The `InstanceName` of an instance in the scaling group is unique.
        /// </summary>
        [JsonProperty("InstanceNameStyle")]
        public string InstanceNameStyle{ get; set; }

        /// <summary>
        /// CVM instance name suffix. The suffix for a CVM instance name must be 1 to 105 characters in length. Additionally, the combined character count of the base instance name and the suffix must not exceed 107 characters.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceNameSuffix")]
        public string InstanceNameSuffix{ get; set; }

        /// <summary>
        /// Specifies the delimiter for the CVM instance name. The default delimiter is a dot (.). Valid values: 
        /// - dot (.)
        /// -  hyphen (-)
        /// - empty string.
        /// Delimiter used for concatenating instance name, index, and suffix. Assuming instance name is testGpu4090, index is 0007, and suffix is server.
        /// -The delimiter is a period (.), and the final concatenation is testGpu4090.007.server.
        /// -Specifies the delimiter as a hyphen (-), with the final concatenation as testGpu4090-007-server.
        /// -Delimiter is an empty string, finally concatenated as testGpu4090007server.
        /// </summary>
        [JsonProperty("InstanceNameDelimiter")]
        public string InstanceNameDelimiter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceNameStyle", this.InstanceNameStyle);
            this.SetParamSimple(map, prefix + "InstanceNameSuffix", this.InstanceNameSuffix);
            this.SetParamSimple(map, prefix + "InstanceNameDelimiter", this.InstanceNameDelimiter);
        }
    }
}

