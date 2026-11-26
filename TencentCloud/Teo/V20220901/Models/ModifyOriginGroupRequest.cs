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

    public class ModifyOriginGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// Zone ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Origin group ID. This parameter is required.
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// Origin server group name. The original configuration applies if this field is not specified. It can contain 1 to 200 characters, including a-z, A-Z, 0-9, underscores (_), and hyphens (-).	
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Origin server group type. Valid values:
        /// <li>GENERAL: general origin group, only supports adding IP/domain origin servers, and can be referenced by DNS, rule engine, Layer 4 proxy, and general load balancer;</li>
        /// <li>HTTP: HTTP-specific origin group. It supports adding IP/domain name and COS origin servers, with the incapability of being referenced by Layer-4 proxy.</li>Leave it blank to retain the original configuration.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Origin server record information. If this field is not specified, the original configuration will be retained.
        /// </summary>
        [JsonProperty("Records")]
        public OriginRecord[] Records{ get; set; }

        /// <summary>
        /// Origin-pull Host Header. This parameter is valid only when Type = HTTP. No configuration or fill in the blank indicates no origin-pull Host is configured. The rule engine modification of Host Header configuration has a higher priority than the Host Header of the origin server group.
        /// </summary>
        [JsonProperty("HostHeader")]
        public string HostHeader{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "Records.", this.Records);
            this.SetParamSimple(map, prefix + "HostHeader", this.HostHeader);
        }
    }
}

