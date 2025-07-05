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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRocketMQClustersRequest : AbstractModel
    {
        
        /// <summary>
        /// Offset.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// The max number of returned results.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Search by cluster ID.
        /// </summary>
        [JsonProperty("IdKeyword")]
        public string IdKeyword{ get; set; }

        /// <summary>
        /// Search by cluster name.
        /// </summary>
        [JsonProperty("NameKeyword")]
        public string NameKeyword{ get; set; }

        /// <summary>
        /// Filter by cluster ID.
        /// </summary>
        [JsonProperty("ClusterIdList")]
        public string[] ClusterIdList{ get; set; }

        /// <summary>
        /// For filtering by tag, this parameter must be set to `true`.
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
            this.SetParamSimple(map, prefix + "IdKeyword", this.IdKeyword);
            this.SetParamSimple(map, prefix + "NameKeyword", this.NameKeyword);
            this.SetParamArraySimple(map, prefix + "ClusterIdList.", this.ClusterIdList);
            this.SetParamSimple(map, prefix + "IsTagFilter", this.IsTagFilter);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

