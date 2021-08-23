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

    public class AVTemplate : AbstractModel
    {
        
        /// <summary>
        /// Name of an audio/video transcoding template, which can contain 1-20 case-sensitive letters and digits
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Whether video is needed. `0`: not needed; `1`: needed
        /// </summary>
        [JsonProperty("NeedVideo")]
        public ulong? NeedVideo{ get; set; }

        /// <summary>
        /// Video codec. Valid values: `H264`, `H265`. If this parameter is left empty, the original video codec will be used.
        /// </summary>
        [JsonProperty("Vcodec")]
        public string Vcodec{ get; set; }

        /// <summary>
        /// Video width. Value range: (0, 3000]. The value must be an integer multiple of 4. If this parameter is left empty, the original video width will be used.
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// Video height. Value range: (0, 3000]. The value must be an integer multiple of 4. If this parameter is left empty, the original video height will be used.
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// Video frame rate. Value range: [1, 240]. If this parameter is left empty, the original frame rate will be used.
        /// </summary>
        [JsonProperty("Fps")]
        public ulong? Fps{ get; set; }

        /// <summary>
        /// Whether to enable top speed codec transcoding. Valid values: `CLOSE` (disable), `OPEN` (enable). Default value: `CLOSE`
        /// </summary>
        [JsonProperty("TopSpeed")]
        public string TopSpeed{ get; set; }

        /// <summary>
        /// Compression ratio for top speed codec transcoding. Value range: [0, 50]. The lower the compression ratio, the higher the image quality.
        /// </summary>
        [JsonProperty("BitrateCompressionRatio")]
        public ulong? BitrateCompressionRatio{ get; set; }

        /// <summary>
        /// Whether audio is needed. `0`: not needed; `1`: needed
        /// </summary>
        [JsonProperty("NeedAudio")]
        public long? NeedAudio{ get; set; }

        /// <summary>
        /// Audio codec. Valid value: `AAC` (default)
        /// </summary>
        [JsonProperty("Acodec")]
        public string Acodec{ get; set; }

        /// <summary>
        /// Audio bitrate. If this parameter is left empty, the original bitrate will be used.
        /// Valid values: `6000`, `7000`, `8000`, `10000`, `12000`, `14000`, `16000`, `20000`, `24000`, `28000`, `32000`, `40000`, `48000`, `56000`, `64000`, `80000`, `96000`, `112000`, `128000`, `160000`, `192000`, `224000`, `256000`, `288000`, `320000`, `384000`, `448000`, `512000`, `576000`, `640000`, `768000`, `896000`, `1024000`
        /// </summary>
        [JsonProperty("AudioBitrate")]
        public ulong? AudioBitrate{ get; set; }

        /// <summary>
        /// Video bitrate. Value range: [50000, 40000000]. The value must be an integer multiple of 1000. If this parameter is left empty, the original bitrate will be used.
        /// </summary>
        [JsonProperty("VideoBitrate")]
        public ulong? VideoBitrate{ get; set; }

        /// <summary>
        /// Bitrate control mode. Valid values: `CBR`, `ABR` (default)
        /// </summary>
        [JsonProperty("RateControlMode")]
        public string RateControlMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "NeedVideo", this.NeedVideo);
            this.SetParamSimple(map, prefix + "Vcodec", this.Vcodec);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
            this.SetParamSimple(map, prefix + "TopSpeed", this.TopSpeed);
            this.SetParamSimple(map, prefix + "BitrateCompressionRatio", this.BitrateCompressionRatio);
            this.SetParamSimple(map, prefix + "NeedAudio", this.NeedAudio);
            this.SetParamSimple(map, prefix + "Acodec", this.Acodec);
            this.SetParamSimple(map, prefix + "AudioBitrate", this.AudioBitrate);
            this.SetParamSimple(map, prefix + "VideoBitrate", this.VideoBitrate);
            this.SetParamSimple(map, prefix + "RateControlMode", this.RateControlMode);
        }
    }
}

