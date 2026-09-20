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

    public class UserDefineOcrTextReviewTemplateInfoForUpdate : AbstractModel
    {
        
        /// <summary>
        /// Switch for custom text audio/video moderation tasks. Available values:
        /// <li>ON: enable custom text, audio, and video moderation tasks;</li>
        /// <li>OFF: Disable the custom text audio/video moderation task.</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// User-customized text filter tags. The audio/video moderation results including the selected tags are returned. If the filter tag is empty, all audio/video moderation results will be returned. To use the tag filtering feature, the corresponding tag needs to be added when adding custom text keyword material.
        /// The number of tags can be up to 10, and each tag can contain up to 16 characters.
        /// </summary>
        [JsonProperty("LabelSet")]
        public string[] LabelSet{ get; set; }

        /// <summary>
        /// Threshold score for determining suspected violations. When the review score reaches or exceeds this threshold, it is deemed a suspected violation. Value range: 0–100.
        /// </summary>
        [JsonProperty("BlockConfidence")]
        public long? BlockConfidence{ get; set; }

        /// <summary>
        /// Threshold score for determining whether manual review is required for violations. When the review score reaches or exceeds this threshold, manual review is deemed necessary. Value range: 0–100.
        /// </summary>
        [JsonProperty("ReviewConfidence")]
        public long? ReviewConfidence{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamArraySimple(map, prefix + "LabelSet.", this.LabelSet);
            this.SetParamSimple(map, prefix + "BlockConfidence", this.BlockConfidence);
            this.SetParamSimple(map, prefix + "ReviewConfidence", this.ReviewConfidence);
        }
    }
}

