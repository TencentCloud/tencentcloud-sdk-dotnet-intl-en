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

namespace TencentCloud.Tiw.V20190919.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBoardSDKLogRequest : AbstractModel
    {
        
        /// <summary>
        /// SdkAppId of the whiteboard application.
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// Room ID to be used to query logs.
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// User ID to be used to query logs.
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// Query period, which consists of two Unix timestamps in milliseconds. The first indicates the start time and the second the end time.
        /// </summary>
        [JsonProperty("TimeRange")]
        public long?[] TimeRange{ get; set; }

        /// <summary>
        /// Interval for aggregating log number queries. Example values: `5m`, `1h`, `4h`
        /// </summary>
        [JsonProperty("AggregationInterval")]
        public string AggregationInterval{ get; set; }

        /// <summary>
        /// Extra query conditions.
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// Specifies whether to sort results in ascending order of time.
        /// </summary>
        [JsonProperty("Ascending")]
        public bool? Ascending{ get; set; }

        /// <summary>
        /// Context key used for recursive extraction. Obtain this parameter in the response to the last request.
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamArraySimple(map, prefix + "TimeRange.", this.TimeRange);
            this.SetParamSimple(map, prefix + "AggregationInterval", this.AggregationInterval);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "Ascending", this.Ascending);
            this.SetParamSimple(map, prefix + "Context", this.Context);
        }
    }
}

