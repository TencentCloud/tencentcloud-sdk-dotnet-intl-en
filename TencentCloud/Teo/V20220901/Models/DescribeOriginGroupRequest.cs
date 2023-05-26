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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeOriginGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// Offset for paginated queries. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Limit on paginated queries. Value range: 1-1000. Default value: 10.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Filters. Each filter can have up to 20 entries. See below for details:
        /// <li>`zone-id`<br>   Filter by the specified <strong>site ID</strong>, such as zone-20hzkd4rdmy0<br>   Type: String<br>   Required: No<br>   Fuzzy query: Not supported</li><li>`origin-group-id`:<br>   Filter by the specified <strong>origin group ID</strong>, such as origin-2ccgtb24-7dc5-46s2-9r3e-95825d53dwe3a<br>   Type: String<br>   Required: No<br>   Fuzzy query: Not supported</li><li>`origin-group-name`:<br>   Filter by the specified <strong>origin group name</strong><br>   Type: String<br>   Required: No<br>   Fuzzy query: Supported (only one origin group name allowed in a query)</li>
        /// </summary>
        [JsonProperty("Filters")]
        public AdvancedFilter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

