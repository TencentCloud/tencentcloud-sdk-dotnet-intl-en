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

namespace TencentCloud.Tokenhub.V20260322.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTokenPlanApiKeyListRequest : AbstractModel
    {
        
        /// <summary>
        /// Package ID. You can obtain it through the DescribeTokenPlanList API.
        /// </summary>
        [JsonProperty("TeamId")]
        public string TeamId{ get; set; }

        /// <summary>
        /// Offset of paginated query. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// Number of results returned by paging query. Default value: 20. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Paginate the list of query filter criteria. Supported filter fields: ApiKeyId (API Key ID), Name (API Key name), Status (whether the API Key is available), StopReason (reason for disabling the API Key), UseStatus (API Key user-side switch).
        /// </summary>
        [JsonProperty("Filters")]
        public RequestFilter[] Filters{ get; set; }

        /// <summary>
        /// Paginate the list of sorting criteria. Supported sorting fields: CreatedAt (creation time) and UpdatedAt (update time). By default, results are sorted by CreatedAt in descending order.
        /// </summary>
        [JsonProperty("Sorts")]
        public RequestSort[] Sorts{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TeamId", this.TeamId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamArrayObj(map, prefix + "Sorts.", this.Sorts);
        }
    }
}

