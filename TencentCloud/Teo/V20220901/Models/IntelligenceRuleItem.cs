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

    public class IntelligenceRuleItem : AbstractModel
    {
        
        /// <summary>
        /// The tag to categorize bots. Values:
        /// <li>`evil_bot`: Malicious bot</li>
        /// <li>`suspect_bot`: Suspected bot</li>
        /// <li>`good_bot`: Good bot</li>
        /// <li>`normal`: Normal request</li>
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// The action taken on bots. Values
        /// <li>`drop`: Block</li>
        /// <li>`trans`: Allow</li>
        /// <li>`alg`: JavaScript challenge</li>
        /// <li>`captcha`: Managed challenge</li>
        /// <li>`monitor`: Observe</li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "Action", this.Action);
        }
    }
}

