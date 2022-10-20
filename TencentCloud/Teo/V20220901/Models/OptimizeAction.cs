/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OptimizeAction : AbstractModel
    {
        
        /// <summary>
        /// The optimization metric. Values:
        /// <li>`Http2`</li>
        /// <li>`Http3`</li>
        /// <li>`Brotli`</li>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// The network environment.
        /// </summary>
        [JsonProperty("Connectivity")]
        public string Connectivity{ get; set; }

        /// <summary>
        /// The estimated load time, in milliseconds.
        /// </summary>
        [JsonProperty("Value")]
        public long? Value{ get; set; }

        /// <summary>
        /// The estimated improvement ratio, in %.
        /// </summary>
        [JsonProperty("Ratio")]
        public long? Ratio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Connectivity", this.Connectivity);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "Ratio", this.Ratio);
        }
    }
}

