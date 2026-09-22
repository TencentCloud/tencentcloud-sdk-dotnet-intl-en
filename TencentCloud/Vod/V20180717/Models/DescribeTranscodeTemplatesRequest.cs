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
        /// <b>VOD [application](https://www.tencentcloud.com/document/product/266/14574?from_cn_redirect=1) ID. For customers who activate VOD after December 25, 2023, this field must be set to the app ID when accessing resources in VOD applications (whether the default application or a newly created application).</b>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// Filtering condition for the unique identifier of the transcoding template. The array length cannot exceed 100.
        /// </summary>
        [JsonProperty("Definitions")]
        public long?[] Definitions{ get; set; }

        /// <summary>
        /// Condition for filtering templates by type. Valid values:
        /// <li>Preset: system-preset template;</li>
        /// <li>Custom: custom template.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Muxing format filter criteria. Available values:
        /// <li>Video: Video format. A container format that can contain both video and audio streams.</li>
        /// <li>PureAudio: Pure audio format, a container format that can only contain audio streams.</li>
        /// </summary>
        [JsonProperty("ContainerType")]
        public string ContainerType{ get; set; }

        /// <summary>
        /// TSC filter criteria for filtering standard or TSC transcoding templates. Available values:
        /// <li>Common: standard transcoding template;</li>
        /// <li>TEHD: Ultra-HD template.</li>
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
        /// <li>AudioEnhance (audio enhancement only).</li>
        /// <li>AudioVideoEnhance: audio and video enhancement.</li>
        /// <li>AnyEnhance (including video enhancement only, audio enhancement only, and audio and video enhancement)</li>
        /// <li>None (non-enhanced)</li>
        /// </summary>
        [JsonProperty("EnhanceType")]
        public string EnhanceType{ get; set; }

        /// <summary>
        /// Enhancement scenario configuration. Available values: <li>common: general enhancement parameters, basic optimization parameters suitable for various video types to improve overall video quality.</li> <li>AIGC: overall resolution enhancement, using AI technology to improve the overall video resolution and enhance image clarity.</li> <li>short_play: enhance face and subtitle details, highlight facial expression details and subtitle clarity to improve the viewing experience.</li> <li>short_video: optimize complex and diverse image quality issues, optimize video quality for complex short video scenarios and address multiple visual issues.</li> <li>game: repair motion blur and enhance details, focusing on improving the clarity of game details, restoring motion blur areas, and making game screen content clearer and richer.</li> <li>HD_movie_series: obtain ultra-high-definition smooth effects, generate 4K 60fps HDR ultra-high-definition standard videos for UHD video demands in broadcasting and OTT. Support broadcasting scenario format standards.</li> <li>LQ_material: overall resolution enhancement, specially optimized for issues in old videos such as insufficient resolution, blur distortion, scratch damage, and color temperature caused by older shooting conditions.</li> <li>lecture: beautify and enhance face effects, specially optimized for face region, noise reduction, and burr processing in scenarios where people explain content, such as live shows, e-commerce, conferences, and lectures.</li>
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

