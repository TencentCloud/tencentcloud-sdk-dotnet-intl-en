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

    public class InstanceNameIndexSettings : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable instance name index. Default value: false. Value range:.
        /// 
        /// **true**: indicates that instance name index is enabled.
        /// **false**: indicates that instance name index is disabled.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// Begin index number. Value range: [0, 99999999].
        /// 
        /// Indicates that the scale out activity will be failed when the index out of range. 
        /// If not specified, carries forward historical index number or 0.
        /// Lowering the index sequence number may lead to instance name duplication within the group.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BeginIndex")]
        public long? BeginIndex{ get; set; }

        /// <summary>
        /// Instance name index number digits, defaults to 0, means no specified digit count. Value range: 0-8, maximum is integer 8. when using values 1-8, the system checks whether the index number exceeds the maximum digit for this digit count.
        /// 
        /// If set to 3, index number is in the format: 000, 001, 002 ... 010, 011 ... 100 ... 999. The maximum is 999. 
        /// Assuming set to 0, the index number is 0, 1, 2 ... 10, 11 ... 100 ... 1000 ...10000 ... 99999999. Max number is 99999999.
        /// </summary>
        [JsonProperty("IndexLength")]
        public ulong? IndexLength{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "BeginIndex", this.BeginIndex);
            this.SetParamSimple(map, prefix + "IndexLength", this.IndexLength);
        }
    }
}

