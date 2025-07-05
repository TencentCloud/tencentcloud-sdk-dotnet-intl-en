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

    public class ScratchRepairInfo : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable banding removal. Valid values:
        /// <li>`ON`</li>
        /// <li>`OFF`</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// The banding removal strength. Value range: 0.0 – 1.0. This parameter is valid only if `Switch` is `ON`.
        /// Default value: `0.0`.
        /// </summary>
        [JsonProperty("Intensity")]
        public float? Intensity{ get; set; }

        /// <summary>
        /// The banding removal type. This parameter is valid only if `Switch` is `ON`. Valid values:
        /// <li>`normal`</li>
        /// Default value: `normal`.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Intensity", this.Intensity);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

