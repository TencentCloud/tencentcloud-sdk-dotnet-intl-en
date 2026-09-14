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

namespace TencentCloud.Ga2.V20250115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyGlobalAcceleratorRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Global acceleration instance ID.</p>
        /// </summary>
        [JsonProperty("GlobalAcceleratorId")]
        public string GlobalAcceleratorId{ get; set; }

        /// <summary>
        /// <p>Name.</p><p>Parameter format: starting with a letter or Chinese characters, 2–128 characters in length, supporting letters, digits, Chinese characters, . - _</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Description.</p><p>Parameter format: should not exceed 100 characters.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Cross-border type.</p><p>Enumeration values:</p><ul><li>HighQuality: high-quality cross-border.</li><li>Unicom: China Unicom cross-border.</li></ul>
        /// </summary>
        [JsonProperty("CrossBorderType")]
        public string CrossBorderType{ get; set; }

        /// <summary>
        /// <p>Indicates whether to complete the cross-border service commitment.</p><p>When CrossBorderType is passed in, this field must be set to true, indicating the cross-border commitment is completed.</p>
        /// </summary>
        [JsonProperty("CrossBorderPromiseFlag")]
        public bool? CrossBorderPromiseFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GlobalAcceleratorId", this.GlobalAcceleratorId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CrossBorderType", this.CrossBorderType);
            this.SetParamSimple(map, prefix + "CrossBorderPromiseFlag", this.CrossBorderPromiseFlag);
        }
    }
}

