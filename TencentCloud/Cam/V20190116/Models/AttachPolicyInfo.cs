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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AttachPolicyInfo : AbstractModel
    {
        
        /// <summary>
        /// Policy ID
        /// </summary>
        [JsonProperty("PolicyId")]
        public ulong? PolicyId{ get; set; }

        /// <summary>
        /// Policy name
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// Time created
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// How the policy was created: 1: Via console; 2: Via syntax
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("CreateMode")]
        public ulong? CreateMode{ get; set; }

        /// <summary>
        /// Valid values: `user` and `QCS`
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("PolicyType")]
        public string PolicyType{ get; set; }

        /// <summary>
        /// Policy remarks
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Root account of the operator associating the policy
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OperateOwnerUin")]
        public string OperateOwnerUin{ get; set; }

        /// <summary>
        /// The ID of the account associating the policy. If `UinType` is 0, this indicates that this is a sub-account `UIN`. If `UinType` is 1, this indicates this is a role ID
        /// </summary>
        [JsonProperty("OperateUin")]
        public string OperateUin{ get; set; }

        /// <summary>
        /// If `UinType` is 0, `OperateUin` indicates that this is a sub-account `UIN`. If `UinType` is 1, `OperateUin` indicates that this is a role ID
        /// </summary>
        [JsonProperty("OperateUinType")]
        public ulong? OperateUinType{ get; set; }

        /// <summary>
        /// Queries if the policy has been deactivated
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Deactived")]
        public ulong? Deactived{ get; set; }

        /// <summary>
        /// List of deprecated products
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeactivedDetail")]
        public string[] DeactivedDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "CreateMode", this.CreateMode);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "OperateOwnerUin", this.OperateOwnerUin);
            this.SetParamSimple(map, prefix + "OperateUin", this.OperateUin);
            this.SetParamSimple(map, prefix + "OperateUinType", this.OperateUinType);
            this.SetParamSimple(map, prefix + "Deactived", this.Deactived);
            this.SetParamArraySimple(map, prefix + "DeactivedDetail.", this.DeactivedDetail);
        }
    }
}

