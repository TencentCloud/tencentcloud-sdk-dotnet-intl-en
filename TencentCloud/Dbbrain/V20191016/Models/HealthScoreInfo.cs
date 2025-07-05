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

namespace TencentCloud.Dbbrain.V20191016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HealthScoreInfo : AbstractModel
    {
        
        /// <summary>
        /// Exception details
        /// </summary>
        [JsonProperty("IssueTypes")]
        public IssueTypeInfo[] IssueTypes{ get; set; }

        /// <summary>
        /// Total number of the exceptions
        /// </summary>
        [JsonProperty("EventsTotalCount")]
        public long? EventsTotalCount{ get; set; }

        /// <summary>
        /// Health score
        /// </summary>
        [JsonProperty("HealthScore")]
        public long? HealthScore{ get; set; }

        /// <summary>
        /// Health level, such as "HEALTH", "SUB_HEALTH", "RISK", "HIGH_RISK".
        /// </summary>
        [JsonProperty("HealthLevel")]
        public string HealthLevel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "IssueTypes.", this.IssueTypes);
            this.SetParamSimple(map, prefix + "EventsTotalCount", this.EventsTotalCount);
            this.SetParamSimple(map, prefix + "HealthScore", this.HealthScore);
            this.SetParamSimple(map, prefix + "HealthLevel", this.HealthLevel);
        }
    }
}

