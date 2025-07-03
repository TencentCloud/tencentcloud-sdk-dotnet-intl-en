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

namespace TencentCloud.Vod.V20240718.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeStorageRequest : AbstractModel
    {
        
        /// <summary>
        /// <b>The ID of [VOD Professional Application](http://tencentcloud.com/document/product/266/67977).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Filter criteria. The maximum number of Filters.Values is `20`. If this parameter is not input, all storage under the current SubAppId will be returned. The detailed filter criteria are as follows:
        /// <li>BucketId: Filter by the ID of bucket;</li>
        /// <li>StorageName: Filter by the name of storage.</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Sort the returned results according to this field. 
        /// SortBy.Field Values include: 
        /// <li>UpdateTime: (Default) Create time of the storage.</li>SortBy.Order Values include: 
        /// <li>Asc: (Default) The order is ascend.</li> 
        /// </summary>
        [JsonProperty("SortBy")]
        public SortBy SortBy{ get; set; }

        /// <summary>
        /// Offset for paginated queries. Default value: `0`.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Limit on paginated queries. Default value: `20`. Maximum value: `1000`.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamObj(map, prefix + "SortBy.", this.SortBy);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

