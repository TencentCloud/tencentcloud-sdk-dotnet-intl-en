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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribleL7RulesRequest : AbstractModel
    {
        
        /// <summary>
        /// Anti-DDoS service type. `bgpip`: Anti-DDoS Advanced; `net`: Anti-DDoS Ultimate
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// Anti-DDoS instance ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Rule ID, which is optional. If this field is entered, the specified rule will be obtained
        /// </summary>
        [JsonProperty("RuleIdList")]
        public string[] RuleIdList{ get; set; }

        /// <summary>
        /// Number of entries per page. A value of 0 means no pagination
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// Page start offset, whose value is (page number - 1) * number of entries per page
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// Domain name search, which is optional. Enter it if you need to search for domain names
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Forwarding protocol search, which is optional. Valid values: [http, https, http/https]
        /// </summary>
        [JsonProperty("ProtocolList")]
        public string[] ProtocolList{ get; set; }

        /// <summary>
        /// Status search, which is optional. Valid values: [0 (successfully configured rule), 1 (rule configuration taking effect), 2 (rule configuration failed), 3 (rule deletion taking effect), 5 (rule deletion failed), 6 (rule waiting for configuration), 7 (rule waiting for deletion), 8 (rule waiting for certificate configuration)]
        /// </summary>
        [JsonProperty("StatusList")]
        public ulong?[] StatusList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArraySimple(map, prefix + "RuleIdList.", this.RuleIdList);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArraySimple(map, prefix + "ProtocolList.", this.ProtocolList);
            this.SetParamArraySimple(map, prefix + "StatusList.", this.StatusList);
        }
    }
}

