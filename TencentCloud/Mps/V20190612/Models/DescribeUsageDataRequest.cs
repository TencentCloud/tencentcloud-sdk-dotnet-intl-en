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

    public class DescribeUsageDataRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Start date. Use ISO date format.</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>End date, which must be greater than or equal to the start date. Use the <a href="https://www.tencentcloud.com/document/product/862/37710?from_cn_redirect=1#52">ISO date format</a>.</p><p>Parameter format: 2019-07-16T06:21:28Z.</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>Media processing task type to query. Default value: Transcode. Valid values: </p><li>Transcode: Transcoding, </li><li>Enhance: Enhancement, </li><li>AIAnalysis: AI Analysis, </li><li>AIRecognition: AI Recognition, </li><li>AIReview: AI Review, </li><li>Snapshot: Snapshot, </li><li>AnimatedGraphics: Animated Graphics, </li><li>AiQualityControl: Quality Control, </li><li>Evaluation: Video Evaluation, </li><li>ImageProcess: Image Processing, </li><li>AddBlindWatermark: Add Basic Copyright Digital Watermark, </li><li>AddNagraWatermark: Add NAGRA Digital Watermark, </li><li>ExtractBlindWatermark: Extract Basic Copyright Digital Watermark, </li><li>AIGCVideo: AIGC Video Generation, </li><li>AIGCImage: AIGC Image Generation.</li>
        /// </summary>
        [JsonProperty("Types")]
        public string[] Types{ get; set; }

        /// <summary>
        /// <p>Media processing region. Default value: ap-guangzhou. Valid values: </p><li>ap-guangzhou: Guangzhou, </li><li>ap-hongkong: Hong Kong (China), </li><li>ap-taipei: Taiwan (China), </li><li>ap-singapore: Singapore, </li><li>ap-mumbai: India, </li><li>ap-jakarta: Jakarta, </li><li>ap-seoul: Seoul, </li><li>ap-bangkok: Thailand, </li><li>ap-tokyo: Japan, </li><li>na-siliconvalley: Silicon Valley (USA), </li><li>na-ashburn: Virginia, </li><li>na-toronto: Toronto, </li><li>sa-saopaulo: Sao Paulo, </li><li>eu-frankfurt: Frankfurt, </li><li>eu-moscow: Russia, </li><li>aws: AWS.</li>
        /// </summary>
        [JsonProperty("ProcessRegions")]
        public string[] ProcessRegions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArraySimple(map, prefix + "Types.", this.Types);
            this.SetParamArraySimple(map, prefix + "ProcessRegions.", this.ProcessRegions);
        }
    }
}

