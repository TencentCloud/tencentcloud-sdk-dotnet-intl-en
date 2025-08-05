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

    public class JSInjectionRule : AbstractModel
    {
        
        /// <summary>
        /// Rule ID.
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// Rule name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Rule priority. a smaller value indicates higher priority execution. value range: 0-100. default value is 0.
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// Specifies the match condition content, which must comply with the expression grammar. please refer to the product document for detailed requirements.
        /// </summary>
        [JsonProperty("Condition")]
        public string Condition{ get; set; }

        /// <summary>
        /// JavaScript injection option. default value: run-attestations. valid values:.
        /// <li>no-injection: specifies not to inject JavaScript.</li>.
        /// <li>inject-sdk-only: injects sdks for all currently supported authentication methods. currently supported: TC-RCE and TC-CAPTCHA. note: to execute authentication detection, configure challenge rules.</li>.
        /// </summary>
        [JsonProperty("InjectJS")]
        public string InjectJS{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Condition", this.Condition);
            this.SetParamSimple(map, prefix + "InjectJS", this.InjectJS);
        }
    }
}

