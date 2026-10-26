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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRecordPlaybackUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// Device channel ID
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }

        /// <summary>
        /// Replay start time in UTC seconds, for example: 1662114146. The longest period between the start and end times is one day and cannot span multiple days.
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// Replay end time in UTC seconds, for example: 1662114246. The longest period between the start and end times is one day, and cannot span multiple days.
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// Whether to obtain the intranet address
        /// </summary>
        [JsonProperty("IsInternal")]
        public bool? IsInternal{ get; set; }

        /// <summary>
        /// Whether to enable timestamp correction during cloud video playback. This primarily addresses issues such as timestamp reversal or rollback that cause playback failure.
        /// </summary>
        [JsonProperty("CorrectTimestamp")]
        public bool? CorrectTimestamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "IsInternal", this.IsInternal);
            this.SetParamSimple(map, prefix + "CorrectTimestamp", this.CorrectTimestamp);
        }
    }
}

