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

    public class BindSecurityTemplateToEntityRequest : AbstractModel
    {
        
        /// <summary>
        /// Site ID of the policy template to be bound or unbound.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Domain name list bound to the policy template (or unbound from it).
        /// </summary>
        [JsonProperty("Entities")]
        public string[] Entities{ get; set; }

        /// <summary>
        /// Bind or unbind operation options. Valid values:
        /// <li>bind: Bind a domain name to the policy template.</li>
        /// <li>unbind-keep-policy: Unbind the domain name from the policy template while retaining the current policy.</li>
        /// <li>unbind-use-default: Unbind the domain name from the policy template and use the default blank policy.</li>Note: The unbinding operation currently only supports unbinding a single domain name. That is, when the Operate parameter value is unbind-keep-policy or unbind-use-default, the Entities parameter list supports filling in only one domain name.
        /// </summary>
        [JsonProperty("Operate")]
        public string Operate{ get; set; }

        /// <summary>
        /// Specifies the ID of the policy template or the site global policy to be bound or unbound.
        /// <li>To bind to a policy template, or unbind from it, specify the policy template ID.</li>
        /// <li>To bind to the site's global policy, or unbind from it, use the @ZoneLevel@domain parameter value.</li>
        /// 
        /// Note: After unbinding, the domain name will use an independent policy and rule quota will be calculated separately. Please make sure there is sufficient rule quota before unbinding.
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// If the imported domain name is already bound to a policy template (including a site-level protection strategy), setting this parameter indicates whether to replace the template. Default value: true. Valid values: <li>true: Replace the template currently bound to the domain name.</li><li>false: Do not replace the template currently bound to the domain name.</li>Note: When set to false, if the imported domain name is already bound to a policy template, an error will be returned. A site-level protection strategy is also a type of policy template.
        /// </summary>
        [JsonProperty("OverWrite")]
        public bool? OverWrite{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArraySimple(map, prefix + "Entities.", this.Entities);
            this.SetParamSimple(map, prefix + "Operate", this.Operate);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "OverWrite", this.OverWrite);
        }
    }
}

