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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetAccountSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// Number of policies
        /// </summary>
        [JsonProperty("Policies")]
        public ulong? Policies{ get; set; }

        /// <summary>
        /// Number of roles
        /// </summary>
        [JsonProperty("Roles")]
        public ulong? Roles{ get; set; }

        /// <summary>
        /// Number of identity providers
        /// </summary>
        [JsonProperty("Idps")]
        public ulong? Idps{ get; set; }

        /// <summary>
        /// Number of sub-accounts
        /// </summary>
        [JsonProperty("User")]
        public ulong? User{ get; set; }

        /// <summary>
        /// Number of groups
        /// </summary>
        [JsonProperty("Group")]
        public ulong? Group{ get; set; }

        /// <summary>
        /// Total number of grouped users
        /// </summary>
        [JsonProperty("Member")]
        public ulong? Member{ get; set; }

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
            this.SetParamSimple(map, prefix + "Policies", this.Policies);
            this.SetParamSimple(map, prefix + "Roles", this.Roles);
            this.SetParamSimple(map, prefix + "Idps", this.Idps);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "Group", this.Group);
            this.SetParamSimple(map, prefix + "Member", this.Member);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

