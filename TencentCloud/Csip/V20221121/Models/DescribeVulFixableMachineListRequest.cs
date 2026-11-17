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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeVulFixableMachineListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>List of vulnerability IDs. Supports up to 100.</p>
        /// </summary>
        [JsonProperty("VulIds")]
        public long?[] VulIds{ get; set; }

        /// <summary>
        /// <p>Paging offset<br>Value range: [0, +∞)<br>Default value: 0</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>Number of results per page<br>Value range: [1, 100]<br>Default value: 10</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>Filter criteria<br>Supported Filter.Name:<br>Keyword - Fuzzy matching. Search by asset ID or asset name.<br>ComponentName - Fuzzy matching. Search by associated component name.<br>InstanceId - Exact match. Filter by host instance ID.<br>MachineName - Fuzzy matching. Search by host name.<br>MachineIp - Fuzzy matching. Search by host IP.<br>OsType - Exact match. Filter by OS type: linux/windows<br>SupportAutoFix - Exact match. Filter by whether auto-repair is supported: 0-unsupported 1-supported<br>Tag - Exact match. Filter by asset tag.<br>AppId - Exact match. Filter by associated account.</p>
        /// </summary>
        [JsonProperty("Filters")]
        public Filters[] Filters{ get; set; }

        /// <summary>
        /// Group Account Member ID
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "VulIds.", this.VulIds);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
        }
    }
}

