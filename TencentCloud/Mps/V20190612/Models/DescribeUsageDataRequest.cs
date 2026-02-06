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
        /// Start date. Use the [ISO date and time format](https://www.tencentcloud.comom/document/product/266/11732?from_cn_redirect=1#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F).
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// End date, which should be greater than or equal to the start date. Use the [ISO date and time format](https://www.tencentcloud.comom/document/product/266/11732?from_cn_redirect=1#iso-.E6.97.A5.E6.9C.9F.E6.A0.BC.E5.BC.8F).
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Type of MPS tasks to query. The transcoding tasks are queried by default.<li>Transcode: transcoding.</li><li>Enhance: enhancement.</li><li>AIAnalysis: intelligent analysis.</li><li>AIRecognition: intelligent identification.</li><li>AIReview: content moderation.</li><li>Snapshot: screenshot.</li><li>AnimatedGraphics: animated graphics.</li><li>AiQualityControl: quality inspection.</li><li>Evaluation: video evaluation.</li><li>ImageProcess: image processing.</li>
        /// <li>AddBlindWatermark: adding basic copyright digital watermarks.</li><li>AddNagraWatermark: adding NAGRA digital watermarks.</li><li>ExtractBlindWatermark: extracting basic copyright digital watermarks.</li><li>AIGC: AIGC</li>
        /// </summary>
        [JsonProperty("Types")]
        public string[] Types{ get; set; }

        /// <summary>
        /// MPS park. ap-guangzhou park is returned by default.
        /// <li>ap-guangzhou: Guangzhou.</li>
        /// <li>ap-hongkong: Hong Kong (China).</li>
        /// <li>ap-taipei: Taipei (China).</li>
        /// <li>ap-singapore: Singapore.</li>
        /// <li>ap-mumbai: India.</li>
        /// <li>ap-jakarta: Jakarta.</li>
        /// <li>ap-seoul: Seoul.</li>
        /// <li>ap-bangkok: Thailand.</li>
        /// <li>ap-tokyo: Japan.</li>
        /// <li>na-siliconvalley: Silicon Valley.</li>
        /// <li>na-ashburn: Virginia.</li>
        /// <li>na-toronto: Toronto.</li>
        /// <li>sa-saopaulo: Sao Paulo.</li>
        /// <li>eu-frankfurt: Frankfurt.</li>
        /// <li>eu-moscow: Russia.</li>
        /// <li>aws: AWS.</li>
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

