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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RetrievalLivenessExtraInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Type of the matched template. Common: public library; Auto: automatic clustering library; Owner: custom template library.</p>
        /// </summary>
        [JsonProperty("HitGroup")]
        public string HitGroup{ get; set; }

        /// <summary>
        /// <p>Similarity between the request image and the matched attack template. The value range is [0,2]. A smaller value indicates a higher probability of matching an attack template. The default threshold is 0.6. A SimilarityScore ≥ 0.6 indicates normal, and a SimilarityScore &lt; 0.6 indicates an attack.</p>
        /// </summary>
        [JsonProperty("SimilarityScore")]
        public float? SimilarityScore{ get; set; }

        /// <summary>
        /// <p>id of the matched template</p>
        /// </summary>
        [JsonProperty("HitTemplate")]
        public string HitTemplate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HitGroup", this.HitGroup);
            this.SetParamSimple(map, prefix + "SimilarityScore", this.SimilarityScore);
            this.SetParamSimple(map, prefix + "HitTemplate", this.HitTemplate);
        }
    }
}

