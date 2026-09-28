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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSecurityPoliciesRequest : AbstractModel
    {
        
        /// <summary>
        /// Filter condition list for filtering security policies that meet the specified conditions. Multiple filter conditions are in an "AND" relationship with each other.
        /// 
        /// **Supported filter conditions:**
        /// - **SecurityPolicyNames**: Filter by security policy name. Fuzzy matching is supported.
        /// - **tag:tag-key**: Filter by tag key-value pair. Replace tag-key with the actual tag key. For example, `tag:env` means filtering by the tag key `env`.
        /// 
        /// **Description:** Each filter condition supports a maximum of 10 values.
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// Maximum number of results returned for a single request. For pagination queries, use together with NextToken.
        /// 
        /// **Value range:** from 1 to 100.
        /// 
        /// **Default value:** 20.
        /// </summary>
        [JsonProperty("MaxResults")]
        public long? MaxResults{ get; set; }

        /// <summary>
        /// Token for the paging query start. Used to obtain the result data on the next page.
        /// 
        /// **Instructions:**
        /// -No need to set this parameter for the initial query.
        /// - If the last query returned NextToken, it means there is more data. Input this value to retrieve the next page.
        /// -If the last query did not return NextToken or returned empty, it means the current page is the last page.
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }

        /// <summary>
        /// Security policy ID list. The ID format is `tls-` followed by 8 alphanumeric characters.
        /// </summary>
        [JsonProperty("SecurityPolicyIds")]
        public string[] SecurityPolicyIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
            this.SetParamArraySimple(map, prefix + "SecurityPolicyIds.", this.SecurityPolicyIds);
        }
    }
}

