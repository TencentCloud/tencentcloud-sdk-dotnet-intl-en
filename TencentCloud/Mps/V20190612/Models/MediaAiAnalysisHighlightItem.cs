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

    public class MediaAiAnalysisHighlightItem : AbstractModel
    {
        
        /// <summary>
        /// Intelligent highlight address.
        /// </summary>
        [JsonProperty("HighlightPath")]
        public string HighlightPath{ get; set; }

        /// <summary>
        /// Intelligent highlight cover address.
        /// </summary>
        [JsonProperty("CovImgPath")]
        public string CovImgPath{ get; set; }

        /// <summary>
        /// Reliability of the intelligent highlights, with a value range from 0 to 100.
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// Intelligent highlight duration.
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// Intelligent highlight sub-clip list.
        /// </summary>
        [JsonProperty("SegmentSet")]
        public HighlightSegmentItem[] SegmentSet{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("HighlightUrl")]
        public string HighlightUrl{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("CovImgUrl")]
        public string CovImgUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HighlightPath", this.HighlightPath);
            this.SetParamSimple(map, prefix + "CovImgPath", this.CovImgPath);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamArrayObj(map, prefix + "SegmentSet.", this.SegmentSet);
            this.SetParamSimple(map, prefix + "HighlightUrl", this.HighlightUrl);
            this.SetParamSimple(map, prefix + "CovImgUrl", this.CovImgUrl);
        }
    }
}

