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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyRoutePolicyAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID of the route reception policy, such as rrp-dz0219jq.
        /// </summary>
        [JsonProperty("RoutePolicyId")]
        public string RoutePolicyId{ get; set; }

        /// <summary>
        /// Specifies the route reception policy name.
        /// </summary>
        [JsonProperty("RoutePolicyName")]
        public string RoutePolicyName{ get; set; }

        /// <summary>
        /// Describes the route reception policy.
        /// </summary>
        [JsonProperty("RoutePolicyDescription")]
        public string RoutePolicyDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoutePolicyId", this.RoutePolicyId);
            this.SetParamSimple(map, prefix + "RoutePolicyName", this.RoutePolicyName);
            this.SetParamSimple(map, prefix + "RoutePolicyDescription", this.RoutePolicyDescription);
        }
    }
}

