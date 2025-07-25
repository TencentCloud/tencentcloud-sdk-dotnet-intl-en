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

    public class AttachRolePolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// Policy ID. Either `PolicyId` or `PolicyName` must be entered
        /// </summary>
        [JsonProperty("PolicyId")]
        public ulong? PolicyId{ get; set; }

        /// <summary>
        /// Role ID, used to specify a role. Input either `AttachRoleId` or `AttachRoleName`
        /// </summary>
        [JsonProperty("AttachRoleId")]
        public string AttachRoleId{ get; set; }

        /// <summary>
        /// Role name, used to specify a role. Input either `AttachRoleId` or `AttachRoleName`
        /// </summary>
        [JsonProperty("AttachRoleName")]
        public string AttachRoleName{ get; set; }

        /// <summary>
        /// Policy name. Either `PolicyId` or `PolicyName` must be entered
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "AttachRoleId", this.AttachRoleId);
            this.SetParamSimple(map, prefix + "AttachRoleName", this.AttachRoleName);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
        }
    }
}

