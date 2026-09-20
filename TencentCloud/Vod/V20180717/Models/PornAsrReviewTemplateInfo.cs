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

    public class PornAsrReviewTemplateInfo : AbstractModel
    {
        
        /// <summary>
        /// Task switch for ASR-based recognition involving offensive content. Available values:
        /// <li>ON: enable the task involving ASR-based recognition of offensive content;</li>
        /// <li>OFF: Disable the task involving offensive content in ASR-based recognition.</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Threshold score for determining suspected violations. When the review score reaches this threshold or above, it is considered a suspected violation. If not specified, it defaults to 100 points. Value range: 0–100.
        /// </summary>
        [JsonProperty("BlockConfidence")]
        public long? BlockConfidence{ get; set; }

        /// <summary>
        /// Threshold score for determining whether manual review is required for violations. When the review score reaches or exceeds this threshold, manual review is considered necessary. If not specified, the default is 75 points. Value range: 0–100.
        /// </summary>
        [JsonProperty("ReviewConfidence")]
        public long? ReviewConfidence{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "BlockConfidence", this.BlockConfidence);
            this.SetParamSimple(map, prefix + "ReviewConfidence", this.ReviewConfidence);
        }
    }
}

