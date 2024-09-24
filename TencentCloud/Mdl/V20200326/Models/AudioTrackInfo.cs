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

namespace TencentCloud.Mdl.V20200326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AudioTrackInfo : AbstractModel
    {
        
        /// <summary>
        /// User input is limited to letters and numbers, the length should not exceed 20, and should not be repeated in the same channel.
        /// </summary>
        [JsonProperty("TrackName")]
        public string TrackName{ get; set; }

        /// <summary>
        /// Audio encoding format, only `AAC` and `PASSTHROUGH` are available, with `AAC` as the default.
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
        /// Only values defined by AttachedInputs.$.AudioSelectors.$.audioPidSelection.pid can be entered.
        /// </summary>
        [JsonProperty("AudioSelectorName")]
        public string AudioSelectorName{ get; set; }

        /// <summary>
        /// Audio loudness configuration.
        /// </summary>
        [JsonProperty("AudioNormalization")]
        public AudioNormalizationSettings AudioNormalization{ get; set; }

        /// <summary>
        /// Audio encoding configuration.
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

