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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// Codec: h264/h265/origin. Default value: h264.
        /// 
        /// origin: keep the original codec.
        /// </summary>
        [JsonProperty("Vcodec")]
        public string Vcodec{ get; set; }

        /// <summary>
        /// Video bitrate. Value range: 0–8,000 Kbps.
        /// If the value is 0, the original bitrate will be retained.
        /// Note: transcoding templates require a unique bitrate. The final saved bitrate may differ from the input bitrate.
        /// </summary>
        [JsonProperty("VideoBitrate")]
        public long? VideoBitrate{ get; set; }

        /// <summary>
        /// Audio codec: aac. Default value: aac.
        /// Note: This parameter will not take effect for now and will be supported soon.
        /// </summary>
        [JsonProperty("Acodec")]
        public string Acodec{ get; set; }

        /// <summary>
        /// Audio bitrate. Value range: 0–500 Kbps.
        /// 0 by default.
        /// </summary>
        [JsonProperty("AudioBitrate")]
        public long? AudioBitrate{ get; set; }

        /// <summary>
        /// Width. Default value: 0.
        /// Value range: [0-3,000].
        /// The value must be a multiple of 2. The original width is 0.
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// Height. Default value: 0.
        /// Value range: [0-3,000].
        /// The value must be a multiple of 2. The original width is 0.
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// Frame rate. Default value: 0.
        /// Range: 0-60 Fps.
        /// </summary>
        [JsonProperty("Fps")]
        public long? Fps{ get; set; }

        /// <summary>
        /// Keyframe interval, unit: second.
        /// Original interval by default
        /// Range: 2-6
        /// </summary>
        [JsonProperty("Gop")]
        public long? Gop{ get; set; }

        /// <summary>
        /// Rotation angle. Default value: 0.
        /// Value range: 0, 90, 180, 270
        /// </summary>
        [JsonProperty("Rotate")]
        public long? Rotate{ get; set; }

        /// <summary>
        /// Encoding quality:
        /// baseline/main/high. Default value: baseline.
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }

        /// <summary>
        /// Whether to use the original bitrate when the set bitrate is larger than the original bitrate.
        /// 0: no, 1: yes
        /// Default value: 0.
        /// </summary>
        [JsonProperty("BitrateToOrig")]
        public long? BitrateToOrig{ get; set; }

        /// <summary>
        /// Whether to use the original height when the set height is higher than the original height.
        /// 0: no, 1: yes
        /// Default value: 0.
        /// </summary>
        [JsonProperty("HeightToOrig")]
        public long? HeightToOrig{ get; set; }

        /// <summary>
        /// Whether to use the original frame rate when the set frame rate is larger than the original frame rate.
        /// 0: no, 1: yes
        /// Default value: 0.
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
        /// Template name.
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// Template description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Whether it is a top speed codec template. 0: no, 1: yes. Default value: 0.
        /// </summary>
        [JsonProperty("AiTransCode")]
        public long? AiTransCode{ get; set; }

        /// <summary>
        /// Bitrate compression ratio of top speed code video.
        /// Target bitrate of top speed code = VideoBitrate * (1-AdaptBitratePercent)
        /// 
        /// Value range: 0.0-0.5.
        /// </summary>
        [JsonProperty("AdaptBitratePercent")]
        public float? AdaptBitratePercent{ get; set; }

        /// <summary>
        /// Whether to take the shorter side as height. 0: no, 1: yes. Default value: 0.
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("ShortEdgeAsHeight")]
        public long? ShortEdgeAsHeight{ get; set; }

        /// <summary>
        /// The DRM encryption type. Valid values: fairplay, normalaes, widevine.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DRMType")]
        public string DRMType{ get; set; }

        /// <summary>
        /// The tracks to encrypt. Valid values: AUDIO, SD, HD, UHD1, UHD2. Separate multiple tracks with “|”. You can choose only one video track (SD, HD, UHD1, or UHD2).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DRMTracks")]
        public string DRMTracks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
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
            this.SetParamSimple(map, prefix + "ShortEdgeAsHeight", this.ShortEdgeAsHeight);
            this.SetParamSimple(map, prefix + "DRMType", this.DRMType);
            this.SetParamSimple(map, prefix + "DRMTracks", this.DRMTracks);
        }
    }
}

