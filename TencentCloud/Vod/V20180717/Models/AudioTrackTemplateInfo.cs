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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AudioTrackTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// Unique ID of a template.
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// Audio track encoder.
        /// When `Container` is `mp3`, the valid value is:
        /// <li>libmp3lame.</li>
        /// When `Container` is `ogg` or `flac`, the valid value is:
        /// <li>flac.</li>
        /// When `Container` is `m4a`, the valid values include:
        /// <li>libfdk_aac;</li>
        /// <li>libmp3lame;</li>
        /// <li>ac3.</li>
        /// When the video track's `Container` is `mp4` or `flv`, the valid values include:
        /// <li>libfdk_aac: more suitable for mp4;</li>
        /// <li>libmp3lame: more suitable for flv;</li>
        /// <li>mp2.</li>
        /// When the video track's `Container` is `hls`, the valid values include:
        /// <li>libfdk_aac;</li>
        /// <li>libmp3lame.</li>
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// Audio stream bitrate in Kbps. Value range: 0 and [26, 256].
        /// If the value is 0, the bitrate of the audio stream will be the same as that of the original audio.
        /// </summary>
        [JsonProperty("Bitrate")]
        public ulong? Bitrate{ get; set; }

        /// <summary>
        /// Audio stream sample rate. Valid values:
        /// <li>32,000</li>
        /// <li>44,100</li>
        /// <li>48,000</li>
        /// In Hz.
        /// </summary>
        [JsonProperty("SampleRate")]
        public ulong? SampleRate{ get; set; }

        /// <summary>
        /// Template type. Valid values:
        /// <li>Preset: preset template;</li>
        /// <li>Custom: custom template.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Template name. Length limit: 64 characters.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Template description. Length limit: 256 characters.
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// Audio channel system. Valid values:
        /// <li>1: Mono</li>
        /// <li>2: Dual</li>
        /// <li>6: Stereo</li>
        /// Default value: 2.
        /// </summary>
        [JsonProperty("AudioChannel")]
        public long? AudioChannel{ get; set; }

        /// <summary>
        /// Creation time of template in [ISO date format](https://cloud.tencent.com/document/product/266/11732#I).
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Last modified time of template in [ISO date format](https://cloud.tencent.com/document/product/266/11732#I).
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
            this.SetParamSimple(map, prefix + "SampleRate", this.SampleRate);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "AudioChannel", this.AudioChannel);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

