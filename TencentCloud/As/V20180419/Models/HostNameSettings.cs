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

    public class HostNameSettings : AbstractModel
    {
        
        /// <summary>
        /// Specifies the cvm hostname.
        /// <li>Dots (.) and hyphens (-) cannot be used as the first or last character of HostName, and cannot be used consecutively.</li>. 
        /// <Li>Windows instances are not supported.</li>. 
        /// <li>Instances of other types (such as Linux): specifies the character length should be within the range of [2, 42]. multiple dots (.) are allowed. each segment between dots can consist of letters (case-insensitive), digits, and hyphens (-). using only digits is not allowed.</li>. 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// The style of the CVM HostName. Valid values include ORIGINAL and UNIQUE, and the default value is ORIGINAL.
        /// <li>ORIGINAL: AS passes HostName filled in the input parameters to CVM. CVM may append serial numbers to HostName, which can result in conflicts with HostName of instances in the scaling group.</li>
        /// <li> UNIQUE: HostName filled in the input parameters acts as a prefix for the HostName. AS and CVM will expand this prefix to ensure that HostName of the instance in the scaling group is unique.</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HostNameStyle")]
        public string HostNameStyle{ get; set; }

        /// <summary>
        /// Specifies the hostname suffix for cvm.
        /// <li>Dots (.) and hyphens (-) cannot be used as the last character of HostNameSuffix, and cannot be used consecutively.</li>
        /// <Li>Windows instances are not supported.</li>
        /// <li>Instances of other types (such as Linux): The character length should be within the range of [1, 39], and the combined length with HostName cannot exceed 41. Multiple dots (.) are allowed. each segment between dots can consist of letters (case-insensitive), digits, and hyphens (-).</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HostNameSuffix")]
        public string HostNameSuffix{ get; set; }

        /// <summary>
        /// Specifies the delimiter for the CVM host name. The default delimiter is a dot (.). Valid values: 
        /// - dot (.)
        /// -  hyphen (-)
        /// - empty string.
        /// Delimiter used for concatenating host name, index, and suffix. Assuming host name is testGpu4090, index is 0007, and suffix is server.
        /// -The delimiter is a period (.), and the final concatenation is testGpu4090.007.server.
        /// -Specifies the delimiter as a hyphen (-), with the final concatenation as testGpu4090-007-server.
        /// -Delimiter is an empty string, finally concatenated as testGpu4090007server.
        /// </summary>
        [JsonProperty("HostNameDelimiter")]
        public string HostNameDelimiter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "HostNameStyle", this.HostNameStyle);
            this.SetParamSimple(map, prefix + "HostNameSuffix", this.HostNameSuffix);
            this.SetParamSimple(map, prefix + "HostNameDelimiter", this.HostNameDelimiter);
        }
    }
}

