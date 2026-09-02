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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAgentRunModeRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Group account member id.</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>Custom mode configuration</p>
        /// </summary>
        [JsonProperty("CustomPolicy")]
        public CustomAgentRunModePolicy CustomPolicy{ get; set; }

        /// <summary>
        /// <p>List of quuids in high protection mode</p>
        /// </summary>
        [JsonProperty("AdvanceModeQuuids")]
        public string[] AdvanceModeQuuids{ get; set; }

        /// <summary>
        /// <p>Custom mode quuid list</p>
        /// </summary>
        [JsonProperty("CustomModeQuuids")]
        public string[] CustomModeQuuids{ get; set; }

        /// <summary>
        /// <p>Log enhancement switch. 0: off, 1: on</p>
        /// </summary>
        [JsonProperty("EnhanceLogMode")]
        public ulong? EnhanceLogMode{ get; set; }

        /// <summary>
        /// <p>Malicious file scan automatic poc mode switch. 0: off, 1: on</p>
        /// </summary>
        [JsonProperty("MalwarePocMode")]
        public ulong? MalwarePocMode{ get; set; }

        /// <summary>
        /// <p>Whether the quintuple reports the source port. 0: not reported; 1: reported</p>
        /// </summary>
        [JsonProperty("ReportSourcePort")]
        public ulong? ReportSourcePort{ get; set; }

        /// <summary>
        /// <p>Log gathering settings, collect TCP source port tcp_src_port, TCP ingress log tcp_ingress, HTTP egress connection log http_egress, HTTP ingress connection log http_ingress, and application access log app_access</p>
        /// </summary>
        [JsonProperty("LogCollectSettings")]
        public string[] LogCollectSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamObj(map, prefix + "CustomPolicy.", this.CustomPolicy);
            this.SetParamArraySimple(map, prefix + "AdvanceModeQuuids.", this.AdvanceModeQuuids);
            this.SetParamArraySimple(map, prefix + "CustomModeQuuids.", this.CustomModeQuuids);
            this.SetParamSimple(map, prefix + "EnhanceLogMode", this.EnhanceLogMode);
            this.SetParamSimple(map, prefix + "MalwarePocMode", this.MalwarePocMode);
            this.SetParamSimple(map, prefix + "ReportSourcePort", this.ReportSourcePort);
            this.SetParamArraySimple(map, prefix + "LogCollectSettings.", this.LogCollectSettings);
        }
    }
}

