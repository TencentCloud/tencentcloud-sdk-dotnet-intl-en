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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePrefetchTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// Site ID. this parameter will change from selectable to required after may 30, 2024. for details, see the announcement: [tencent cloud EdgeOne: tencentcloud API change notification](https://www.tencentcloud.comom/document/product/1552/104902?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Start time of the query. Either time or job-id is required.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time of the query. Either time or job-id is required.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Offset of paginated query. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number limit of paginated query. Default value: 20. Maximum value: 1000.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Filter criteria. the maximum number of Filters.Values is 20. the detailed filter criteria are as follows: <li>job-id: filter by task id in the format like 1379afjk91u32h. multiple Values and fuzzy queries are not supported.</li><li>target: filter by target resource information in the format like http://www.qq.com/1.txt. multiple Values and fuzzy queries are not supported.</li><li>domains: filter by domain name in the format like www.qq.com. fuzzy queries are not supported.</li><li>statuses: filter by task status. fuzzy queries are not supported. options:<br>  processing: processing<br>  success: successful<br>  failed: failed<br>  timeout: timed out<br>  canceled: canceled<br>  invalid: invalid, that is, the origin server response status code is not 2xx. please check the origin server service.</li>.
        /// </summary>
        [JsonProperty("Filters")]
        public AdvancedFilter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

