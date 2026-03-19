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

namespace TencentCloud.Organization.V20210331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AttachPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Bind policy target ID. member Uin or department ID</p>.
        /// </summary>
        [JsonProperty("TargetId")]
        public ulong? TargetId{ get; set; }

        /// <summary>
        /// <p>Target type. valid values: NODE-department, MEMBER-MEMBER</p>.
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// <p>Policy Id. you can call the <a href="https://www.tencentcloud.com/document/product/850/105311?from_cn_redirect=1">ListPolicies</a> api to obtain it.</p>.
        /// </summary>
        [JsonProperty("PolicyId")]
        public ulong? PolicyId{ get; set; }

        /// <summary>
        /// <p>POLICY type. default value: SERVICE_CONTROL_POLICY. valid values: SERVICE_CONTROL_POLICY (SERVICE CONTROL POLICY) and TAG_POLICY (TAG POLICY).</p>.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetId", this.TargetId);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

