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

    public class Disk : AbstractModel
    {
        
        /// <summary>
        /// Whether the cloud disk terminates along with the instance mounted to it. <br><li>true: Cloud disk will also be terminated when instance terminates, so only hourly postpaid cloud disk are supported.<br><li>false: Cloud disk does not terminate when instance terminates.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("DeleteWithInstance")]
        public bool? DeleteWithInstance{ get; set; }

        /// <summary>
        /// Auto renewal flag. Supported values:<br><li>NOTIFY_AND_AUTO_RENEW: Notify expiry and renew automatically<br><li>NOTIFY_AND_MANUAL_RENEW: Notify expiry but not renew automatically<br><li>DISABLE_NOTIFY_AND_MANUAL_RENEW: Neither notify expiry nor renew automatically.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// Cloud disk types. Valid values: <br><li>CLOUD_BASIC: HDD cloud disk <br><li>CLOUD_PREMIUM: Premium Cloud Disk <br><li>CLOUD_BSSD: General Purpose SSD <br><li>CLOUD_SSD: SSD <br><li>CLOUD_HSSD: Enhanced SSD <br><li>CLOUD_TSSD: Tremendous SSD
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// The state of the cloud disk. Value range: <br><li>UNATTACHED: Not mounted <br><li>ATTACHING: Mounting <br><li>ATTACHED: Mounted <br><li>DETACHING: Un-mounting <br><li>EXPANDING: Expanding <br><li>ROLLBACKING: Rolling back <br><li>TORECYCE: Pending recycling. <br><li>DUMPING: Copying the hard drive.
        /// </summary>
        [JsonProperty("DiskState")]
        public string DiskState{ get; set; }

        /// <summary>
        /// The total number of snapshots of the cloud disk.
        /// </summary>
        [JsonProperty("SnapshotCount")]
        public long? SnapshotCount{ get; set; }

        /// <summary>
        /// Cloud disk already mounted to CVM, and both CVM and cloud disk use monthly subscription.<br><li>true: CVM has auto-renewal flag set up, but cloud disk does not.<br><li>false: Cloud disk auto-renewal flag set up normally.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("AutoRenewFlagError")]
        public bool? AutoRenewFlagError{ get; set; }

        /// <summary>
        /// Whether the cloud disk is in the status of snapshot rollback. Value range: <br><li>false: No <br><li>true: Yes
        /// </summary>
        [JsonProperty("Rollbacking")]
        public bool? Rollbacking{ get; set; }

        /// <summary>
        /// For non-shareable cloud disks, this parameter is null. For shareable cloud disks, this parameters indicates this cloud disk's Instance IDs currently mounted to the CVM.
        /// </summary>
        [JsonProperty("InstanceIdList")]
        public string[] InstanceIdList{ get; set; }

        /// <summary>
        /// Whether the cloud disk is encrypted. Value range: <br><li>false: Not encrypted <br><li>true: Encrypted.
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
        /// The tag bound to the cloud disk. The value Null is used when no tag is bound to the cloud disk.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// ID of the CVM to which the cloud disk is mounted.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Cloud disk mount method. Valid values: <br><li>PF: mount as a PF (Physical Function)<br><li>VF: mount as a VF (Virtual Function)
        /// Note: this field may return `null`, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("AttachMode")]
        public string AttachMode{ get; set; }

        /// <summary>
        /// ID of the periodic snapshot associated to the cloud disk. This parameter is returned only if the value of parameter ReturnBindAutoSnapshotPolicy is TRUE when the API DescribeDisks is called.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyIds")]
        public string[] AutoSnapshotPolicyIds{ get; set; }

        /// <summary>
        /// Extra performance for a cloud disk, in MB/sec.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ThroughputPerformance")]
        public ulong? ThroughputPerformance{ get; set; }

        /// <summary>
        /// Whether cloud disk is in process of type change. Value range: <br><li>false: Cloud disk not in process of type change. <br><li>true: Cloud disk type change has been launched, and migration is in process.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("Migrating")]
        public bool? Migrating{ get; set; }

        /// <summary>
        /// Cloud disk ID.
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// The total capacity of the snapshots of the cloud disk. Unit: MB.
        /// </summary>
        [JsonProperty("SnapshotSize")]
        public ulong? SnapshotSize{ get; set; }

        /// <summary>
        /// Location of the cloud disk.
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// Determines whether or not prepaid cloud disk supports active return. <br><li>true: Active return supported.<br><li>false: Active return not supported.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("IsReturnable")]
        public bool? IsReturnable{ get; set; }

        /// <summary>
        /// Expiration time of the cloud disk.
        /// </summary>
        [JsonProperty("DeadlineTime")]
        public string DeadlineTime{ get; set; }

        /// <summary>
        /// Whether the cloud disk is mounted to the CVM. Value range: <br><li>false: Unmounted <br><li>true: Mounted.
        /// </summary>
        [JsonProperty("Attached")]
        public bool? Attached{ get; set; }

        /// <summary>
        /// Cloud disk size (in GB).
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// Migration progress of cloud disk type change, from 0 to 100.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("MigratePercent")]
        public ulong? MigratePercent{ get; set; }

        /// <summary>
        /// Cloud disk type. Value range:<br><li>SYSTEM_DISK: System disk <br><li>DATA_DISK: Data disk.
        /// </summary>
        [JsonProperty("DiskUsage")]
        public string DiskUsage{ get; set; }

        /// <summary>
        /// Billing method. Value range: <br><li>PREPAID: Prepaid, that is, monthly subscription<br><li>POSTPAID_BY_HOUR: Postpaid, that is, pay as you go.
        /// </summary>
        [JsonProperty("DiskChargeType")]
        public string DiskChargeType{ get; set; }

        /// <summary>
        /// Whether it is an elastic cloud disk. false: Non-elastic cloud disk; true: Elastic cloud disk.
        /// </summary>
        [JsonProperty("Portable")]
        public bool? Portable{ get; set; }

        /// <summary>
        /// Whether the cloud disk has the capability to create snapshots. Value range: <br><li>false: Cannot create snapshots. true: Can create snapshots.
        /// </summary>
        [JsonProperty("SnapshotAbility")]
        public bool? SnapshotAbility{ get; set; }

        /// <summary>
        /// This field is only applicable when the instance is already mounted to the cloud disk, and both the instance and the cloud disk use monthly subscription. <br><li>true: Expiration time of cloud disk is earlier than that of the instance.<br><li>false:Expiration time of cloud disk is later than that of the instance.
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("DeadlineError")]
        public bool? DeadlineError{ get; set; }

        /// <summary>
        /// Rollback progress of a cloud disk snapshot.
        /// </summary>
        [JsonProperty("RollbackPercent")]
        public ulong? RollbackPercent{ get; set; }

        /// <summary>
        /// Number of days from current time until disk expiration (only applicable for prepaid disks).
        /// Note: This field may return null, indicating that no valid value was found.
        /// </summary>
        [JsonProperty("DifferDaysOfDeadline")]
        public long? DifferDaysOfDeadline{ get; set; }

        /// <summary>
        /// In circumstances where the prepaid cloud disk does not support active return, this parameter indicates the reason that return is not supported. Value range: <br><li>1: The cloud disk has already been returned. <br><li>2: The cloud disk has already expired. <br><li>3: The cloud disk does not support return. <br><li> 8: The limit on the number of returns is exceeded.
        /// Note: This field may return null, indicating that no valid value was found.
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
        /// Delete the associated non-permanently reserved snapshots upon deletion of the source cloud disk. `0`: No (default). `1`: Yes. To check whether a snapshot is permanently reserved, refer to the `IsPermanent` field returned by the `DescribeSnapshots` API. 
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
        /// Type of the instance mounted to the cloud disk. Valid values: <br><li>CVM<br><li>EKS
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("LastAttachInsId")]
        public string LastAttachInsId{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ErrorPrompt")]
        public string ErrorPrompt{ get; set; }


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
        }
    }
}

