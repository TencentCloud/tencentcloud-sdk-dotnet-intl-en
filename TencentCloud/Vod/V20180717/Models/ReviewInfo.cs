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
        /// Content review template ID.
        /// </summary>
        [JsonProperty("Definition")]
        public ulong? Definition{ get; set; }

        /// <summary>
        /// Review result suggestion. Valid values:
        /// <li>pass: It is recommended to pass.</li>
        /// <li>review: suggest re-examination;</li>
        /// <li>block: suggest banning.</li>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// Moderation type. Valid when Suggestion is review or block. Format: Form.Label.
        /// Form indicates the prohibited form. Value range:
        /// <li>Image: people or icons on the screen;</li>
        /// <li>OCR: text on the screen;</li>
        /// <li>ASR: text in speech.</li>
        /// <li>Voice: sound.</li>
        /// Label refers to prohibited tags. Value range:
        /// <li>Porn: Pornography;</li>
        /// <li>Terror: violence.</li>
        /// <li>Polity: inappropriate information;</li>
        /// <li>Ad: advertisement;</li>
        /// <li>Illegal: Violating laws or regulations;</li>
        /// <li>Abuse: abusive language;</li>
        /// <li>Moan: panting.</li>
        /// </summary>
        [JsonProperty("TypeSet")]
        public string[] TypeSet{ get; set; }

        /// <summary>
        /// Moderation time in [ISO date format](https://www.tencentcloud.com/document/product/266/11732?from_cn_redirect=1#I).
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

