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

    public class AiReviewPoliticalTaskOutput : AbstractModel
    {
        
        /// <summary>
        /// Score of inappropriate information in the video. Value range: 0-100.
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// Result suggestions involving inappropriate information. Value range:
        /// <li>pass.</li>
        /// <li>review.</li>
        /// <li>block.</li>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// Result tag for videos involving inappropriate information. Mapping between the LabelSet parameter in the screen image authentication task control parameter (https://www.tencentcloud.com/document/api/266/31773?from_cn_redirect=1#PoliticalImgReviewTemplateInfo) of the audio/video moderation template and the value range of this parameter:
        /// violation_photo:
        /// <li>violation_photo: Violation icon.</li>
        /// Other (politician/entertainment/sport/entrepreneur/scholar/celebrity/military):
        /// <li>politician: relevant people.</li>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// List of video segments suspected of involving inappropriate information.
        /// <font color=red>Note</font>: This list can only display up to the first 100 elements. To obtain the complete result, get it from the file corresponding to SegmentSetFileUrl.
        /// </summary>
        [JsonProperty("SegmentSet")]
        public MediaContentReviewPoliticalSegmentItem[] SegmentSet{ get; set; }

        /// <summary>
        /// URL of the segment list file that may contain inappropriate information. The file content is in JSON format, and its data structure is consistent with the SegmentSet fields. (The file will not be retained permanently. It will be deleted after the SegmentSetFileUrlExpireTime is reached.)
        /// </summary>
        [JsonProperty("SegmentSetFileUrl")]
        public string SegmentSetFileUrl{ get; set; }

        /// <summary>
        /// Expiration time of the URL of the Segment List File of the video suspected of involving inappropriate information in [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
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
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamArrayObj(map, prefix + "SegmentSet.", this.SegmentSet);
            this.SetParamSimple(map, prefix + "SegmentSetFileUrl", this.SegmentSetFileUrl);
            this.SetParamSimple(map, prefix + "SegmentSetFileUrlExpireTime", this.SegmentSetFileUrlExpireTime);
        }
    }
}

