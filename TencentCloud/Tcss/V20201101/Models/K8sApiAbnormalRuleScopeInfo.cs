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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class K8sApiAbnormalRuleScopeInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Execution action. The blocklist rule only supports RULE_MODE_ALERT (alert) and no longer supports RULE_MODE_RELEASE/PASS (allow). To allow, use the allowlist API ModifyK8sApiAbnormalWhitelist.</p>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// <p>Scope.<br>System events:<br>ANONYMOUS_ACCESS: anonymous access<br>ABNORMAL_UA_REQ: abnormal UA request<br>ANONYMOUS_ABNORMAL_PERMISSION: anonymous user permission change<br>GET_CREDENTIALS: credential information acquisition<br>MOUNT_SENSITIVE_PATH: sensitive path mounting<br>COMMAND_RUN: command execution<br>PRIVILEGE_CONTAINER: privileged container<br>EXCEPTION_CRONTAB_TASK: abnormal scheduled task<br>STATICS_POD: static Pod creation<br>ABNORMAL_CREATE_POD: abnormal Pod creation<br>USER_DEFINED: user-defined</p>
        /// </summary>
        [JsonProperty("Scope")]
        public string Scope{ get; set; }

        /// <summary>
        /// <p>Whether it has been deleted.</p>
        /// </summary>
        [JsonProperty("IsDelete")]
        public bool? IsDelete{ get; set; }

        /// <summary>
        /// <p>Threat level: HIGH, MIDDLE, LOW, and NOTICE.</p>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// <p>Description of the rule type.</p>
        /// </summary>
        [JsonProperty("RuleTypeZH")]
        public string RuleTypeZH{ get; set; }

        /// <summary>
        /// <p>Switch status (true: on, false: off) applicable to system rules.</p>
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "IsDelete", this.IsDelete);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "RuleTypeZH", this.RuleTypeZH);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

