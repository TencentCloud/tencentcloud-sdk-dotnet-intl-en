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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecurityPolicyRuleIn : AbstractModel
    {
        
        /// <summary>
        /// Source IP or IP range of the request.
        /// </summary>
        [JsonProperty("SourceCidr")]
        public string SourceCidr{ get; set; }

        /// <summary>
        /// Policy: Allow (ACCEPT) or reject (DROP).
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// Rule alias
        /// </summary>
        [JsonProperty("AliasName")]
        public string AliasName{ get; set; }

        /// <summary>
        /// Protocol: TCP or UDP. ALL indicates all protocols.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Target port. Formatting examples:
        /// Single port: 80
        /// Multiple ports: 80, 443
        /// Consecutive ports: 3306-20000
        /// All ports: ALL
        /// </summary>
        [JsonProperty("DestPortRange")]
        public string DestPortRange{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceCidr", this.SourceCidr);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "AliasName", this.AliasName);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "DestPortRange", this.DestPortRange);
        }
    }
}

