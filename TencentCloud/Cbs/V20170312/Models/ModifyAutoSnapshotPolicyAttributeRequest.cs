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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAutoSnapshotPolicyAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies the scheduled snapshot policy ID. query via the describeautosnapshotpolicies API (https://www.tencentcloud.com/document/product/362/33556?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyId")]
        public string AutoSnapshotPolicyId{ get; set; }

        /// <summary>
        /// Whether the periodic snapshot policy is activated. `false` means inactive, `true` means active. defaults to `true`.
        /// </summary>
        [JsonProperty("IsActivated")]
        public bool? IsActivated{ get; set; }

        /// <summary>
        /// Indicates whether snapshots created by the regular snapshot policy are retained permanently. `false` means the snapshots are not retained permanently, `true` means permanent retention. defaults to `false`.
        /// </summary>
        [JsonProperty("IsPermanent")]
        public bool? IsPermanent{ get; set; }

        /// <summary>
        /// The name of the scheduled snapshot policy to be created. If it is left empty, the default is 'Not named'. The maximum length cannot exceed 60 bytes.
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyName")]
        public string AutoSnapshotPolicyName{ get; set; }

        /// <summary>
        /// The policy for executing the scheduled snapshot.
        /// </summary>
        [JsonProperty("Policy")]
        public Policy[] Policy{ get; set; }

        /// <summary>
        /// Number of days to retain the snapshots created according to this scheduled snapshot policy. If this parameter is specified, `IsPermanent` cannot be specified as `TRUE`; otherwise, they will conflict with each other.
        /// </summary>
        [JsonProperty("RetentionDays")]
        public ulong? RetentionDays{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoSnapshotPolicyId", this.AutoSnapshotPolicyId);
            this.SetParamSimple(map, prefix + "IsActivated", this.IsActivated);
            this.SetParamSimple(map, prefix + "IsPermanent", this.IsPermanent);
            this.SetParamSimple(map, prefix + "AutoSnapshotPolicyName", this.AutoSnapshotPolicyName);
            this.SetParamArrayObj(map, prefix + "Policy.", this.Policy);
            this.SetParamSimple(map, prefix + "RetentionDays", this.RetentionDays);
        }
    }
}

