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

    public class DescribeSecurityPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// Zone ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// `SecurityPolicy` type, the following parameter values can be used for query: <li>`ZoneDefaultPolicy`: used to specify a query for site-level policies;</li> <li>`Template`: used to specify a query for policy templates. the `TemplateId` parameter needs to be specified simultaneously;</li> <li>`Host`: used to specify a query for domain-level policies (note: when using `Host` to specify a domain name service policy, only domain name services or policy templates that have been applied domain-level policies are supported).</li>	
        /// </summary>
        [JsonProperty("Entity")]
        public string Entity{ get; set; }

        /// <summary>
        /// Specify the policy Template ID. Use this parameter to specify the ID of the policy Template to query the Template configuration when the `Entity` parameter value is set to `Template`.
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// Specify the domain name. When the `Entity` parameter value is set to `Host`, use the domain-level policy specified by this parameter to query the domain configuration. For example, use `www.example.com` to configure the domain-level policy for that domain name.
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Entity", this.Entity);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "Host", this.Host);
        }
    }
}

