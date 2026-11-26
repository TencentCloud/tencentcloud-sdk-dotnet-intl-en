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

    public class MultiPathGatewayLine : AbstractModel
    {
        
        /// <summary>
        /// Line ID. Among them, line-0 and line-1 are built-in line IDs. Valid values:
        /// <li> line-0: direct-access line. Additions, edits, and deletion are not supported;</li>
        /// <li> line-1: EdgeOne Layer 4 proxy line. Supports modifying instances and rules. Deletion is not supported;</li>
        /// <li> line-2 and above: EdgeOne Layer 4 proxy lines or custom lines, supports modifying and deletion of instances and rules.</li>
        /// </summary>
        [JsonProperty("LineId")]
        public string LineId{ get; set; }

        /// <summary>
        /// Line type. Valid values:
        /// <li>direct: direct-access line, editing is not supported, and deletion is not supported;</li>
        /// <li>proxy: EdgeOne Layer 4 proxy route. Supports editing and modifying instances and rules. Deletion is not supported;</li>
        /// <li>custom: Custom lines, support editing and deletion.</li>
        /// </summary>
        [JsonProperty("LineType")]
        public string LineType{ get; set; }

        /// <summary>
        /// Line address in the format of host:port.
        /// </summary>
        [JsonProperty("LineAddress")]
        public string LineAddress{ get; set; }

        /// <summary>
        /// Layer 4 proxy instance ID, returned when the line type `LineType` is `proxy` (EdgeOne Layer 4 proxy).
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// Forwarding rule ID, returned when the line type `LineType` is `proxy` (EdgeOne Layer 4 proxy).
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LineId", this.LineId);
            this.SetParamSimple(map, prefix + "LineType", this.LineType);
            this.SetParamSimple(map, prefix + "LineAddress", this.LineAddress);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
        }
    }
}

