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

    public class DescribeTopicsRequest : AbstractModel
    {
        
        /// <summary>
        /// <br><li> `topicName` filters by **log topic name**. Type: String. Required: No<br><li> `logsetName` filters by **logset name**. Type: String. Required: No<br><li> `topicId` filters by **log topic ID**. Type: String. Required: No<br><li> `logsetId` filters by **logset ID**. You can call the `DescribeLogsets` API to query the list of created logsets or log in to the console to view them. You can also call the `CreateLogset` API to create a logset. Type: String. Required: No<br><li> `tagKey` filters by **tag key**. Type: String. Required: No<br><li> `tag:tagKey` filters by **tag key-value pair**. The tagKey should be replaced with a specified tag key, such as “tag:exampleKey”. Type: String. Required: No<br><li> `storageType` filters by **log topic storage type**. Valid values: `hot` (STANDARD storage); `cold`: (IA storage). Type: String. Required: No. Each request can contain up to 10 `Filters` and 100 `Filter.Values`.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Page offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Maximum number of entries per page. Default value: 20. Maximum value: 100.
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

