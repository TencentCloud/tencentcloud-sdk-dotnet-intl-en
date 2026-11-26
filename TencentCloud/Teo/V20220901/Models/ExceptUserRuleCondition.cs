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

    public class ExceptUserRuleCondition : AbstractModel
    {
        
        /// <summary>
        /// Matching item. Valid values:
        /// <li>host: request domain name;</li>
        /// <li>sip: Client IP;</li>
        /// <li>ua:User-Agent;</li>
        /// <li>cookie: Session cookie;</li>
        /// <li>cgi: CGI script;</li>
        /// <li>xff: XFF extension header;</li>
        /// <li>`url`: Request URL;
        /// <li>accept: request content type;</li>
        /// <li>method: request method;</li>
        /// <li>header: request header;</li>
        /// <li>sip_proto: network layer protocol.</li>
        /// </summary>
        [JsonProperty("MatchFrom")]
        public string MatchFrom{ get; set; }

        /// <summary>
        /// Parameter of the matching item. Only when MatchFrom is header, you can use this parameter, and the key of the header can be set to this parameter.
        /// </summary>
        [JsonProperty("MatchParam")]
        public string MatchParam{ get; set; }

        /// <summary>
        /// Matching operator. Valid values:
        /// <li>equal: string equals;</li>
        /// <li>not_equal: value not equal to;</li>
        /// <li>include: string containing;</li>
        /// <li>not_include: string does not contain;</li>
        /// <li>match: ip match;</li>
        /// <li>not_match: ip not matched;</li>
        /// <li>include_area: region inclusion;</li>
        /// <li>is_empty: field with null value;</li>
        /// <li>not_exists: key field not found;</li>
        /// <li>regexp: regular expression matching;</li>
        /// <li>len_gt: value greater than;</li>
        /// <li>len_lt: value is less than;</li>
        /// <li>len_eq: value equal to;</li>
        /// <li>match_prefix: prefix match;</li>
        /// <li>match_suffix: suffix matching;</li>
        /// <li>wildcard: wildcard.</li>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// Matching value.
        /// </summary>
        [JsonProperty("MatchContent")]
        public string MatchContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MatchFrom", this.MatchFrom);
            this.SetParamSimple(map, prefix + "MatchParam", this.MatchParam);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "MatchContent", this.MatchContent);
        }
    }
}

