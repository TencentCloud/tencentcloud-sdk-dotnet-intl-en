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

    public class AiReviewProhibitedAsrTaskOutput : AbstractModel
    {
        
        /// <summary>
        /// Asr text violation score. Value range: 0-100.
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// Asr text violation result suggestion. Value range:
        /// <li>pass.</li>
        /// <li>review.</li>
        /// <li>block.</li>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// List of video segments whose Asr text is suspected of prohibition violations.
        /// <font color=red>Note</font>: This list can only show up to the first 100 elements. To obtain the complete result, get it from the file corresponding to SegmentSetFileUrl.
        /// </summary>
        [JsonProperty("SegmentSet")]
        public MediaContentReviewAsrTextSegmentItem[] SegmentSet{ get; set; }

        /// <summary>
        /// URL of the video segment list file where the Asr text is suspected of prohibition violations. The content of the file is in JSON format, and its data structure is consistent with the fields of SegmentSet. (The file is not retained permanently and will be deleted after reaching SegmentSetFileUrlExpireTime.)
        /// </summary>
        [JsonProperty("SegmentSetFileUrl")]
        public string SegmentSetFileUrl{ get; set; }

        /// <summary>
        /// Expiration time of the file URL of the video segment list where the Asr text is suspected of prohibition violations, in [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("SegmentSetFileUrlExpireTime")]
        public string SegmentSetFileUrlExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamArrayObj(map, prefix + "SegmentSet.", this.SegmentSet);
            this.SetParamSimple(map, prefix + "SegmentSetFileUrl", this.SegmentSetFileUrl);
            this.SetParamSimple(map, prefix + "SegmentSetFileUrlExpireTime", this.SegmentSetFileUrlExpireTime);
        }
    }
}

