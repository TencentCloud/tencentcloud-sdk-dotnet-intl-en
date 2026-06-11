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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMachinesRequest : AbstractModel
    {
        
        /// <summary>
        /// Machine group ID to query.
        /// 
        /// -Obtain the machine group ID by searching the machine group list (https://www.tencentcloud.com/document/api/614/56438?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// ip
        /// -Filter by ip.
        /// -Type: String
        /// -Required: No
        /// 
        /// instance
        /// -Filter by instance id.
        /// -Type: String
        /// -Required: No
        /// 
        /// version
        /// - Filter by LogListener version.
        /// -Type: String
        /// -Required: No
        /// 
        /// status
        /// - Filter by machine status.
        /// -Type: String
        /// -Optional: No.
        /// -Available values: 0: offline, 1: normal
        /// 
        /// offlineTime
        /// - Filter by machine offline time.
        /// -Type: String
        /// -Optional: No.
        /// -Available values: 0: no offline time, 12: within 12 hours, 24: within a day, 48: within two days, 99: before two days
        /// 
        /// Each request can have up to 10 Filters. The upper limit of Filter.Values is 100.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Pagination offset.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Limit on the number of entries per page. A maximum of 100 entries are supported.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

