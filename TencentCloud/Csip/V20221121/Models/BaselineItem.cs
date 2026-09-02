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

    public class BaselineItem : AbstractModel
    {
        
        /// <summary>
        /// <p>Baseline detection item ID.</p>
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// <p>Built-in rule ID.</p>
        /// </summary>
        [JsonProperty("RuleID")]
        public ulong? RuleID{ get; set; }

        /// <summary>
        /// <p>Detection object description, such as configuration file path, kernel parameter, and Kubernetes Resources.</p>
        /// </summary>
        [JsonProperty("CheckObject")]
        public string[] CheckObject{ get; set; }

        /// <summary>
        /// <p>Risk level. Value:</p><ul><li>LOW: Low risk</li><li>MEDIUM: Medium risk</li><li>HIGH: High risk</li><li>CRITICAL: Critical</li></ul>
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// <p>Detection item name (Chinese).</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>Detection item description (Chinese, explaining the detection background and determination logic).</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Detection item repair advice (Chinese, including recommended configuration reference values or hardening commands).</p>
        /// </summary>
        [JsonProperty("FixSuggestion")]
        public string FixSuggestion{ get; set; }

        /// <summary>
        /// <p>Reference link list of detection items.</p>
        /// </summary>
        [JsonProperty("ReferenceLink")]
        public string ReferenceLink{ get; set; }

        /// <summary>
        /// <p>Classification information of the parent category in the associated system.</p>
        /// </summary>
        [JsonProperty("SystemCategory")]
        public BaselineCategory SystemCategory{ get; set; }

        /// <summary>
        /// <p>Classification information of the subcategory it belongs to.</p>
        /// </summary>
        [JsonProperty("Category")]
        public BaselineCategory Category{ get; set; }

        /// <summary>
        /// <p>Whether one-click repair is supported. true: supported, false: unsupported.</p>
        /// </summary>
        [JsonProperty("SupportFix")]
        public bool? SupportFix{ get; set; }

        /// <summary>
        /// <p>Whether user-defined judgment values are supported. true: supported; false: not supported.</p>
        /// </summary>
        [JsonProperty("SupportCustomValue")]
        public bool? SupportCustomValue{ get; set; }

        /// <summary>
        /// <p>Operating system/component version list applicable to this detection item.</p>
        /// </summary>
        [JsonProperty("AffectedVersionList")]
        public string[] AffectedVersionList{ get; set; }

        /// <summary>
        /// <p>Parameter definition when editing a custom judgment value (for example, permissible range, control type).</p>
        /// </summary>
        [JsonProperty("WebEditParam")]
        public string WebEditParam{ get; set; }

        /// <summary>
        /// <p>Default detection item judgment value list.</p>
        /// </summary>
        [JsonProperty("DefaultValueList")]
        public string[] DefaultValueList{ get; set; }

        /// <summary>
        /// <p>Whether customized by the user. true: customized; false: use default values.</p>
        /// </summary>
        [JsonProperty("IsCustomConf")]
        public bool? IsCustomConf{ get; set; }

        /// <summary>
        /// <p>User-customized configuration record ID. The value is 0 if not customized.</p>
        /// </summary>
        [JsonProperty("CustomItemID")]
        public ulong? CustomItemID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamArraySimple(map, prefix + "CheckObject.", this.CheckObject);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "FixSuggestion", this.FixSuggestion);
            this.SetParamSimple(map, prefix + "ReferenceLink", this.ReferenceLink);
            this.SetParamObj(map, prefix + "SystemCategory.", this.SystemCategory);
            this.SetParamObj(map, prefix + "Category.", this.Category);
            this.SetParamSimple(map, prefix + "SupportFix", this.SupportFix);
            this.SetParamSimple(map, prefix + "SupportCustomValue", this.SupportCustomValue);
            this.SetParamArraySimple(map, prefix + "AffectedVersionList.", this.AffectedVersionList);
            this.SetParamSimple(map, prefix + "WebEditParam", this.WebEditParam);
            this.SetParamArraySimple(map, prefix + "DefaultValueList.", this.DefaultValueList);
            this.SetParamSimple(map, prefix + "IsCustomConf", this.IsCustomConf);
            this.SetParamSimple(map, prefix + "CustomItemID", this.CustomItemID);
        }
    }
}

