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

    public class HostPolicy : AbstractModel
    {
        
        /// <summary>
        /// <p>Site-level policy, a policy that takes effect for all domain names under the site. For details, see Site-level Policy.</p>
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// <p>Policy type used by the current domain. Valid values: <li>ZoneDefault: use a site-level policy, which is the policy settings defined in ZoneDefaultPolicy.</li><li>Custom: use a domain-level policy. When using this option, the Policy field must also be configured to specify the detailed policy settings.</li><li>Template: use a policy template. When using this option, the TemplateId field must also be configured to specify the policy template used by the current domain.</li></p>
        /// </summary>
        [JsonProperty("PolicyType")]
        public string PolicyType{ get; set; }

        /// <summary>
        /// <p>Optional. When PolicyType is Custom, this field is the detailed policy configuration of the current domain name, which takes effect on the current domain.</p>
        /// </summary>
        [JsonProperty("Policy")]
        public SecurityPolicy Policy{ get; set; }

        /// <summary>
        /// <p>Optional. When PolicyType is Template, this field is used to specify the Id of the policy Template used by the current domain.</p>
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamObj(map, prefix + "Policy.", this.Policy);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
        }
    }
}

