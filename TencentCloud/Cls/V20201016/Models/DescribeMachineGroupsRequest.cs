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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMachineGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// machineGroupName
        /// - Filter by [Machine Group Name].
        /// - Type: String
        /// - Required: No
        /// 
        /// machineGroupId
        /// - Filter by [Machine group ID].
        /// - Type: String
        /// - Required: No
        /// 
        /// osType
        /// - Filter by [Operating System Type].
        /// - Type: Int
        /// - Required: No
        /// 
        /// tagKey
        /// - Filter by [Tag key].
        /// - Type: String
        /// - Required: No
        /// 
        /// tag:tagKey
        /// - Filter by [Tag key-value pair]. Replace tagKey with the specific Tag key.- Type: String
        /// - Required: No
        /// 
        /// The maximum number of Filters per request is 10, and the maximum for Filter.Values is 5.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Page offset. Default value: 0
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Maximum number of entries per page. Default value: 20. Maximum value: 100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

