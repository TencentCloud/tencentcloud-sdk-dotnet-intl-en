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

    public class MediaAiAnalysisFrameTagItem : AbstractModel
    {
        
        /// <summary>
        /// Frame-specific tag name.
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// Category list of frame-specific tag names. `CategorySet.N` indicates the N+1-level category.
        /// For example, if the `Tag` is "tower", and `CategorySet` contains two elements (`CategorySet.0` is "scene", and `CategorySet.1` is "architecture"), then the frame-specific tag is "tower", the first-level category is "scene", and the second-level category is "architecture".
        /// </summary>
        [JsonProperty("CategorySet")]
        public string[] CategorySet{ get; set; }

        /// <summary>
        /// Confidence of intelligently generated frame-specific tag between 0 and 100.
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

