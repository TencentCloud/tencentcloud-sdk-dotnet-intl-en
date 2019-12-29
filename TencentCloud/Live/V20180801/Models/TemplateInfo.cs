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

    public class TemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// Video encoding format:
        /// H.264/H.265.
        /// </summary>
        [JsonProperty("Vcodec")]
        public string Vcodec{ get; set; }

        /// <summary>
        /// Video bitrate in Kbps. Value range: 100-8,000
        /// </summary>
        [JsonProperty("VideoBitrate")]
        public long? VideoBitrate{ get; set; }

        /// <summary>
        /// Audio encoding format: AAC/MP3
        /// AAC/MP3.
        /// </summary>
        [JsonProperty("Acodec")]
        public string Acodec{ get; set; }

        /// <summary>
        /// Audio bitrate. Value range: 0-500
        /// </summary>
        [JsonProperty("AudioBitrate")]
        public long? AudioBitrate{ get; set; }

        /// <summary>
        /// Width. Value range: 0-3,000
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// Height. Value range: 0-3,000
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// Frame rate. Value range: 0-200
        /// </summary>
        [JsonProperty("Fps")]
        public long? Fps{ get; set; }

        /// <summary>
        /// Keyframe interval in seconds. Value range: 1-50
        /// </summary>
        [JsonProperty("Gop")]
        public long? Gop{ get; set; }

        /// <summary>
        /// Rotation angle. Value range: 0, 90, 180, 270
        /// </summary>
        [JsonProperty("Rotate")]
        public long? Rotate{ get; set; }

        /// <summary>
        /// Encoding quality:
        /// baseline/main/high.
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }

        /// <summary>
        /// Whether to not exceed the original bitrate. 0: no; 1: yes.
        /// </summary>
        [JsonProperty("BitrateToOrig")]
        public long? BitrateToOrig{ get; set; }

        /// <summary>
        /// Whether to not exceed the original height. 0: no; 1: yes.
        /// </summary>
        [JsonProperty("HeightToOrig")]
        public long? HeightToOrig{ get; set; }

        /// <summary>
        /// Whether to not exceed the original frame rate. 0: no; 1: yes.
        /// </summary>
        [JsonProperty("FpsToOrig")]
        public long? FpsToOrig{ get; set; }

        /// <summary>
        /// Whether to keep the video. 0: no; 1: yes.
        /// </summary>
        [JsonProperty("NeedVideo")]
        public long? NeedVideo{ get; set; }

        /// <summary>
        /// Whether to keep the audio. 0: no; 1: yes.
        /// </summary>
        [JsonProperty("NeedAudio")]
        public long? NeedAudio{ get; set; }

        /// <summary>
        /// Template ID.
        /// </summary>
        [JsonProperty("TemplateId")]
        public long? TemplateId{ get; set; }

        /// <summary>
        /// Template name
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// Template description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Whether it is an Ultra-fast HD template. 0: no; 1: yes. Default value: 0.
        /// </summary>
        [JsonProperty("AiTransCode")]
        public long? AiTransCode{ get; set; }

        /// <summary>
        /// VideoBitrate minus Ultra-fast HD bitrate. Value range: 0.1-0.5.
        /// </summary>
        [JsonProperty("AdaptBitratePercent")]
        public float? AdaptBitratePercent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Vcodec", this.Vcodec);
            this.SetParamSimple(map, prefix + "VideoBitrate", this.VideoBitrate);
            this.SetParamSimple(map, prefix + "Acodec", this.Acodec);
            this.SetParamSimple(map, prefix + "AudioBitrate", this.AudioBitrate);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
            this.SetParamSimple(map, prefix + "Gop", this.Gop);
            this.SetParamSimple(map, prefix + "Rotate", this.Rotate);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
            this.SetParamSimple(map, prefix + "BitrateToOrig", this.BitrateToOrig);
            this.SetParamSimple(map, prefix + "HeightToOrig", this.HeightToOrig);
            this.SetParamSimple(map, prefix + "FpsToOrig", this.FpsToOrig);
            this.SetParamSimple(map, prefix + "NeedVideo", this.NeedVideo);
            this.SetParamSimple(map, prefix + "NeedAudio", this.NeedAudio);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "AiTransCode", this.AiTransCode);
            this.SetParamSimple(map, prefix + "AdaptBitratePercent", this.AdaptBitratePercent);
        }
    }
}

