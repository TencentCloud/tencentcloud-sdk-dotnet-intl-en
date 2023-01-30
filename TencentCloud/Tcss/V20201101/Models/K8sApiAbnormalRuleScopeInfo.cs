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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class K8sApiAbnormalRuleScopeInfo : AbstractModel
    {
        
        /// <summary>
        /// Range
        /// System event:
        /// ANONYMOUS_ACCESS: Anonymous access
        /// ABNORMAL_UA_REQ: Abnormal UA request
        /// ANONYMOUS_ABNORMAL_PERMISSION: Abnormal changes on permissions of an anonymous user
        /// GET_CREDENTIALS: Credential information acquisition
        /// MOUNT_SENSITIVE_PATH: Sensitive path mounting
        /// COMMAND_RUN: Command execution
        /// PRIVILEGE_CONTAINER: Privilege container
        /// EXCEPTION_CRONTAB_TASK: Aabnormal scheduled task
        /// STATICS_POD: Static pod creation
        /// ABNORMAL_CREATE_POD: Abnormal pod creation
        /// USER_DEFINED: User defined
        /// </summary>
        [JsonProperty("Scope")]
        public string Scope{ get; set; }

        /// <summary>
        /// Action (RULE_MODE_ALERT: Alarm RULE_MODE_RELEASE: Release)
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// Threat level: "HIGH": High-risk level; "MIDDLE": Middle-risk level; "LOW": Low-risk level; "NOTICE": Notice level
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// Switch status (true: On; false: Off): applicable to system rules.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// Whether to delete: applicable to custom rule input parameters.
        /// Note: This field may return `null`, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("IsDelete")]
        public bool? IsDelete{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Scope", this.Scope);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "IsDelete", this.IsDelete);
        }
    }
}

