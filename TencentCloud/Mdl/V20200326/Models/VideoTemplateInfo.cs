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

    public class VideoTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// Video transcoding template name, which can contain 1-20 letters and digits.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Video codec. Valid values: H264/H265. If this parameter is left empty, the original value will be used.
        /// </summary>
        [JsonProperty("Vcodec")]
        public string Vcodec{ get; set; }

        /// <summary>
        /// Video bitrate. Value range: [50000,40000000]. The value can only be a multiple of 1,000. If this parameter is left empty, the original value will be used.
        /// </summary>
        [JsonProperty("VideoBitrate")]
        public ulong? VideoBitrate{ get; set; }

        /// <summary>
        /// Video width. Value range: (0,3000]. The value can only be a multiple of 4. If this parameter is left empty, the original value will be used.
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// Video height. Value range: (0,3000]. The value can only be a multiple of 4. If this parameter is left empty, the original value will be used.
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// Video frame rate. Value range: [1,240]. If this parameter is left empty, the original value will be used.
        /// </summary>
        [JsonProperty("Fps")]
        public ulong? Fps{ get; set; }

        /// <summary>
        /// Whether to enable top speed codec. Valid value: CLOSE/OPEN. Default value: CLOSE.
        /// </summary>
        [JsonProperty("TopSpeed")]
        public string TopSpeed{ get; set; }

        /// <summary>
        /// Top speed codec compression ratio. Value range: [0,50]. The lower the compression ratio, the higher the image quality.
        /// </summary>
        [JsonProperty("BitrateCompressionRatio")]
        public ulong? BitrateCompressionRatio{ get; set; }

        /// <summary>
        /// Bitrate control mode. Valid values: `CBR`, `ABR` (default)
        /// </summary>
        [JsonProperty("RateControlMode")]
        public string RateControlMode{ get; set; }

        /// <summary>
        /// Watermark ID
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("WatermarkId")]
        public string WatermarkId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Vcodec", this.Vcodec);
            this.SetParamSimple(map, prefix + "VideoBitrate", this.VideoBitrate);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Fps", this.Fps);
            this.SetParamSimple(map, prefix + "TopSpeed", this.TopSpeed);
            this.SetParamSimple(map, prefix + "BitrateCompressionRatio", this.BitrateCompressionRatio);
            this.SetParamSimple(map, prefix + "RateControlMode", this.RateControlMode);
            this.SetParamSimple(map, prefix + "WatermarkId", this.WatermarkId);
        }
    }
}

