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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlgDetectResult : AbstractModel
    {
        
        /// <summary>
        /// The validation result. Values:
        /// <li>`invalid`: Invalid Cookie</li>
        /// <li>`cookie_empty`: No Cookie/Cookie expired</li>
        /// <li>`js_empty`: Client JS disabled</li>
        /// <li>`low`: Low-risk session</li>
        /// <li>`middle`: Medium-risk session</li>
        /// <li>`high`: High-risk session</li>
        /// <li>`timeout`: JS validation timed out</li>
        /// <li>`not_browser`: Invalid browser</li>
        /// <li>`is_bot`: Bot client</li>
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// The action. Values:
        /// <li>`drop`: Block</li>
        /// <li>`monitor`: Observe</li>
        /// <li>`silence`: Drop w/o response</li>
        /// <li>`shortdelay`: Add short latency</li>
        /// <li>`longdelay`: Add long latency</li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Action", this.Action);
        }
    }
}

