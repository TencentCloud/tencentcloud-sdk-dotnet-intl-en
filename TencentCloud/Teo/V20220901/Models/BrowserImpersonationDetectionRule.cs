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
        /// Browser spoofing identification rule ID. rule ID supports different rule configuration operations: <li> <b>add</b> a new rule: ID is empty or without specifying the ID parameter;</li> <li> <b>modify</b> an existing rule: specify the rule ID that needs to be updated/modified;</li> <li> <b>delete</b> an existing rule: existing Rules not included in the Rules list of the BrowserImpersonationDetection parameter will be deleted.</li>.
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// Specifies the name of the browser spoofing identification rule.
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Whether browser spoofing detection is enabled. valid values: <li>on: enabled;</li><li>off: disabled.</li>.
        /// </summary>
        [JsonProperty("Enabled")]
        public string Enabled{ get; set; }

        /// <summary>
        /// Specifies the specific content of browser spoofing identification rules, which only support configuration of request Method (Method), request Path (Path), and request URL, and must comply with expression grammar. for detailed specifications, please refer to the product document.
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// Describes the handling method for browser spoofing identification rules, including Cookie verification, session tracking configuration, and client behavior validation configuration.
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

