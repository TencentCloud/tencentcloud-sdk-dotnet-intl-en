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

    public class ContentReviewOcrResult : AbstractModel
    {
        
        /// <summary>
        /// <p>Score of the Ocr text identification result. The score ranges from 0 to 100.</p>
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// <p>Result suggestions for Ocr text identification. Value range:</p><li>pass;</li><li>review;</li><li>block.</li>
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// <p>List of suspicious keywords for Ocr text identification.</p>
        /// </summary>
        [JsonProperty("KeywordSet")]
        public string[] KeywordSet{ get; set; }

        /// <summary>
        /// <p>Area coordinates (pixel-level) where suspected text appears in Ocr text identification, [x1, y1, x2, y2], i.e., coordinates of the top-left corner and coordinate of the bottom-right corner.</p>
        /// </summary>
        [JsonProperty("AreaCoordSet")]
        public long?[] AreaCoordSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamArraySimple(map, prefix + "KeywordSet.", this.KeywordSet);
            this.SetParamArraySimple(map, prefix + "AreaCoordSet.", this.AreaCoordSet);
        }
    }
}

