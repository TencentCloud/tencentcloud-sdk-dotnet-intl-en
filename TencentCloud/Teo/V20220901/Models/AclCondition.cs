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

    public class AclCondition : AbstractModel
    {
        
        /// <summary>
        /// Filters: 
        /// <li>`host`: Request domain name;</li>
        /// <li>`sip`: Client IP;</li>
        /// <li>`ua`: User-Agent;</li>
        /// <li>`cookie`: Cookie;</li>
        /// <li>`cgi`: CGI script;</li>
        /// <li>`xff`: XFF header;</li></li>
        /// <li>`url`: Request URL;<li></li>
        /// <li>`accept`: Request content type;</li>
        /// <li>`method`: Request method<;/li>
        /// <li>`header`: Request header;</li>
        /// <li>`app_proto`: Application layer protocol;</li>
        /// <li>`sip_proto`: Network layer protocol;</li>
        /// <li>`uabot`: UA rules (only available in custom bot rules);</li>
        /// <li>`idcid`: IDC rules (only available in custom bot rules);</li>
        /// <li>`sipbot`: Search engine rules (only available in custom bot rules);</li>
        /// <li>`portrait`: Client reputation (only available in custom bot rules);</li>
        /// <li>`header_seq`: Header sequence (only available in custom bot rules);</li>
        /// <li>`hdr`: Request body (only available in custom Web protection rules). </li>
        /// </summary>
        [JsonProperty("MatchFrom")]
        public string MatchFrom{ get; set; }

        /// <summary>
        /// The parameter of the field. When `MatchFrom = header`, the key contained in the header can be passed.
        /// </summary>
        [JsonProperty("MatchParam")]
        public string MatchParam{ get; set; }

        /// <summary>
        /// The logical operator. Values:
        /// <li>`equal`: Value equals</li>
        /// <li>`not_equal`: Value not equals</li>
        /// <li>`include`: String contains</li>
        /// <li>`not_include`: String not contains</li>
        /// <li>`match`: IP matches</li>
        /// <li>`not_match`: IP not matches</li>
        /// <li>`include_area`: Regions contain</li>
        /// <li>`is_empty`: Value left empty</li>
        /// <li>`not_exists`: Key fields not exist</li>
        /// <li>`regexp`: Regex matches</li>
        /// <li>`len_gt`: Value greater than</li>
        /// <li>`len_lt`: Value smaller than</li>
        /// <li>`len_eq`: Value equals</li>
        /// <li>`match_prefix`: Prefix matches</li>
        /// <li>`match_suffix`: Suffix matches</li>
        /// <li>`wildcard`: Wildcard</li>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// The content to match.
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

