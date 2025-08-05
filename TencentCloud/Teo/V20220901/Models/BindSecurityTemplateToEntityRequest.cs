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
        /// Site ID of the policy template to be bound to or unbound from.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// List of domain names to bind to/unbind from a policy template
        /// </summary>
        [JsonProperty("Entities")]
        public string[] Entities{ get; set; }

        /// <summary>
        /// Bind or unbind operation option. valid values:.
        /// <Li>`Bind`: bind the domain name to the policy template.</li>.
        /// <li>unbind-keep-policy: unbind a domain name from the policy template while retaining the current policy.</li>.
        /// <li>unbind-use-default: unbind a domain name from the policy template and use the default blank policy.</li> note: the unbinding operation currently only supports unbinding a single domain name. that is, when the Operate parameter value is unbind-keep-policy or unbind-use-default, the Entities parameter list only supports filling in one domain name.
        /// </summary>
        [JsonProperty("Operate")]
        public string Operate{ get; set; }

        /// <summary>
        /// Specifies the ID of the policy template or the site global policy to be bound or unbound.
        /// <li>To bind to a policy template, or unbind from it, specify the policy template ID.</li>.
        /// <li>To bind to the site's global policy, or unbind from it, use the @ZoneLevel@domain parameter value.</li>.
        /// 
        /// Note: After unbinding, the domain name will use an independent policy and rule quota will be calculated separately. Please make sure there is sufficient rule quota before unbinding.
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// If the imported domain name has already been bound to a policy template (including a site-level security policy), this parameter indicates whether to replace the template by setting it. the default value is true. values: <li>`true`: replace the template currently bound to the domain.</li> <li>`false`: do not replace the template currently bound to the domain.</li> note: when set to false, if the imported domain name has already been bound to a policy template, the API will return an error; a site-level security policy is also a type of policy template.
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

