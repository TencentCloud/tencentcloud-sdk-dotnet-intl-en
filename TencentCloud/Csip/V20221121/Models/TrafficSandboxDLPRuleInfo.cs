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

    public class TrafficSandboxDLPRuleInfo : AbstractModel
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
        /// Enumeration values:
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
        /// Enumeration values:
        /// ON: enable
        /// OFF: disabled.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Asset type to which it belongs
        /// Enumeration values:
        /// HOST: Host
        /// CONTAINER: Container
        /// </summary>
        [JsonProperty("BelongAssetType")]
        public string BelongAssetType{ get; set; }

        /// <summary>
        /// Snapshot of the referenced system rule content
        /// </summary>
        [JsonProperty("SystemRuleContent")]
        public TrafficSandboxDLPRuleContentItem[] SystemRuleContent{ get; set; }

        /// <summary>
        /// Content of the user-defined rule
        /// </summary>
        [JsonProperty("UserRuleContent")]
        public TrafficSandboxDLPRuleContentItem[] UserRuleContent{ get; set; }

        /// <summary>
        /// Structured view of user rules, returning rule content by detection dimension, making it easy for the frontend to render partitions by file name, file size, file format, outbound domain name, and outbound content. Read-only output fields do not affect Create/Modify input parameters.
        /// </summary>
        [JsonProperty("UserRuleInfo")]
        public TrafficSandboxDLPUserRuleInfo UserRuleInfo{ get; set; }

        /// <summary>
        /// Rule effective scope
        /// </summary>
        [JsonProperty("EffectScope")]
        public TrafficSandboxEffectScope EffectScope{ get; set; }

        /// <summary>
        /// List of ineffective assets: AI Agent assets in the traffic sandbox plug-in not installed (TrafficPluginState.InstallStatus not INSTALLED) among the policy association targets' effective assets. Returns the InstanceId/ContainerId and TrafficPluginState of the machines. Returns an empty array when there are no ineffective assets.
        /// </summary>
        [JsonProperty("InactiveAssets")]
        public TrafficSandboxInactiveAsset[] InactiveAssets{ get; set; }

        /// <summary>
        /// Creation time.
        /// Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format)
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
        /// Enumeration values:
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
            this.SetParamArrayObj(map, prefix + "SystemRuleContent.", this.SystemRuleContent);
            this.SetParamArrayObj(map, prefix + "UserRuleContent.", this.UserRuleContent);
            this.SetParamObj(map, prefix + "UserRuleInfo.", this.UserRuleInfo);
            this.SetParamObj(map, prefix + "EffectScope.", this.EffectScope);
            this.SetParamArrayObj(map, prefix + "InactiveAssets.", this.InactiveAssets);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
        }
    }
}

