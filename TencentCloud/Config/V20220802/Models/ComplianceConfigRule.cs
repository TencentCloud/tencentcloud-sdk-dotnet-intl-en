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

    public class ComplianceConfigRule : AbstractModel
    {
        
        /// <summary>
        /// Rule name
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Risk level
        /// </summary>
        [JsonProperty("RiskLevel")]
        public ulong? RiskLevel{ get; set; }

        /// <summary>
        /// Rule status
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("ConfigRuleId")]
        public string ConfigRuleId{ get; set; }

        /// <summary>
        /// Assessment result
        /// Compliant: 'COMPLIANT'
        /// Non-compliant: 'NON_COMPLIANT'
        /// </summary>
        [JsonProperty("ComplianceResult")]
        public string ComplianceResult{ get; set; }

        /// <summary>
        /// Keyword.
        /// </summary>
        [JsonProperty("Labels")]
        public string[] Labels{ get; set; }

        /// <summary>
        /// Input parameters
        /// </summary>
        [JsonProperty("InputParameter")]
        public InputParameter[] InputParameter{ get; set; }

        /// <summary>
        /// Parameter format.
        /// </summary>
        [JsonProperty("SourceCondition")]
        public SourceConditionForManage[] SourceCondition{ get; set; }

        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("Identifier")]
        public string Identifier{ get; set; }

        /// <summary>
        /// Creation method. Valid values: user, compliancePack, and system.
        /// </summary>
        [JsonProperty("CreateByType")]
        public string CreateByType{ get; set; }

        /// <summary>
        /// Rule description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Parameter description
        /// </summary>
        [JsonProperty("ManageInputParameter")]
        public InputParameterForManage[] ManageInputParameter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ConfigRuleId", this.ConfigRuleId);
            this.SetParamSimple(map, prefix + "ComplianceResult", this.ComplianceResult);
            this.SetParamArraySimple(map, prefix + "Labels.", this.Labels);
            this.SetParamArrayObj(map, prefix + "InputParameter.", this.InputParameter);
            this.SetParamArrayObj(map, prefix + "SourceCondition.", this.SourceCondition);
            this.SetParamSimple(map, prefix + "Identifier", this.Identifier);
            this.SetParamSimple(map, prefix + "CreateByType", this.CreateByType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "ManageInputParameter.", this.ManageInputParameter);
        }
    }
}

