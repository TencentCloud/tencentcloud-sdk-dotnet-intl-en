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

    public class BrowserImpersonationDetectionRule : AbstractModel
    {
        
        /// <summary>
        /// ID of the browser spoofing identification rule.<br>You can perform different rule configuration operations by rule ID:<br> <li> <b>Add</b> a new rule: leave the ID empty or unspecified;</li><li><b>Modify</b> an existing rule: specify the rule ID that needs to be updated/modified;</li><li><b>Delete</b> an existing rule: existing rules not included in the Rules list in the BrowserImpersonationDetection parameter will be deleted.</li>
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Name of the browser spoofing identification rule.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Whether to enable the browser forgery identification rule. Valid values: <li>on: enable;</li><li>off: disable.</li>
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }

        /// <summary>
        /// Specific content of the browser spoofing identification rule. It only supports the configuration of request Method, request Path, and request URL, which must comply with expression syntax. For detailed specifications, see the product document.
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// Handling method for browser spoofing identification rules, including Cookie verification, session tracking configuration, and client behavior validation configuration.
        /// </summary>
        [JsonProperty("Action")]
        public BrowserImpersonationDetectionAction Action{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamSimple(map, prefix + "Condition", this.Condition);
            this.SetParamObj(map, prefix + "Action.", this.Action);
        }
    }
}

