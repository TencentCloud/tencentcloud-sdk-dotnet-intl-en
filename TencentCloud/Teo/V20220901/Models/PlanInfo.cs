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

    public class PlanInfo : AbstractModel
    {
        
        /// <summary>
        /// Settlement currency. Values:
        /// <li>`CNY`: Settled by Chinese RMB;</li>
        /// <li>`USD`: Settled by US dollars.</li>
        /// </summary>
        [JsonProperty("Currency")]
        public string Currency{ get; set; }

        /// <summary>
        /// Traffic quota of the plan. It includes the traffic for security acceleration, content acceleration and smart acceleration. Unit: byte.
        /// </summary>
        [JsonProperty("Flux")]
        public ulong? Flux{ get; set; }

        /// <summary>
        /// Settlement cycle. Values:
        /// <li>`y`: Settled by year;</li>
        /// <li>`m`: Settled by month;</li>
        /// <li>`h`: Settled by hour;</li>
        /// <li>`M`: Settled by minute;</li>
        /// <li>`s`: Settled by second.</li>
        /// </summary>
        [JsonProperty("Frequency")]
        public string Frequency{ get; set; }

        /// <summary>
        /// Plan option. Values:
        /// <li>`sta`: Standard plan that supports content delivery network outside Chinese mainland;</li>
        /// <li>`sta_with_bot`: Standard plan that supports content delivery network outside Chinese mainland and bot management;</li>
        /// <li>`sta_cm`: Standard plan that supports content delivery network inside Chinese mainland;</li>
        /// <li>`sta_cm_with_bot`: Standard plan that supports content delivery network inside Chinese mainland and bot management;</li>
        /// <li>`ent`: Enterprise plan that supports content delivery network outside Chinese mainland;</li>
        /// <li>`ent_with_bot`: Enterprise plan that supports content delivery network outside Chinese mainland and bot management;</li>
        /// <li>`ent_cm`: Enterprise plan that supports content delivery network inside Chinese mainland;</li>
        /// <li>`ent_cm_with_bot`: Enterprise plan that supports content delivery network inside Chinese mainland and bot management.</li>
        /// </summary>
        [JsonProperty("PlanType")]
        public string PlanType{ get; set; }

        /// <summary>
        /// Plan price (in CNY fen/US cent). The price unit depends on the settlement currency.
        /// </summary>
        [JsonProperty("Price")]
        public float? Price{ get; set; }

        /// <summary>
        /// Quota on security acceleration requests
        /// </summary>
        [JsonProperty("Request")]
        public ulong? Request{ get; set; }

        /// <summary>
        /// Number of sites to be bound to the plan
        /// </summary>
        [JsonProperty("SiteNumber")]
        public ulong? SiteNumber{ get; set; }

        /// <summary>
        /// Acceleration region. Values:
        /// <li>`mainland`: Chinese mainland;</li>
        /// <li>`overseas`: Global (Chinese mainland not included).</li>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Currency", this.Currency);
            this.SetParamSimple(map, prefix + "Flux", this.Flux);
            this.SetParamSimple(map, prefix + "Frequency", this.Frequency);
            this.SetParamSimple(map, prefix + "PlanType", this.PlanType);
            this.SetParamSimple(map, prefix + "Price", this.Price);
            this.SetParamSimple(map, prefix + "Request", this.Request);
            this.SetParamSimple(map, prefix + "SiteNumber", this.SiteNumber);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

