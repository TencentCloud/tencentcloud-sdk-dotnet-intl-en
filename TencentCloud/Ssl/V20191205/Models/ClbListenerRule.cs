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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClbListenerRule : AbstractModel
    {
        
        /// <summary>
        /// The rule ID.
        /// </summary>
        [JsonProperty("LocationId")]
        public string LocationId{ get; set; }

        /// <summary>
        /// The domains bound.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Whether the rule matches the domains to be associated with a certificate.
        /// </summary>
        [JsonProperty("IsMatch")]
        public bool? IsMatch{ get; set; }

        /// <summary>
        /// Certificate data bound to the rule.
        /// </summary>
        [JsonProperty("Certificate")]
        public Certificate Certificate{ get; set; }

        /// <summary>
        /// Domain list not matched.
        /// </summary>
        [JsonProperty("NoMatchDomains")]
        public string[] NoMatchDomains{ get; set; }

        /// <summary>
        /// Rule binding path.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LocationId", this.LocationId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "IsMatch", this.IsMatch);
            this.SetParamObj(map, prefix + "Certificate.", this.Certificate);
            this.SetParamArraySimple(map, prefix + "NoMatchDomains.", this.NoMatchDomains);
            this.SetParamSimple(map, prefix + "Url", this.Url);
        }
    }
}

