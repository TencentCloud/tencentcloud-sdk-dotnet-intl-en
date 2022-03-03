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

namespace TencentCloud.Sts.V20180813.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetCallerIdentityResponse : AbstractModel
    {
        
        /// <summary>
        /// ARN of the current caller.
        /// </summary>
        [JsonProperty("Arn")]
        public string Arn{ get; set; }

        /// <summary>
        /// Root account UIN of the current caller.
        /// </summary>
        [JsonProperty("AccountId")]
        public string AccountId{ get; set; }

        /// <summary>
        /// User ID.
        /// 1. If the caller is a Tencent Cloud account, the UIN of the current account is returned.
        /// 2. If the caller is a role, `roleId:roleSessionName` is returned.
        /// 3. If the caller is a federated user, `uin:federatedUserName` is returned.
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// Account UIN.
        /// 1. If the caller is a Tencent Cloud account, the UIN of the current account is returned.
        /// 2. If the caller is a role, the UIN of the account that applies for the role is returned.
        /// </summary>
        [JsonProperty("PrincipalId")]
        public string PrincipalId{ get; set; }

        /// <summary>
        /// Identity type.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

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
            this.SetParamSimple(map, prefix + "Arn", this.Arn);
            this.SetParamSimple(map, prefix + "AccountId", this.AccountId);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "PrincipalId", this.PrincipalId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

