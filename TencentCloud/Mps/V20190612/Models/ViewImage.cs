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

    public class ViewImage : AbstractModel
    {
        
        /// <summary>
        /// <p>View type</p><p>Enumeration values:</p><ul><li>front: Front view (required)</li><li>back: Back view</li><li>left: Left view</li><li>right: Right view</li><li>top: Top view</li><li>bottom: Bottom view</li><li>left_front: Left front 45°</li><li>right_front: Right front 45°</li></ul><p>MultiViewImages array length ≥ 2; must contain the front view; the same ViewType cannot be duplicated; each item must provide ViewImageUrl</p>
        /// </summary>
        [JsonProperty("ViewType")]
        public string ViewType{ get; set; }

        /// <summary>
        /// <p>Image URL (http/https)</p>
        /// </summary>
        [JsonProperty("ViewImageUrl")]
        public string ViewImageUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ViewType", this.ViewType);
            this.SetParamSimple(map, prefix + "ViewImageUrl", this.ViewImageUrl);
        }
    }
}

