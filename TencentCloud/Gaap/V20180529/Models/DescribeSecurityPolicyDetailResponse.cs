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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSecurityPolicyDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// Connection ID
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }

        /// <summary>
        /// Security policy status:
        /// BOUND (security policies enabled)
        /// UNBIND (security policies disabled)
        /// BINDING (enabling security policies)
        /// UNBINDING (disabling security policies)
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Default policy: ACCEPT or DROP.
        /// </summary>
        [JsonProperty("DefaultAction")]
        public string DefaultAction{ get; set; }

        /// <summary>
        /// Policy ID
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// List of rules
        /// </summary>
        [JsonProperty("RuleList")]
        public SecurityPolicyRuleOut[] RuleList{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "DefaultAction", this.DefaultAction);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamArrayObj(map, prefix + "RuleList.", this.RuleList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

