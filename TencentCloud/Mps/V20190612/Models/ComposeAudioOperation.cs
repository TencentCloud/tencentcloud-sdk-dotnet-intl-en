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

    public class ComposeAudioOperation : AbstractModel
    {
        
        /// <summary>
        /// The operation type. Valid values:
        /// <li>`Volume`: Volume adjustment. </li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        ///  The volume level. This parameter is valid if `Type` is `Volume`. Value range: 0–5. 
        /// <li>If the parameter value is `0`, the video will be muted. </li>
        /// <li>If the parameter value is smaller than 1, the volume will be reduced. </li>
        /// <li>If the parameter value is `1`, the original volume will be kept. </li>
        /// <li>If the parameter value is greater than 1, the volume will be increased. </li>
        /// </summary>
        [JsonProperty("Volume")]
        public float? Volume{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
        }
    }
}

