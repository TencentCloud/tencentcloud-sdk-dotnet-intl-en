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

    public class ConfigRuleResourceEvaluationResult : AbstractModel
    {
        
        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// Rule name
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Rule ID.
        /// </summary>
        [JsonProperty("RuleIdentifier")]
        public string RuleIdentifier{ get; set; }

        /// <summary>
        /// Rule description
        /// </summary>
        [JsonProperty("RuleDescription")]
        public string RuleDescription{ get; set; }

        /// <summary>
        /// Account to which the rule belongs.
        /// </summary>
        [JsonProperty("RuleOwnerId")]
        public long? RuleOwnerId{ get; set; }

        /// <summary>
        /// Rule risk level.
        /// </summary>
        [JsonProperty("RuleRiskLevel")]
        public long? RuleRiskLevel{ get; set; }

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
        /// Resource name
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// Resource region
        /// </summary>
        [JsonProperty("ResourceRegion")]
        public string ResourceRegion{ get; set; }

        /// <summary>
        /// Resource tag
        /// </summary>
        [JsonProperty("ResourceTags")]
        public Tag[] ResourceTags{ get; set; }

        /// <summary>
        /// Compliance details
        /// </summary>
        [JsonProperty("Annotation")]
        public Annotation Annotation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleIdentifier", this.RuleIdentifier);
            this.SetParamSimple(map, prefix + "RuleDescription", this.RuleDescription);
            this.SetParamSimple(map, prefix + "RuleOwnerId", this.RuleOwnerId);
            this.SetParamSimple(map, prefix + "RuleRiskLevel", this.RuleRiskLevel);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "ResourceRegion", this.ResourceRegion);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamObj(map, prefix + "Annotation.", this.Annotation);
        }
    }
}

