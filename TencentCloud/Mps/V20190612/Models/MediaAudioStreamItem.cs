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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaAudioStreamItem : AbstractModel
    {
        
        /// <summary>
        /// Bitrate of the audio stream. Unit: bps.
        /// </summary>
        [JsonProperty("Bitrate")]
        public long? Bitrate{ get; set; }

        /// <summary>
        /// Sampling rate of the audio stream. Unit: hz.
        /// </summary>
        [JsonProperty("SamplingRate")]
        public long? SamplingRate{ get; set; }

        /// <summary>
        /// Audio stream encoding format, for example, aac.
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Channel")]
        public long? Channel{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Codecs")]
        public string Codecs{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("Loudness")]
        public float? Loudness{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "SamplingRate", this.SamplingRate);
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "Codecs", this.Codecs);
            this.SetParamSimple(map, prefix + "Loudness", this.Loudness);
        }
    }
}

