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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EditReverseShellRulesRequest : AbstractModel
    {
        
        /// <summary>
        /// Rule ID (leave this parameter blank for addition)
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// Client ID array
        /// </summary>
        [JsonProperty("Uuids")]
        public string[] Uuids{ get; set; }

        /// <summary>
        /// Host IP
        /// </summary>
        [JsonProperty("HostIp")]
        public string HostIp{ get; set; }

        /// <summary>
        /// Target IP address
        /// </summary>
        [JsonProperty("DestIp")]
        public string DestIp{ get; set; }

        /// <summary>
        /// Target port
        /// </summary>
        [JsonProperty("DestPort")]
        public string DestPort{ get; set; }

        /// <summary>
        /// Process name
        /// </summary>
        [JsonProperty("ProcessName")]
        public string ProcessName{ get; set; }

        /// <summary>
        /// Whether the rule is global (not global by default)
        /// </summary>
        [JsonProperty("IsGlobal")]
        public ulong? IsGlobal{ get; set; }

        /// <summary>
        /// ID of the associated event when clicking Add to Allowlist on the event list and details page (leave this parameter blank for rule addition)
        /// </summary>
        [JsonProperty("EventId")]
        public ulong? EventId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArraySimple(map, prefix + "Uuids.", this.Uuids);
            this.SetParamSimple(map, prefix + "HostIp", this.HostIp);
            this.SetParamSimple(map, prefix + "DestIp", this.DestIp);
            this.SetParamSimple(map, prefix + "DestPort", this.DestPort);
            this.SetParamSimple(map, prefix + "ProcessName", this.ProcessName);
            this.SetParamSimple(map, prefix + "IsGlobal", this.IsGlobal);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
        }
    }
}

