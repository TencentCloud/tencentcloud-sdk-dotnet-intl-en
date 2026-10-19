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

    public class AggregateEvaluationResult : AbstractModel
    {
        
        /// <summary>
        /// Resource ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// Resource type.
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// Resource region
        /// </summary>
        [JsonProperty("ResourceRegion")]
        public string ResourceRegion{ get; set; }

        /// <summary>
        /// Resource name
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("ConfigRuleId")]
        public string ConfigRuleId{ get; set; }

        /// <summary>
        /// Rule name
        /// </summary>
        [JsonProperty("ConfigRuleName")]
        public string ConfigRuleName{ get; set; }

        /// <summary>
        /// Compliance package ID.
        /// </summary>
        [JsonProperty("CompliancePackId")]
        public string CompliancePackId{ get; set; }

        /// <summary>
        /// Risk level
        /// </summary>
        [JsonProperty("RiskLevel")]
        public long? RiskLevel{ get; set; }

        /// <summary>
        /// Assessment result
        /// </summary>
        [JsonProperty("Annotation")]
        public Annotation Annotation{ get; set; }

        /// <summary>
        /// Compliance type.
        /// </summary>
        [JsonProperty("ComplianceType")]
        public string ComplianceType{ get; set; }

        /// <summary>
        /// Rule initiation type.
        /// </summary>
        [JsonProperty("InvokingEventMessageType")]
        public string InvokingEventMessageType{ get; set; }

        /// <summary>
        /// Evaluation initiation time.
        /// </summary>
        [JsonProperty("ConfigRuleInvokedTime")]
        public string ConfigRuleInvokedTime{ get; set; }

        /// <summary>
        /// Actual evaluation time.
        /// </summary>
        [JsonProperty("ResultRecordedTime")]
        public string ResultRecordedTime{ get; set; }

        /// <summary>
        /// Resource owner ID.
        /// </summary>
        [JsonProperty("ResourceOwnerId")]
        public ulong? ResourceOwnerId{ get; set; }

        /// <summary>
        /// Resource owner user name.
        /// </summary>
        [JsonProperty("ResourceOwnerName")]
        public string ResourceOwnerName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ResourceRegion", this.ResourceRegion);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "ConfigRuleId", this.ConfigRuleId);
            this.SetParamSimple(map, prefix + "ConfigRuleName", this.ConfigRuleName);
            this.SetParamSimple(map, prefix + "CompliancePackId", this.CompliancePackId);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamObj(map, prefix + "Annotation.", this.Annotation);
            this.SetParamSimple(map, prefix + "ComplianceType", this.ComplianceType);
            this.SetParamSimple(map, prefix + "InvokingEventMessageType", this.InvokingEventMessageType);
            this.SetParamSimple(map, prefix + "ConfigRuleInvokedTime", this.ConfigRuleInvokedTime);
            this.SetParamSimple(map, prefix + "ResultRecordedTime", this.ResultRecordedTime);
            this.SetParamSimple(map, prefix + "ResourceOwnerId", this.ResourceOwnerId);
            this.SetParamSimple(map, prefix + "ResourceOwnerName", this.ResourceOwnerName);
        }
    }
}

