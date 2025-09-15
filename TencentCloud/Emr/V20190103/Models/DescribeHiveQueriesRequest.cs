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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeHiveQueriesRequest : AbstractModel
    {
        
        /// <summary>
        /// The cluster ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// The start time in seconds.
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// The end time in seconds. EndTime-StartTime should not exceed one day's duration, which is 86400 seconds.
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// Starting offset for pagination. Start value: 0
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Page size. Valid range: [1,100]
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Execution status, for example, ERROR.
        /// </summary>
        [JsonProperty("State")]
        public string[] State{ get; set; }

        /// <summary>
        /// Time point earlier than the end time.
        /// </summary>
        [JsonProperty("EndTimeGte")]
        public ulong? EndTimeGte{ get; set; }

        /// <summary>
        /// Time point later than the end time.
        /// </summary>
        [JsonProperty("EndTimeLte")]
        public ulong? EndTimeLte{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "State.", this.State);
            this.SetParamSimple(map, prefix + "EndTimeGte", this.EndTimeGte);
            this.SetParamSimple(map, prefix + "EndTimeLte", this.EndTimeLte);
        }
    }
}

