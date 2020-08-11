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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AiReviewPoliticalTaskOutput : AbstractModel
    {
        
        /// <summary>
        /// Score of detected politically sensitive information in video between 0 and 100.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// Suggestion for detected politically sensitive information. Valid values:
        /// <li>pass.</li>
        /// <li>review.</li>
        /// <li>block.</li>
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// Tags for the results of video politically sensitive information detection. The relationship between the `LabelSet` parameter in the content audit template [controlling tasks of video politically sensitive information detection](https://intl.cloud.tencent.com/document/api/266/34187#PoliticalImgReviewTemplateInfo?from_cn_redirect=1) and this parameter is as follows:
        /// violation_photo:
        /// <li>violation_photo: violating photo.</li>
        /// Other values (politician/entertainment/sport/entrepreneur/scholar/celebrity/military):
        /// <li>politician: political figure.</li>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// List of video segments that contain the detected politically sensitive information.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SegmentSet")]
        public MediaContentReviewPoliticalSegmentItem[] SegmentSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamArrayObj(map, prefix + "SegmentSet.", this.SegmentSet);
        }
    }
}

