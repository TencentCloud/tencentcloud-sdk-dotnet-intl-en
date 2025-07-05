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

    public class ReviewInfo : AbstractModel
    {
        
        /// <summary>
        /// The moderation template ID.
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// The suggestion. Valid values:
        /// <li>pass</li>
        /// <li>review</li>
        /// <li>block</li>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// The moderation type in the format of `Form.Label`. This parameter is valid if `Suggestion` is `review` or `block`.
        /// `Form` indicates the type of inappropriate content detected. Valid values:
        /// <li>`Image` (people or icons in images)</li>
        /// <li>`OCR` (text in images)</li>
        /// <li>`ASR` (speech)</li>
        /// <li>`Voice`</li>
        /// `Label` indicates the violation label. Valid values:
        /// <li>`Porn` (pornographic content)</li>
        /// <li>`Terror` (terrorist content)</li>
        /// <li>`Polity` (politically sensitive content)</li>
        /// <li>`Ad` (advertisement)</li>
        /// <li>`Illegal` (illegal content)</li>
        /// <li>`Abuse`</li>
        /// <li>`Moan`</li>
        /// </summary>
        [JsonProperty("TypeSet")]
        public string[] TypeSet{ get; set; }

        /// <summary>
        /// The moderation time in [ISO date format](https://intl.cloud.tencent.com/document/product/266/11732?from_cn_redirect=1#I).
        /// </summary>
        [JsonProperty("ReviewTime")]
        public string ReviewTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamArraySimple(map, prefix + "TypeSet.", this.TypeSet);
            this.SetParamSimple(map, prefix + "ReviewTime", this.ReviewTime);
        }
    }
}

