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

    public class SecHitRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// The rule ID.
        /// </summary>
        [JsonProperty("RuleId")]
        public long? RuleId{ get; set; }

        /// <summary>
        /// The rule type.
        /// </summary>
        [JsonProperty("RuleTypeName")]
        public string RuleTypeName{ get; set; }

        /// <summary>
        /// Action. Values:
        /// <li>`trans`: Allow;</li>
        /// <li>`alg`: Algorithm challenge;</li>
        /// <li>`drop`: Discard;</li>
        /// <li>`ban`: Block the source IP;</li>
        /// <li>`redirect`: Redirect;</li>
        /// <li>`page`: Return to the specified page;</li>
        /// <li>`monitor`: Observe.</li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// The hit time recorded in seconds using UNIX timestamp.
        /// </summary>
        [JsonProperty("HitTime")]
        public long? HitTime{ get; set; }

        /// <summary>
        /// The number of requests.
        /// </summary>
        [JsonProperty("RequestNum")]
        public long? RequestNum{ get; set; }

        /// <summary>
        /// The rule description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// The subdomain name.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// The bot tag. Values:
        /// <li>`evil_bot`: Malicious bot</li>
        /// <li>`suspect_bot`: Suspected bot</li>
        /// <li>`good_bot`: Good bot</li>
        /// <li>`normal`: Normal request</li>
        /// <li>`none`: Uncategorized</li>
        /// </summary>
        [JsonProperty("BotLabel")]
        public string BotLabel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleTypeName", this.RuleTypeName);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "HitTime", this.HitTime);
            this.SetParamSimple(map, prefix + "RequestNum", this.RequestNum);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "BotLabel", this.BotLabel);
        }
    }
}

