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

    public class WebhookNotifyItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Module code (shares enumeration with ModifyNotifySettingAlert)<br>Enumeration values:<br>Vul: vulnerability and cloud security posture<br>Alert: alarm center<br>AkSk: Cloud API Risk Governance<br>Agent: client/host asset<br>LogAnalysis: log analysis</p>
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// <p>Submodule code<br>Enumeration values (partial):<br>MALWARE_FILE: MALICIOUS FILE<br>MALWARE_PROCESS: MALICIOUS PROCESS<br>RISK_LOGIN: abnormal LOGIN<br>BRUTE_FORCE: password cracking<br>MALICIOUS_REQUEST: MALICIOUS REQUEST<br>HIGH_RISK_COMMAND: HIGH-RISK COMMAND<br>PRIVILEGE_ESCALATION: local PRIVILEGE ESCALATION<br>REVERSE_SHELL: REVERSE SHELL<br>NETWORK_ATTACK: NETWORK ATTACK<br>MULTI_BEHAVIOR_ATTACK: MULTI-BEHAVIOR ATTACK<br>AGENT_OFFLINE: client OFFLINE<br>AGENT_UNINSTALL: client uninstallation<br>For the complete enumeration, see DescribeWebhookNotifyItemTree</p>
        /// </summary>
        [JsonProperty("SubModule")]
        public string SubModule{ get; set; }

        /// <summary>
        /// <p>Risk level collection<br>Enumeration values:<br>CRITICAL: Critical<br>HIGH: High risk<br>MEDIUM: Medium risk<br>LOW: Low risk<br>INFO: Notification<br>Submodules with unsupported levels pass an empty array</p>
        /// </summary>
        [JsonProperty("Levels")]
        public string[] Levels{ get; set; }

        /// <summary>
        /// <p>Processing status</p>
        /// </summary>
        [JsonProperty("Items")]
        public string[] Items{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "SubModule", this.SubModule);
            this.SetParamArraySimple(map, prefix + "Levels.", this.Levels);
            this.SetParamArraySimple(map, prefix + "Items.", this.Items);
        }
    }
}

