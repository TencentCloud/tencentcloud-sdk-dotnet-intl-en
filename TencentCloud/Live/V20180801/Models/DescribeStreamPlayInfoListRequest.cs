/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeStreamPlayInfoListRequest : AbstractModel
    {
        
        /// <summary>
        /// Start time (Beijing time) in the format of yyyy-mm-dd HH:MM:SS
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End time (Beijing time) in the format of yyyy-mm-dd HH:MM:SS
        /// The end time and start time must be on the same day. Data in the last 3 days can be queried.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Playback domain name,
        /// If this parameter is left empty, data of live streams of all playback domain names will be queried.
        /// </summary>
        [JsonProperty("PlayDomain")]
        public string PlayDomain{ get; set; }

        /// <summary>
        /// Stream name (exact match).
        /// If this parameter is left empty, full playback data will be queried.
        /// </summary>
        [JsonProperty("StreamName")]
        public string StreamName{ get; set; }

        /// <summary>
        /// Push address. Its value is the same as the `AppName` in playback address. It supports exact match, and takes effect only when `StreamName` is passed at the same time.
        /// If it is left empty, the full playback data will be queried.
        /// Note: to query by `AppName`, you need to submit a ticket first. After your application succeeds, it will take about 5 business days (subject to the time in the reply) for the configuration to take effect.
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "PlayDomain", this.PlayDomain);
            this.SetParamSimple(map, prefix + "StreamName", this.StreamName);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
        }
    }
}

