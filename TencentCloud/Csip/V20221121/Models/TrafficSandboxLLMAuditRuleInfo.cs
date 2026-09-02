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

    public class TrafficSandboxLLMAuditRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// Rule name
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Rule level
        /// Enumeration value:
        /// INFO: Notification
        /// LOW: low-risk
        /// MEDIUM: Medium risk
        /// HIGH: high risk
        /// CRITICAL: Critical
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// Rule status
        /// Enumeration value:
        /// ON: enabled.
        /// OFF: disabled.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Asset type of the affiliation
        /// Enumeration value:
        /// HOST: host
        /// CONTAINER: container
        /// </summary>
        [JsonProperty("BelongAssetType")]
        public string BelongAssetType{ get; set; }

        /// <summary>
        /// List of referenced system rules (including system rule names)
        /// </summary>
        [JsonProperty("SystemRuleRefs")]
        public TrafficSandboxLLMAuditRuleRef[] SystemRuleRefs{ get; set; }

        /// <summary>
        /// Effective scope of the rule
        /// </summary>
        [JsonProperty("EffectScope")]
        public TrafficSandboxEffectScope EffectScope{ get; set; }

        /// <summary>
        /// List of ineffective assets: AI Agent assets in the policy association targets' effective assets where the traffic sandbox plug-in is not installed (TrafficPluginState.InstallStatus is not INSTALLED). Returns the InstanceId / ContainerId and TrafficPluginState of the machines. Returns an empty array if there are no ineffective assets.
        /// </summary>
        [JsonProperty("InactiveAssets")]
        public TrafficSandboxInactiveAsset[] InactiveAssets{ get; set; }

        /// <summary>
        /// Creation time.
        /// Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO 8601 format)
        /// </summary>
        [JsonProperty("InsertTime")]
        public string InsertTime{ get; set; }

        /// <summary>
        /// Update time
        /// Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format)
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// Rule Action
        /// Enumeration value:
        /// PASS: allowlist
        /// BLOCK: Block and alarm
        /// MONITOR: alarm
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "BelongAssetType", this.BelongAssetType);
            this.SetParamArrayObj(map, prefix + "SystemRuleRefs.", this.SystemRuleRefs);
            this.SetParamObj(map, prefix + "EffectScope.", this.EffectScope);
            this.SetParamArrayObj(map, prefix + "InactiveAssets.", this.InactiveAssets);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
        }
    }
}

