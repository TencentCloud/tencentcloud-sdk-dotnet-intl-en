/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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
        /// Action options. Values include:
        /// <li>`bind`: Bind the domain names to the specified policy template </li>
        /// <li>`unbind-keep-policy`: Unbind a domain name from a policy template and keep the current policy when unbinding</li>
        /// <li>`unbind-use-default`: Unbind domain names from policy templates and use default blank policy.</li> Note: Only one domain name can be unbound at one time. When `Operate` is `unbind-keep-policy` or `unbind-use-default`, there can only be one domain name specified in `Entities`.
        /// </summary>
        [JsonProperty("Operate")]
        public string Operate{ get; set; }

        /// <summary>
        /// Specifies the ID of the policy template or the site's global policy to be bound or unbound.
        /// - To bind to a policy template, or unbind from it, specify the policy template ID.
        /// - To bind to the site's global policy, or unbind from it, use the @ZoneLevel@domain parameter value.
        /// 
        /// Note: After unbinding, the domain name will use an independent policy and rule quota will be calculated separately. Please make sure there is sufficient rule quota before unbinding.
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// Whether to replace the existing policy template bound with the domain name. Values: 
        /// <li>`true`: Replace the template bound to the domain. </li>
        /// <li>`false`: Do not replace the template.</li> Note: In this case, the API returns an error if there is already a policy template bound to the specified domain name.
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

