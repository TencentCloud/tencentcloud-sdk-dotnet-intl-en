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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTendisSlowLogRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID. Log in to the [Tendis console](https://console.cloud.tencent.com/tendis) and copy it in the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Start time for a query, for example, 2019-09-08 12:12:41, with a maximum query span of 30 days.
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// End time for a query, for example, 2019-09-09 12:12:41, with a maximum query span of 30 days.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Slow query threshold in ms
        /// </summary>
        [JsonProperty("MinQueryTime")]
        public long? MinQueryTime{ get; set; }

        /// <summary>
        /// Page size. Default value 20. Maximum value 100.
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Pagination offset, which is an integer multiple of Limit. Calculation formula: Offset = Limit x (Page number - 1).
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "MinQueryTime", this.MinQueryTime);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}

