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

    public class ModifyMultiPathGatewayLineRequest : AbstractModel
    {
        
        /// <summary>
        /// Zone ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Multi-Channel security acceleration gateway ID.
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// Line ID. valid values:
        /// <Li>Line-1: EdgeOne layer-4 proxy line. Supports modifying instances and rules, but does not support deletion.  </li>
        /// <li<li>line-2 and above: EdgeOne layer-4 proxy lines or custom lines, supports modifying, deleting instances and rules.</li> 
        /// </summary>
        [JsonProperty("LineId")]
        public string LineId{ get; set; }

        /// <summary>
        /// Line type. valid values:.
        /// <li>proxy: EdgeOne layer-4 proxy line, supports modifying instances and rules, but deletion is not supported.</li>.
        /// <Li>custom: Custom line.Supports editing, deleting instances and rules. 
        /// </summary>
        [JsonProperty("LineType")]
        public string LineType{ get; set; }

        /// <summary>
        /// Line address, formatted as host:port. Direct lines (LineType value is direct) cannot be modified, while other types support modifications.
        /// </summary>
        [JsonProperty("LineAddress")]
        public string LineAddress{ get; set; }

        /// <summary>
        /// Layer-4 proxy instance ID. when the line type value is proxy (EdgeOne layer-4 proxy),  it allows modifications to the instance.
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// Forwarding rule ID. when the line type  value is proxy (EdgeOne layer-4 proxy), it allows input to modify.
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "LineId", this.LineId);
            this.SetParamSimple(map, prefix + "LineType", this.LineType);
            this.SetParamSimple(map, prefix + "LineAddress", this.LineAddress);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
        }
    }
}

