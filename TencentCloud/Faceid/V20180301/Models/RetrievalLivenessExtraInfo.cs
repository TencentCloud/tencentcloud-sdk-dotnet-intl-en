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
        /// <p>Hit template type. Among them, Common - public library; Auto - Auto Clustering Library; Owner - custom template.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("HitGroup")]
        public string HitGroup{ get; set; }

        /// <summary>
        /// <p>The similarity between the request image and the hit attack template ranges from [0,2]. The smaller the value, the higher the probability of hitting the attack template. The default threshold is 0.6. When SimilarityScore≥0.6, it is judged as normal. SimilarityScore&lt;0.6 is judged as an attack.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SimilarityScore")]
        public float? SimilarityScore{ get; set; }

        /// <summary>
        /// <p>Template id of the cache hit</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
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

