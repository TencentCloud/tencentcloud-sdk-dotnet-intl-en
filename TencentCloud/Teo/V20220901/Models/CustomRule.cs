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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomRule : AbstractModel
    {
        
        /// <summary>
        /// The custom rule name.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// The specific content of custom rules must comply with expression grammar. For detailed specifications, please refer to the product document (https://www.tencentcloud.com/document/product/1552/125343?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// The handling action of custom rules. The value range of SecurityAction.Name is as follows:<ul><li>Deny: blocking;</li><li>Monitor: observation;</li><li>ReturnCustomPage: use specified page to block;</li><li>Redirect: redirect to URL;</li><li>BlockIP: IP blocking;</li><li>JSChallenge: JavaScript challenge;</li><li>ManagedChallenge: managed challenge;</li><li>Allow: allowing.</li></ul>
        /// </summary>
        [JsonProperty("Action")]
        public SecurityAction Action{ get; set; }

        /// <summary>
        /// Whether the custom rule is enabled. Valid values: <ul><li>on: enable</li><li>off: disable</li></ul>
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }

        /// <summary>
        /// ID of the custom rule. Different rule configuration operations are supported by rule ID:<ul><li>Add a new rule: The ID is empty or the ID parameter is not specified.</li><li>Modify an existing rule: Specify the rule ID that needs to be updated or modified.</li><li>Delete an existing rule: Existing rules not included in the Rules list in the CustomRules parameter will be deleted.</li></ul>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Type of custom rule. Valid values: <ul><li>BasicAccessRule: basic access control;</li><li>PreciseMatchRule: exact matching rule;</li><li>ManagedAccessRule: expert customized rule, only supported in output parameters.</li></ul>Description: When RuleType is not specified, it defaults to `PreciseMatchRule`.
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// Priority of custom rules, ranging from 0 to 100, defaults to 0, and only supports exact matching rules (`PreciseMatchRule`).
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Condition", this.Condition);
            this.SetParamObj(map, prefix + "Action.", this.Action);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
        }
    }
}

