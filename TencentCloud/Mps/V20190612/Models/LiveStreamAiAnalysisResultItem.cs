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

    public class LiveStreamAiAnalysisResultItem : AbstractModel
    {
        
        /// <summary>
        /// Result type. Valid values:
        /// <li>SegmentRecognition: video splitting.</li>
        /// <li>Highlight: highlight.</li>
        /// <li>Description: summary.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("SegmentResultSet")]
        public SegmentRecognitionItem[] SegmentResultSet{ get; set; }

        /// <summary>
        /// Highlight result. This field is valid when Type is set to Highlight.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HighlightResultSet")]
        public MediaAiAnalysisHighlightItem[] HighlightResultSet{ get; set; }

        /// <summary>
        /// Summary result. It is valid when Type is Description.
        /// </summary>
        [JsonProperty("DescriptionResult")]
        public LiveAiAnalysisDescriptionItem DescriptionResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "SegmentResultSet.", this.SegmentResultSet);
            this.SetParamArrayObj(map, prefix + "HighlightResultSet.", this.HighlightResultSet);
            this.SetParamObj(map, prefix + "DescriptionResult.", this.DescriptionResult);
        }
    }
}

