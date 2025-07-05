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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AudioParams : AbstractModel
    {
        
        /// <summary>
        /// The audio sample rate.
        /// 1: 48000 Hz (default)
        /// 2: 44100 Hz
        /// 3: 16000 Hz
        /// </summary>
        [JsonProperty("SampleRate")]
        public ulong? SampleRate{ get; set; }

        /// <summary>
        /// The number of sound channels.
        /// 1: Mono-channel
        /// 2: Dual-channel (default)
        /// </summary>
        [JsonProperty("Channel")]
        public ulong? Channel{ get; set; }

        /// <summary>
        /// The audio bitrate (bps). Value range: [32000, 128000]. Default: 64000.
        /// </summary>
        [JsonProperty("BitRate")]
        public ulong? BitRate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "BitRate", this.BitRate);
        }
    }
}

