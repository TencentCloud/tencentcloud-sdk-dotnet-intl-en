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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeComputeEnvsRequest : AbstractModel
    {
        
        /// <summary>
        /// List of compute environment IDs, which cannot be specified together with the `Filters` parameter.
        /// </summary>
        [JsonProperty("EnvIds")]
        public string[] EnvIds{ get; set; }

        /// <summary>
        /// Filters
        /// <li> `zone` - String - Optional - Availability zone.</li>
        /// <li> `env-id` - String - Optional - Compute environment ID.</li>
        /// <li> `env-name` - String - Optional - Compute environment name.</li>
        /// <li> `resource-type` - String - Optional - Compute resource type (`CVM` or `CPM`).</li>
        /// <li> `tag-key` - String - Optional - Tag key.</li>
        /// </li>`tag-value` - String - Optional - Tag value.</li>
        /// <li> `tag:tag-key` - String - Optional - Tag key-value pair. Replace `tag-key` with the actual tag key.</li>
        /// It cannot be specified together with `EnvIds`.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Offset
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Maximum number of returned items
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "EnvIds.", this.EnvIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

