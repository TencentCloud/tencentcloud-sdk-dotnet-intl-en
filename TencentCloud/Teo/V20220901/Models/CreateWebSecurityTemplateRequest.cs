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

    public class CreateWebSecurityTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Zone ID. Explicitly identifies the zone to which the policy template belongs for access control purposes.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Policy template name. Composed of Chinese characters, letters, digits, and underscores. Cannot begin with an underscore and must be less than or equal to 32 characters.
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// Web security policy template configuration. Generates default config if empty. Supported: Exception rules, custom rules, rate limiting rules, managed rules. Not supported: Bot management rules (under development).
        /// </summary>
        [JsonProperty("SecurityPolicy")]
        public SecurityPolicy SecurityPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamObj(map, prefix + "SecurityPolicy.", this.SecurityPolicy);
        }
    }
}

