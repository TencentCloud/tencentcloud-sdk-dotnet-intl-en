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
        /// The list of cloud disk IDs that the current scheduled snapshot policy is bound to.
        /// </summary>
        [JsonProperty("DiskIdSet")]
        public string[] DiskIdSet{ get; set; }

        /// <summary>
        /// Whether scheduled snapshot policy is activated.
        /// </summary>
        [JsonProperty("IsActivated")]
        public bool? IsActivated{ get; set; }

        /// <summary>
        /// Scheduled snapshot policy state. Value range:<br><li>NORMAL: Normal<br><li>ISOLATED: Isolated.
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyState")]
        public string AutoSnapshotPolicyState{ get; set; }

        /// <summary>
        /// Whether it is to replicate a snapshot across accounts. `1`: yes, `0`: no.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsCopyToRemote")]
        public ulong? IsCopyToRemote{ get; set; }

        /// <summary>
        /// Whether the snapshot created by this scheduled snapshot policy is retained permanently.
        /// </summary>
        [JsonProperty("IsPermanent")]
        public bool? IsPermanent{ get; set; }

        /// <summary>
        /// The time the scheduled snapshot will be triggered again.
        /// </summary>
        [JsonProperty("NextTriggerTime")]
        public string NextTriggerTime{ get; set; }

        /// <summary>
        /// Scheduled snapshot policy name.
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyName")]
        public string AutoSnapshotPolicyName{ get; set; }

        /// <summary>
        /// Scheduled snapshot policy ID.
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyId")]
        public string AutoSnapshotPolicyId{ get; set; }

        /// <summary>
        /// The policy for executing the scheduled snapshot.
        /// </summary>
        [JsonProperty("Policy")]
        public Policy[] Policy{ get; set; }

        /// <summary>
        /// The time the scheduled snapshot policy was created.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Number of days the snapshot created by this scheduled snapshot policy is retained.
        /// </summary>
        [JsonProperty("RetentionDays")]
        public ulong? RetentionDays{ get; set; }

        /// <summary>
        /// ID of the replication target account
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CopyToAccountUin")]
        public string CopyToAccountUin{ get; set; }

        /// <summary>
        /// List of IDs of the instances associated with the scheduled snapshot policy.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceIdSet")]
        public string[] InstanceIdSet{ get; set; }

        /// <summary>
        /// The number of months for which the snapshots created by this scheduled snapshot policy can be retained.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RetentionMonths")]
        public ulong? RetentionMonths{ get; set; }

        /// <summary>
        /// The maximum number of snapshots created by this scheduled snapshot policy that can be retained.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RetentionAmount")]
        public ulong? RetentionAmount{ get; set; }

        /// <summary>
        /// Retention policy for scheduled snapshots.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AdvancedRetentionPolicy")]
        public AdvancedRetentionPolicy AdvancedRetentionPolicy{ get; set; }

        /// <summary>
        /// Source account ID of the copied snapshot policy
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CopyFromAccountUin")]
        public string CopyFromAccountUin{ get; set; }

        /// <summary>
        /// Tag.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DiskIdSet.", this.DiskIdSet);
            this.SetParamSimple(map, prefix + "IsActivated", this.IsActivated);
            this.SetParamSimple(map, prefix + "AutoSnapshotPolicyState", this.AutoSnapshotPolicyState);
            this.SetParamSimple(map, prefix + "IsCopyToRemote", this.IsCopyToRemote);
            this.SetParamSimple(map, prefix + "IsPermanent", this.IsPermanent);
            this.SetParamSimple(map, prefix + "NextTriggerTime", this.NextTriggerTime);
            this.SetParamSimple(map, prefix + "AutoSnapshotPolicyName", this.AutoSnapshotPolicyName);
            this.SetParamSimple(map, prefix + "AutoSnapshotPolicyId", this.AutoSnapshotPolicyId);
            this.SetParamArrayObj(map, prefix + "Policy.", this.Policy);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "RetentionDays", this.RetentionDays);
            this.SetParamSimple(map, prefix + "CopyToAccountUin", this.CopyToAccountUin);
            this.SetParamArraySimple(map, prefix + "InstanceIdSet.", this.InstanceIdSet);
            this.SetParamSimple(map, prefix + "RetentionMonths", this.RetentionMonths);
            this.SetParamSimple(map, prefix + "RetentionAmount", this.RetentionAmount);
            this.SetParamObj(map, prefix + "AdvancedRetentionPolicy.", this.AdvancedRetentionPolicy);
            this.SetParamSimple(map, prefix + "CopyFromAccountUin", this.CopyFromAccountUin);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

