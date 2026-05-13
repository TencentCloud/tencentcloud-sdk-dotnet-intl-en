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

    public class Disk : AbstractModel
    {
        
        /// <summary>
        /// Specifies whether the cloud disk is destroyed along with the mounted instance.<br><li>true: destroy the cloud disk along with the instance. only hourly postpaid cloud disk is supported.</li><li>false: destroying instance without destroying cloud disk.</li>.
        /// </summary>
        [JsonProperty("DeleteWithInstance")]
        public bool? DeleteWithInstance{ get; set; }

        /// <summary>
        /// AUTO renewal flag. supported values:<br><li>NOTIFY_AND_AUTO_RENEW: NOTIFY expiry AND RENEW automatically</li><li>NOTIFY_AND_MANUAL_RENEW: NOTIFY expiry but not RENEW automatically</li><li>DISABLE_NOTIFY_AND_MANUAL_RENEW: neither NOTIFY expiry nor RENEW automatically.</li>.
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// Hard disk media type. valid values:<br><li>CLOUD_BASIC: BASIC CLOUD disk</li><li>CLOUD_PREMIUM: high-performance CLOUD block storage</li><li>CLOUD_BSSD: universal type SSD CLOUD disk</li><li>CLOUD_SSD: SSD CLOUD disk</li><li>CLOUD_HSSD: enhanced SSD CLOUD disk</li><li>CLOUD_TSSD: ultra-fast SSD cbs.</li>.
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// Cloud disk state. valid values:<br><li>UNATTACHED: unmounted</li><li>ATTACHING: mounting</li><li>ATTACHED: mounted</li><li>DETACHING: unmounting</li><li>EXPANDING: EXPANDING</li><li>ROLLBACKING: rolling back</li><li>TORECYCLE: to be recycled</li><li>DUMPING: copying hard drive.</li>.
        /// </summary>
        [JsonProperty("DiskState")]
        public string DiskState{ get; set; }

        /// <summary>
        /// The total number of snapshots of the cloud disk.
        /// </summary>
        [JsonProperty("SnapshotCount")]
        public long? SnapshotCount{ get; set; }

        /// <summary>
        /// Cloud disk mounted to child machine, and both child machine and cloud disk are on a monthly subscription basis.<br><li>true: auto renewal flag is set for child machine, but cloud disk not set</li><li>false: cloud disk auto-renewal flag normal</li>.
        /// </summary>
        [JsonProperty("AutoRenewFlagError")]
        public bool? AutoRenewFlagError{ get; set; }

        /// <summary>
        /// Indicates if the cloud disk is in snapshot rollback status. valid values: <br><li>false: means not in snapshot rollback status</li><li>true: means in snapshot rollback status.</li>.
        /// </summary>
        [JsonProperty("Rollbacking")]
        public bool? Rollbacking{ get; set; }

        /// <summary>
        /// For non-shareable cloud disks, this parameter is null. For shareable cloud disks, this parameters indicates this cloud disk's Instance IDs currently mounted to the CVM.
        /// </summary>
        [JsonProperty("InstanceIdList")]
        public string[] InstanceIdList{ get; set; }

        /// <summary>
        /// Indicates whether the cloud disk is encrypted. valid values:<br><li>false: non-encrypted disk</li><li>true: encrypted disk</li>.
        /// </summary>
        [JsonProperty("Encrypt")]
        public bool? Encrypt{ get; set; }

        /// <summary>
        /// Cloud disk name.
        /// </summary>
        [JsonProperty("DiskName")]
        public string DiskName{ get; set; }

        /// <summary>
        /// Specifies whether to create a snapshot when the cloud disk is terminated due to overdue payment or expiration. `true`: create snapshot; `false`: do not create snapshot.
        /// </summary>
        [JsonProperty("BackupDisk")]
        public bool? BackupDisk{ get; set; }

        /// <summary>
        /// It indicates the tag bound to the cloud disk. If the cloud disk is not bound to any tag, the value is empty.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// ID of the CVM to which the cloud disk is mounted.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// The mount type of the cloud disk. valid values: <br><li>PF: PF mount</li><li>VF: VF mount</li>.
        /// </summary>
        [JsonProperty("AttachMode")]
        public string AttachMode{ get; set; }

        /// <summary>
        /// Regular snapshot ID associated with the cloud disk. return this parameter only when calling the [DescribeDisks](https://www.tencentcloud.com/document/product/362/16315?from_cn_redirect=1) API with ReturnBindAutoSnapshotPolicy set to TRUE.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyIds")]
        public string[] AutoSnapshotPolicyIds{ get; set; }

        /// <summary>
        /// Specifies the additional performance value of the CBS in MiB/s.
        /// </summary>
        [JsonProperty("ThroughputPerformance")]
        public ulong? ThroughputPerformance{ get; set; }

        /// <summary>
        /// Indicates if the cloud disk is in type change. valid values: <br><li>false: means the cloud disk is not in type change</li><li>true: means the cloud disk has initiated type change and is migrating.</li>.
        /// </summary>
        [JsonProperty("Migrating")]
        public bool? Migrating{ get; set; }

        /// <summary>
        /// Cloud disk ID.
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// Total snapshot capacity of the cloud disk. unit: MiB.
        /// </summary>
        [JsonProperty("SnapshotSize")]
        public ulong? SnapshotSize{ get; set; }

        /// <summary>
        /// Location of the cloud disk.
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// Determines if a prepaid cloud disk supports proactive return.<br><li>true: supports proactive return</li><li>false: does not support proactive return.</li>.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsReturnable")]
        public bool? IsReturnable{ get; set; }

        /// <summary>
        /// Expiration time of the cloud disk.
        /// </summary>
        [JsonProperty("DeadlineTime")]
        public string DeadlineTime{ get; set; }

        /// <summary>
        /// Indicates whether the cloud disk is mounted to the cvm. valid values: <br><li>false: means not mounted</li><li>true: means mounted.</li>.
        /// </summary>
        [JsonProperty("Attached")]
        public bool? Attached{ get; set; }

        /// <summary>
        /// Specifies the disk capacity in GiB.
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// It indicates the migration progress of cloud disk type change. The value range is 0 to 100.
        /// </summary>
        [JsonProperty("MigratePercent")]
        public ulong? MigratePercent{ get; set; }

        /// <summary>
        /// Cloud DISK type. valid values:<br><li>SYSTEM_DISK: SYSTEM DISK</li><li>DATA_DISK: DATA DISK.</li>.
        /// </summary>
        [JsonProperty("DiskUsage")]
        public string DiskUsage{ get; set; }

        /// <summary>
        /// Payment mode. valid values: <br><li>PREPAID: PREPAID, i.e. monthly subscription</li><li>POSTPAID_BY_HOUR: POSTPAID, i.e. pay-as-you-go.</li>.
        /// </summary>
        [JsonProperty("DiskChargeType")]
        public string DiskChargeType{ get; set; }

        /// <summary>
        /// Whether it is an elastic cloud disk. false: Non-elastic cloud disk; true: Elastic cloud disk.
        /// </summary>
        [JsonProperty("Portable")]
        public bool? Portable{ get; set; }

        /// <summary>
        /// Specifies whether the cloud disk has the capability to create snapshots. valid values:<br><li>false: cannot create snapshots</li><li>true: can create snapshots.</li>.
        /// </summary>
        [JsonProperty("SnapshotAbility")]
        public bool? SnapshotAbility{ get; set; }

        /// <summary>
        /// Indicates whether the cloud disk expiration time is earlier than that of the instance. this field is valid only when the cloud disk is mounted to the instance and both the instance and the cloud disk are on a monthly subscription basis.<br><li>true: the expiration time of the cloud disk is earlier than that of the instance.</li><li>false: cloud disk expiration time later than instance.</li>.
        /// </summary>
        [JsonProperty("DeadlineError")]
        public bool? DeadlineError{ get; set; }

        /// <summary>
        /// Rollback progress of a cloud disk snapshot.
        /// </summary>
        [JsonProperty("RollbackPercent")]
        public ulong? RollbackPercent{ get; set; }

        /// <summary>
        /// The number of days from the current time to disk expiration (only applicable to prepaid cbs).
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DifferDaysOfDeadline")]
        public long? DifferDaysOfDeadline{ get; set; }

        /// <summary>
        /// For prepaid cloud disks that do not support proactive return, this parameter indicates the specific reason for not supporting refund. value range: <br><li>1: the cloud disk has already been returned.</li><li>2: the cloud disk has expired.</li><li>3: the cloud disk does not support return.</li><li>8: the maximum returnable quantity is exceeded.</li><li>10: non-elastic cloud disks, system disks, and pay-as-you-go cloud disks do not support return.</li>.
        /// </summary>
        [JsonProperty("ReturnFailCode")]
        public long? ReturnFailCode{ get; set; }

        /// <summary>
        /// Whether or not cloud disk is shareable cloud disk.
        /// </summary>
        [JsonProperty("Shareable")]
        public bool? Shareable{ get; set; }

        /// <summary>
        /// Creation time of the cloud disk.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Specifies whether to delete associated non-permanently retained snapshots when destroying the cloud disk. 0 indicates non-permanent snapshots are not deleted with cloud disk destruction, 1 indicates non-permanent snapshots are deleted with cloud disk destruction. default value: 0. whether a snapshot is permanently retained can be determined through the IsPermanent field in the snapshot description returned by the DescribeSnapshots API (https://www.tencentcloud.com/document/product/362/15647?from_cn_redirect=1). true indicates permanent snapshot, false indicates non-permanent snapshot.
        /// </summary>
        [JsonProperty("DeleteSnapshot")]
        public long? DeleteSnapshot{ get; set; }

        /// <summary>
        /// Quota of cloud disk backup points, i.e., the maximum number of backup points that a cloud disk can have.
        /// </summary>
        [JsonProperty("DiskBackupQuota")]
        public ulong? DiskBackupQuota{ get; set; }

        /// <summary>
        /// Number of used cloud disk backups.
        /// </summary>
        [JsonProperty("DiskBackupCount")]
        public ulong? DiskBackupCount{ get; set; }

        /// <summary>
        /// The type of the CBS mounting instance. valid values: <br><li>CVM</li><li>EKS</li>.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// ID of the last instance to which the cloud disk is attached
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LastAttachInsId")]
        public string LastAttachInsId{ get; set; }

        /// <summary>
        /// Error prompt for the last operation on cbs.
        /// </summary>
        [JsonProperty("ErrorPrompt")]
        public string ErrorPrompt{ get; set; }

        /// <summary>
        /// Whether performance burst is enabled for the cloud disk.
        /// </summary>
        [JsonProperty("BurstPerformance")]
        public bool? BurstPerformance{ get; set; }

        /// <summary>
        /// Encryption type of cbs. valid values: ENCRYPT_V1 and ENCRYPT_V2, which indicate first generation and second generation encryption technology respectively. the two kinds are incompatible.
        /// </summary>
        [JsonProperty("EncryptType")]
        public string EncryptType{ get; set; }

        /// <summary>
        /// Key ID of the encrypted disk.
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeleteWithInstance", this.DeleteWithInstance);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskState", this.DiskState);
            this.SetParamSimple(map, prefix + "SnapshotCount", this.SnapshotCount);
            this.SetParamSimple(map, prefix + "AutoRenewFlagError", this.AutoRenewFlagError);
            this.SetParamSimple(map, prefix + "Rollbacking", this.Rollbacking);
            this.SetParamArraySimple(map, prefix + "InstanceIdList.", this.InstanceIdList);
            this.SetParamSimple(map, prefix + "Encrypt", this.Encrypt);
            this.SetParamSimple(map, prefix + "DiskName", this.DiskName);
            this.SetParamSimple(map, prefix + "BackupDisk", this.BackupDisk);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AttachMode", this.AttachMode);
            this.SetParamArraySimple(map, prefix + "AutoSnapshotPolicyIds.", this.AutoSnapshotPolicyIds);
            this.SetParamSimple(map, prefix + "ThroughputPerformance", this.ThroughputPerformance);
            this.SetParamSimple(map, prefix + "Migrating", this.Migrating);
            this.SetParamSimple(map, prefix + "DiskId", this.DiskId);
            this.SetParamSimple(map, prefix + "SnapshotSize", this.SnapshotSize);
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamSimple(map, prefix + "IsReturnable", this.IsReturnable);
            this.SetParamSimple(map, prefix + "DeadlineTime", this.DeadlineTime);
            this.SetParamSimple(map, prefix + "Attached", this.Attached);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "MigratePercent", this.MigratePercent);
            this.SetParamSimple(map, prefix + "DiskUsage", this.DiskUsage);
            this.SetParamSimple(map, prefix + "DiskChargeType", this.DiskChargeType);
            this.SetParamSimple(map, prefix + "Portable", this.Portable);
            this.SetParamSimple(map, prefix + "SnapshotAbility", this.SnapshotAbility);
            this.SetParamSimple(map, prefix + "DeadlineError", this.DeadlineError);
            this.SetParamSimple(map, prefix + "RollbackPercent", this.RollbackPercent);
            this.SetParamSimple(map, prefix + "DifferDaysOfDeadline", this.DifferDaysOfDeadline);
            this.SetParamSimple(map, prefix + "ReturnFailCode", this.ReturnFailCode);
            this.SetParamSimple(map, prefix + "Shareable", this.Shareable);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DeleteSnapshot", this.DeleteSnapshot);
            this.SetParamSimple(map, prefix + "DiskBackupQuota", this.DiskBackupQuota);
            this.SetParamSimple(map, prefix + "DiskBackupCount", this.DiskBackupCount);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "LastAttachInsId", this.LastAttachInsId);
            this.SetParamSimple(map, prefix + "ErrorPrompt", this.ErrorPrompt);
            this.SetParamSimple(map, prefix + "BurstPerformance", this.BurstPerformance);
            this.SetParamSimple(map, prefix + "EncryptType", this.EncryptType);
            this.SetParamSimple(map, prefix + "KmsKeyId", this.KmsKeyId);
        }
    }
}

