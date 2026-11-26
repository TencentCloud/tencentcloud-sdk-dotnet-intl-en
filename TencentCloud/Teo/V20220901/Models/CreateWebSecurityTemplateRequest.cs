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
        /// Site ID. This parameter clarifies the site to which the policy template belongs in terms of access permission.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Policy template name. It consists of Chinese characters, letters, digits, and underscores. It cannot begin with an underscore and cannot exceed 32 characters in length.
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// Configuration file content of the security policy template. If the field is empty, a default configuration is generated. Currently supports exception rules, custom rules, rate limiting rules, and managed rule configuration in the Web protection module. Configure the security policy through expression syntax. Bot management rule configuration is not currently supported and is under development.
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

