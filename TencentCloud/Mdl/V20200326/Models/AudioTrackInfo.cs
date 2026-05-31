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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AudioTrackInfo : AbstractModel
    {
        
        /// <summary>
        /// User input, limited to letters and digits, length not exceeding 20, non-repeating in the same channel.
        /// </summary>
        [JsonProperty("TrackName")]
        public string TrackName{ get; set; }

        /// <summary>
        /// Audio encoding format, can only be `AAC` or `PASSTHROUGH`. Default is AAC.
        /// </summary>
        [JsonProperty("AudioCodec")]
        public string AudioCodec{ get; set; }

        /// <summary>
        /// Audio bitrate.
        /// </summary>
        [JsonProperty("AudioBitrate")]
        public ulong? AudioBitrate{ get; set; }

        /// <summary>
        /// Audio sample rate.
        /// </summary>
        [JsonProperty("AudioSampleRate")]
        public ulong? AudioSampleRate{ get; set; }

        /// <summary>
        /// Input Only the value defined in AttachedInputs.$.AudioSelectors.$.audioPidSelection.pid.
        /// </summary>
        [JsonProperty("AudioSelectorName")]
        public string AudioSelectorName{ get; set; }

        /// <summary>
        /// Audio loudness configuration.
        /// </summary>
        [JsonProperty("AudioNormalization")]
        public AudioNormalizationSettings AudioNormalization{ get; set; }

        /// <summary>
        /// Additional audio mode and sound channel configuration.
        /// </summary>
        [JsonProperty("AudioCodecDetails")]
        public AudioCodecDetail AudioCodecDetails{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TrackName", this.TrackName);
            this.SetParamSimple(map, prefix + "AudioCodec", this.AudioCodec);
            this.SetParamSimple(map, prefix + "AudioBitrate", this.AudioBitrate);
            this.SetParamSimple(map, prefix + "AudioSampleRate", this.AudioSampleRate);
            this.SetParamSimple(map, prefix + "AudioSelectorName", this.AudioSelectorName);
            this.SetParamObj(map, prefix + "AudioNormalization.", this.AudioNormalization);
            this.SetParamObj(map, prefix + "AudioCodecDetails.", this.AudioCodecDetails);
        }
    }
}

