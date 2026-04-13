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

    public class DescribeRealtimeLogDeliveryTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// Zone ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// The offset of paginated query. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// The limit of paginated query. Default value: 20. Maximum value: 1000.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Filter criteria. the maximum number of Filters.Values is 20. if this parameter is left empty, all real-time log delivery task information under the current zone-id will be returned. the detailed filter criteria are as follows:.
        /// <li>task-id: filters by real-time log delivery task id. fuzzy queries are not supported.</li>.
        /// <Li>Task-Name: filters by real-time log delivery task name. supports fuzzy query. when fuzzy search is used, only one real-time log delivery task name can be filled in.</li>.
        /// <li>entity-list: filters by the entity corresponding to the real-time log delivery task. fuzzy queries are not supported. example value: domain.example.com or sid-2s69eb5wcms7.</li>.
        /// <li>task-type: specifies the filter by real-time log delivery task type. fuzzy queries are not supported. valid values:<br> cls: push to tencent cloud cls;<br> custom_endpoint: push to a custom HTTP(S) address;<br> S3: push to an AWS S3-compatible bucket address;<br> log_analysis: push to EdgeOne log analytics.</li>.
        /// </summary>
        [JsonProperty("Filters")]
        public AdvancedFilter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}

