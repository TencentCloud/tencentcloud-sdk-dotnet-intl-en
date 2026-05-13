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

    public class AutoSnapshotPolicy : AbstractModel
    {
        
        /// <summary>
        /// It lists IDs of cloud disks that have been bound to the current regular snapshot policy.
        /// 
        /// In the scenario of DescribeDiskAssociatedAutoSnapshotPolicy, this field returns empty.
        /// </summary>
        [JsonProperty("DiskIdSet")]
        public string[] DiskIdSet{ get; set; }

        /// <summary>
        /// Whether scheduled snapshot policy is activated.
        /// </summary>
        [JsonProperty("IsActivated")]
        public bool? IsActivated{ get; set; }

        /// <summary>
        /// Status of regular snapshot policy. valid values:.
        /// <ul>
        /// <Li>NORMAL: specifies the scaling group is in normal state.</li>.
        /// <Li>ISOLATED: specifies the instance is isolated.</li>.
        /// </ul>
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyState")]
        public string AutoSnapshotPolicyState{ get; set; }

        /// <summary>
        /// Whether it is a cross-account snapshot replication. valid values: 1 (yes), 0 (no).
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
        /// Lists instance ids that are bound to the current periodic snapshot policy.
        /// </summary>
        [JsonProperty("InstanceIdSet")]
        public string[] InstanceIdSet{ get; set; }

        /// <summary>
        /// Specifies the number of months snapshot can be retained.
        /// </summary>
        [JsonProperty("RetentionMonths")]
        public ulong? RetentionMonths{ get; set; }

        /// <summary>
        /// Specifies the maximum retention number of snapshots created by scheduled snapshot.
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

