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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MediaAiAnalysisFrameTagItem : AbstractModel
    {
        
        /// <summary>
        /// Frame-specific tag name.
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// Classification list by frame tag name. CategorySet.N refers to the (N+1)-level category.
        /// For example, when Tag is "tower", CategorySet contains two elements: CategorySet.0 is "scenario" and CategorySet.1 is "building", which means the frame tag is "tower", the level-1 category is "scenario", and the level-2 category is "building".
        /// </summary>
        [JsonProperty("CategorySet")]
        public string[] CategorySet{ get; set; }

        /// <summary>
        /// Confidence of frame tagging, with a value range from 0 to 100.
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamArraySimple(map, prefix + "CategorySet.", this.CategorySet);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
        }
    }
}

