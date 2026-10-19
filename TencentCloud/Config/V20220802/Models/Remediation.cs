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

namespace TencentCloud.Config.V20220802.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Remediation : AbstractModel
    {
        
        /// <summary>
        /// Remediation template ID.
        /// </summary>
        [JsonProperty("RemediationTemplateId")]
        public string RemediationTemplateId{ get; set; }

        /// <summary>
        /// Remediation settings ID.
        /// </summary>
        [JsonProperty("RemediationId")]
        public string RemediationId{ get; set; }

        /// <summary>
        /// Template source for executing remediation.
        /// </summary>
        [JsonProperty("RemediationSourceType")]
        public string RemediationSourceType{ get; set; }

        /// <summary>
        /// Correction type. Valid values:
        /// SCF: Function Compute (custom remediation).
        /// </summary>
        [JsonProperty("RemediationType")]
        public string RemediationType{ get; set; }

        /// <summary>
        /// Account ID
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// Correction execution mode. Parameter value:
        /// MANUAL_EXECUTION: manual execution.
        /// </summary>
        [JsonProperty("InvokeType")]
        public string InvokeType{ get; set; }

        /// <summary>
        /// Rule ID.
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RemediationTemplateId", this.RemediationTemplateId);
            this.SetParamSimple(map, prefix + "RemediationId", this.RemediationId);
            this.SetParamSimple(map, prefix + "RemediationSourceType", this.RemediationSourceType);
            this.SetParamSimple(map, prefix + "RemediationType", this.RemediationType);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "InvokeType", this.InvokeType);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
        }
    }
}

