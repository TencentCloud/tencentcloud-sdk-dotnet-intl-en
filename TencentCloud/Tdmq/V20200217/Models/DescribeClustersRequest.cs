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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClustersRequest : AbstractModel
    {
        
        /// <summary>
        /// Offset. If this parameter is left empty, 0 will be used by default.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of results to be returned. If this parameter is left empty, 10 will be used by default. The maximum value is 20.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Filter by list of cluster IDs
        /// </summary>
        [JsonProperty("ClusterIdList")]
        public string[] ClusterIdList{ get; set; }

        /// <summary>
        /// Whether to filter by tag
        /// </summary>
        [JsonProperty("IsTagFilter")]
        public bool? IsTagFilter{ get; set; }

        /// <summary>
        /// Filter. Currently, you can filter only by tag.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "ClusterIdList.", this.ClusterIdList);
            this.SetParamSimple(map, prefix + "IsTagFilter", this.IsTagFilter);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

