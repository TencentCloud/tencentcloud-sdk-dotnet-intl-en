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

    public class PornImgReviewTemplateInfoForUpdate : AbstractModel
    {
        
        /// <summary>
        /// <p>Task switch for image recognition involving offensive content. Available values:</p><li>ON: Enable the task of image recognition involving offensive content;</li><li>OFF: Disable the task of image recognition involving offensive content.</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// <p>Image recognition filter tags for offensive content. The review results including the selected tags are returned. If the filter tag is empty, all review results will be returned. Valid values:</p><li>porn: Pornography;</li><li>vulgar: Vulgarity;</li><li>intimacy: Intimate behavior;</li><li>sexy: Sexiness.</li>
        /// </summary>
        [JsonProperty("LabelSet")]
        public string[] LabelSet{ get; set; }

        /// <summary>
        /// <p>Threshold score for determining suspected violations. When the review score reaches or exceeds this threshold, it is deemed a suspected violation. Value range: 0–100.</p>
        /// </summary>
        [JsonProperty("BlockConfidence")]
        public long? BlockConfidence{ get; set; }

        /// <summary>
        /// <p>Threshold score for determining whether manual review is required for violations. When the review score reaches or exceeds this threshold, manual review is deemed necessary. Value range: 0–100.</p>
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

