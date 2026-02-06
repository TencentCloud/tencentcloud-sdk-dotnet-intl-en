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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTranscodeTemplatesRequest : AbstractModel
    {
        
        /// <summary>
        /// <b>The VOD [application](https://intl.cloud.tencent.com/document/product/266/14574) ID. For customers who activate VOD service from December 25, 2023, if they want to access resources in a VOD application (whether it's the default application or a newly created one), they must fill in this field with the application ID.</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Unique ID filter of transcoding templates. Array length limit: 100.
        /// </summary>
        [JsonProperty("Definitions")]
        public long?[] Definitions{ get; set; }

        /// <summary>
        /// Template type filter. Valid values:
        /// <li>Preset: preset template;</li>
        /// <li>Custom: custom template.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Container filter. Valid values:
        /// <li>Video: video container that can contain both video stream and audio stream;</li>
        /// <li>PureAudio: audio container that can contain only audio stream.</li>
        /// </summary>
        [JsonProperty("ContainerType")]
        public string ContainerType{ get; set; }

        /// <summary>
        /// TESHD filter, which is used to filter common transcoding or ultra-fast HD transcoding templates. Valid values:
        /// <li>Common: Common transcoding template;</li>
        /// <li>TEHD: TESHD template.</li>
        /// </summary>
        [JsonProperty("TEHDType")]
        public string TEHDType{ get; set; }

        /// <summary>
        /// Pagination offset. Default value: 0.
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Number of returned entries. Default value: 10. Maximum value: 100.
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Enhancement type. Valid values:
        /// <li>VideoEnhance: video enhancement only.</li>
        /// <li>AudioEnhance: audio enhancement only.</li>
        /// <li>AudioVideoEnhance: video and audio enhancement included.</li>
        /// <li> AnyEnhance: `VideoEnhance`, `AudioEnhance ` and `AudioVideoEnhance` included.</li>
        /// <li> None: Not any enhancement type</li>
        /// </summary>
        [JsonProperty("EnhanceType")]
        public string EnhanceType{ get; set; }

        /// <summary>
        /// Enhancement scenario configuration. Valid values:
        /// <li>common: common enhancement parameters, which are basic optimization parameters suitable for various video types, enhancing overall image quality.</li>
        /// <li>AIGC: overall resolution enhancement. It uses AI technology to improve the overall video resolution and image clarity.</li>
        /// <li>short_play: enhance facial and subtitle details, emphasizing characters' facial expressions and subtitle clarity to improve the viewing experience.</li>
        /// <li>short_video: optimize complex and diverse image quality issues, tailoring quality enhancements for the complex scenarios such as short videos to address various visual issues.</li>
        /// <li>game: fix motion blur and enhance details, with a focus on enhancing the clarity of game details and restoring blurry areas during motions to make the image content during gaming clearer and richer.</li>
        /// <li>HD_movie_series: provide a smooth playback effect for UHD videos. Standard 4K HDR videos with an FPS of 60 are generated to meet the needs of broadcasting/OTT for UHD videos. Formats for broadcasting scenarios are supported.</li>
        /// <li>LQ_material: low-definition material/old video restoration. It enhances overall resolution, and solves issues of old videos, such as low resolution, blur, distortion, scratches, and color temperature due to their age.</li>
        /// <li>lecture: live shows, e-commerce, conferences, and lectures. It improves the face display effect and performs specific optimizations, including face region enhancement, noise reduction, and artifacts removal, for scenarios involving human explanation, such as live shows, e-commerce, conferences, and lectures.</li>
        /// </summary>
        [JsonProperty("EnhanceScenarioType")]
        public string EnhanceScenarioType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamArraySimple(map, prefix + "Definitions.", this.Definitions);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ContainerType", this.ContainerType);
            this.SetParamSimple(map, prefix + "TEHDType", this.TEHDType);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "EnhanceType", this.EnhanceType);
            this.SetParamSimple(map, prefix + "EnhanceScenarioType", this.EnhanceScenarioType);
        }
    }
}

