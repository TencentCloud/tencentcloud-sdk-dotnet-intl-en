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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSlowLogPatternsRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID. Log in to the [TencentDB for MongoDB console](https://console.cloud.tencent.com/mongodb), and copy the instance ID from the instance list.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Slow log start time.
        /// - Format: yyyy-mm-dd hh:mm:ss. For example, 2019-06-01 10:00:00.
        /// - The query start and end time interval cannot exceed 24 hours. Only slow logs within the last 7 days can be queried.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Slow log end time.
        /// - Format: yyyy-mm-dd hh:mm:ss. For example, 2019-06-02 12:00:00.
        /// - The query start and end time interval cannot exceed 24 hours. Only slow logs within the last 7 days can be queried.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Threshold of slow log execution time in milliseconds. Minimum value: 100. Slow logs whose execution time exceeds the threshold will be returned.
        /// </summary>
        [JsonProperty("SlowMS")]
        public ulong? SlowMS{ get; set; }

        /// <summary>
        /// Offset. Minimum value: 0. Maximum value: 10000. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of entries per page. Minimum value: 1. Maximum value: 100. Default value: 20.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Slow log format, which can be JSON. If this parameter is left empty, the slow log will be returned in its native format.
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SlowMS", this.SlowMS);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Format", this.Format);
        }
    }
}

