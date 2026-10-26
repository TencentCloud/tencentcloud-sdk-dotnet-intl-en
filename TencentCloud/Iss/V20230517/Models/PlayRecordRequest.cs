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

    public class PlayRecordRequest : AbstractModel
    {
        
        /// <summary>
        /// Channel ID (obtain from the DescribeDeviceChannel API)
        /// </summary>
        [JsonProperty("ChannelId")]
        public string ChannelId{ get; set; }

        /// <summary>
        /// Start time.
        /// </summary>
        [JsonProperty("Start")]
        public long? Start{ get; set; }

        /// <summary>
        ///  End time.
        /// </summary>
        [JsonProperty("End")]
        public long? End{ get; set; }

        /// <summary>
        /// Stream type (1: main stream; 2: sub-stream (not allowed to be delivered at the same time as Resolution))
        /// </summary>
        [JsonProperty("StreamType")]
        public long? StreamType{ get; set; }

        /// <summary>
        /// Resolution (1: QCIF; 2: CIF; 3: 4CIF; 4: D1; 5: 720P; 6: 1080P/I; custom 19201080, etc. (device support required) (not allowed to be delivered at the same time as StreamType))
        /// </summary>
        [JsonProperty("Resolution")]
        public string Resolution{ get; set; }

        /// <summary>
        /// Whether it is a private network
        /// </summary>
        [JsonProperty("IsInternal")]
        public bool? IsInternal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "Start", this.Start);
            this.SetParamSimple(map, prefix + "End", this.End);
            this.SetParamSimple(map, prefix + "StreamType", this.StreamType);
            this.SetParamSimple(map, prefix + "Resolution", this.Resolution);
            this.SetParamSimple(map, prefix + "IsInternal", this.IsInternal);
        }
    }
}

