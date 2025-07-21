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

    public class ModifyWebSecurityTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// Zone ID. The zone to which the target policy template belongs for access control. Use the DescribeWebSecurityTemplates interface to query the zone of the policy template.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Policy template ID.
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// Modified policy template name. Consists of Chinese characters, letters, numbers, and underscores, cannot start with an underscore, and must not exceed 32 characters. If the field is empty, no modification will be made.
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// Security policy template configuration content. If the value is empty, no modification will be made; submodule structures not passed in will not be modified. Currently supports exception rules, custom rules, rate limiting rules, and managed rule configurations in the Web Security module, using expression syntax for security policy configuration. Bot management rule configuration is not yet supported (under development).
        /// Special note: When passing a submodule structure as input, ensure all rule content to be retained is included. Rule content not passed in will be treated as deleted.
        /// </summary>
        [JsonProperty("SecurityPolicy")]
        public SecurityPolicy SecurityPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamObj(map, prefix + "SecurityPolicy.", this.SecurityPolicy);
        }
    }
}

