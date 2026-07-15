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

    public class RecipeItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Sub-image type.</p><p>Enumeration values:</p><ul><li>hero: product hero image.</li><li>detail: product details image.</li><li>selling: core selling point image.</li><li>atmosphere: scene atmosphere image.</li><li>angles: multiple-angle image.</li><li>scene: usage scenario image.</li></ul>
        /// </summary>
        [JsonProperty("Theme")]
        public string Theme{ get; set; }

        /// <summary>
        /// <p>Number of corresponding sub-images.</p><p>Value range: 1 to 4.</p><p>Unit: image.</p><p>Each type can have up to 4 sub-images. The total number of sub-images must be within the range of 4 to 12.</p>
        /// </summary>
        [JsonProperty("Num")]
        public long? Num{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Theme", this.Theme);
            this.SetParamSimple(map, prefix + "Num", this.Num);
        }
    }
}

