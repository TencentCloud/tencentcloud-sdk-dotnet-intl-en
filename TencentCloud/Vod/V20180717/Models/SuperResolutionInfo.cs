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

    public class SuperResolutionInfo : AbstractModel
    {
        
        /// <summary>
        /// Super resolution control switch. Optional values:
        /// <li>ON: Turn on super resolution;</li>
        /// <li>OFF: Disable super resolution.</li>
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Super resolution type. It is valid only when the super resolution control switch is ON. Available values:
        /// <li>lq: super resolution for low-resolution videos with considerable noise;</li>
        /// <li>hq: for high resolution video super-resolution.</li>
        /// Default value: lq.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Super resolution multiple. Available value: 2.
        /// Default value: 2.
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Size", this.Size);
        }
    }
}

