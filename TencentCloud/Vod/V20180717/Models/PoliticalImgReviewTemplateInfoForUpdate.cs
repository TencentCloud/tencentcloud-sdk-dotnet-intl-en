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

    public class PoliticalImgReviewTemplateInfoForUpdate : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable recognition of politically sensitive content in images. Valid values:
        /// <li>ON</li>
        /// <li>OFF</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Filter labels for recognition of politically sensitive content in images. Results containing the specified labels are returned. If no labels are specified, all results are returned. Valid values:
        /// <li>`violation_photo`: banned images</li>
        /// <li>`politician`: politically sensitive people</li>
        /// <li>`entertainment`: people in the entertainment industry</li>
        /// <li>`sport`: sportspeople</li>
        /// <li>`entrepreneur`: businesspeople</li>
        /// <li>`scholar`: scholars</li>
        /// <li>`celebrity`: celebrities</li>
        /// <li>`military`: people in military</li>
        /// </summary>
        [JsonProperty("LabelSet")]
        public string[] LabelSet{ get; set; }

        /// <summary>
        /// Confidence score threshold for determining that something should be blocked. If this threshold is reached, VOD will suggest that the content be blocked. Value range: 0-100
        /// </summary>
        [JsonProperty("BlockConfidence")]
        public long? BlockConfidence{ get; set; }

        /// <summary>
        /// Confidence score threshold for human review. If this threshold is reached, human review is needed. Value range: 0-100
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

