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

namespace TencentCloud.Cbs.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoSnapshotPolicy : AbstractModel
    {
        
        /// <summary>
        /// Scheduled snapshot policy ID.
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyId")]
        public string AutoSnapshotPolicyId{ get; set; }

        /// <summary>
        /// Scheduled snapshot policy name.
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyName")]
        public string AutoSnapshotPolicyName{ get; set; }

        /// <summary>
        /// Scheduled snapshot policy state. Value range:<br><li>NORMAL: Normal<br><li>ISOLATED: Isolated.
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyState")]
        public string AutoSnapshotPolicyState{ get; set; }

        /// <summary>
        /// Whether scheduled snapshot policy is activated.
        /// </summary>
        [JsonProperty("IsActivated")]
        public bool? IsActivated{ get; set; }

        /// <summary>
        /// Whether the snapshot created by this scheduled snapshot policy is retained permanently.
        /// </summary>
        [JsonProperty("IsPermanent")]
        public bool? IsPermanent{ get; set; }

        /// <summary>
        /// Number of days the snapshot created by this scheduled snapshot policy is retained.
        /// </summary>
        [JsonProperty("RetentionDays")]
        public ulong? RetentionDays{ get; set; }

        /// <summary>
        /// The time the scheduled snapshot policy was created.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// The time the scheduled snapshot will be triggered again.
        /// </summary>
        [JsonProperty("NextTriggerTime")]
        public string NextTriggerTime{ get; set; }

        /// <summary>
        /// The policy for executing the scheduled snapshot.
        /// </summary>
        [JsonProperty("Policy")]
        public Policy[] Policy{ get; set; }

        /// <summary>
        /// The list of cloud disk IDs that the current scheduled snapshot policy is bound to.
        /// </summary>
        [JsonProperty("DiskIdSet")]
        public string[] DiskIdSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoSnapshotPolicyId", this.AutoSnapshotPolicyId);
            this.SetParamSimple(map, prefix + "AutoSnapshotPolicyName", this.AutoSnapshotPolicyName);
            this.SetParamSimple(map, prefix + "AutoSnapshotPolicyState", this.AutoSnapshotPolicyState);
            this.SetParamSimple(map, prefix + "IsActivated", this.IsActivated);
            this.SetParamSimple(map, prefix + "IsPermanent", this.IsPermanent);
            this.SetParamSimple(map, prefix + "RetentionDays", this.RetentionDays);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "NextTriggerTime", this.NextTriggerTime);
            this.SetParamArrayObj(map, prefix + "Policy.", this.Policy);
            this.SetParamArraySimple(map, prefix + "DiskIdSet.", this.DiskIdSet);
        }
    }
}

