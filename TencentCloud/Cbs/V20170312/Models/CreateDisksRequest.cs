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

    public class CreateDisksRequest : AbstractModel
    {
        
        /// <summary>
        /// Location of the instance. You can use this parameter to specify the attributes of the instance, such as its availability zone and project. If no project is specified, the default project will be used.
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// Cloud disk billing mode. POSTPAID_BY_HOUR: Pay-as-you-go by hour<br><li>CDCPAID: Billed together with the bound dedicated cluster<br>For more information on the pricing in each mode, see [Pricing Overview](https://intl.cloud.tencent.com/document/product/362/2413?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("DiskChargeType")]
        public string DiskChargeType{ get; set; }

        /// <summary>
        /// Hard disk media type. valid values:<br><li>CLOUD_PREMIUM: indicates high-performance CLOUD block storage</li><br><li>CLOUD_BSSD: indicates universal type SSD CLOUD disk</li><br><li>CLOUD_SSD: indicates SSD CLOUD disk</li><br><li>CLOUD_HSSD: indicates enhanced SSD CLOUD disk</li><br><li>CLOUD_TSSD: indicates ultra-fast SSD cbs.</li>ultra-fast SSD CBS (CLOUD_TSSD) is only supported when purchased with some instances and not currently supported for separate creation.
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// Cloud disk name. If it is not specified, "Unnamed" will be used by default. The maximum length is 60 bytes.
        /// </summary>
        [JsonProperty("DiskName")]
        public string DiskName{ get; set; }

        /// <summary>
        /// Tags bound to the cloud disk.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// Snapshot ID. If this parameter is specified, the cloud disk will be created based on the snapshot. The snapshot must be a data disk snapshot. To query the type of a snapshot, call the [DescribeSnapshots](https://intl.cloud.tencent.com/document/product/362/15647?from_cn_redirect=1) API and see the `DiskUsage` field in the response.
        /// </summary>
        [JsonProperty("SnapshotId")]
        public string SnapshotId{ get; set; }

        /// <summary>
        /// Number of cloud disks to be created. If it is not specified, `1` will be used by default. There is an upper limit on the maximum number of cloud disks that can be created in a single request. For more information, see [Use Limits](https://intl.cloud.tencent.com/doc/product/362/5145?from_cn_redirect=1).
        /// </summary>
        [JsonProperty("DiskCount")]
        public ulong? DiskCount{ get; set; }

        /// <summary>
        /// Use this parameter to purchase additional performance for CLOUD disk in MB/s.<br>currently, only extreme CBS (CLOUD_TSSD) and enhanced SSD CLOUD disk (CLOUD_HSSD) are supported.
        /// </summary>
        [JsonProperty("ThroughputPerformance")]
        public ulong? ThroughputPerformance{ get; set; }

        /// <summary>
        /// Custom key for purchasing encrypted disks. when this parameter is input, the Encrypt parameter cannot be empty.
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }

        /// <summary>
        /// Cloud disk size in GiB. <li>if `SnapshotId` is input, `DiskSize` can be omitted. at this point, the new cloud disk size will be the snapshot size.</li> <li>if both `SnapshotId` and `DiskSize` are input, the cloud disk size must be greater than or equal to the snapshot size.</li> <li>for the cloud disk size range, please refer to the [product type](https://www.tencentcloud.com/document/product/362/2353?from_cn_redirect=1) of cloud block storage.</li>.
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// When True is entered, the cloud disk will be created as a shared cloud disk. default is False. since shared cloud disk does not support encryption, this parameter cannot be imported simultaneously with the Encrypt parameter.
        /// </summary>
        [JsonProperty("Shareable")]
        public bool? Shareable{ get; set; }

        /// <summary>
        /// A unique string supplied by the client to ensure that the request is idempotent. Its maximum length is 64 ASCII characters. If this parameter is not specified, the idempotency of the request cannot be guaranteed.
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// This parameter is used to create an encrypted cloud disk, with the value fixed as ENCRYPT. since shared cloud disk does not support encryption, this parameter cannot be imported simultaneously with the Shareable parameter.
        /// </summary>
        [JsonProperty("Encrypt")]
        public string Encrypt{ get; set; }

        /// <summary>
        /// Prepaid mode, that is, the settings for the monthly subscription-related parameters. through this parameter, you can specify the purchase duration of the monthly subscribed cloud disk, whether to enable auto-renewal, and other attributes. this parameter is required for creating a prepaid cloud disk, but no need to specify it when creating an hourly postpaid cloud disk.
        /// </summary>
        [JsonProperty("DiskChargePrepaid")]
        public DiskChargePrepaid DiskChargePrepaid{ get; set; }

        /// <summary>
        /// Delete associated non-permanently retained snapshots when destroying the cloud disk. 0 means non-permanent snapshots are not deleted with cloud disk destruction, 1 means non-permanent snapshots are deleted with cloud disk destruction. default value is 0. whether a snapshot is permanently retained can be determined through the IsPermanent field in the snapshot description returned by the [DescribeSnapshots](https://www.tencentcloud.com/document/api/362/15647?from_cn_redirect=1) api. True represents a permanent snapshot, False represents a non-permanent snapshot.
        /// </summary>
        [JsonProperty("DeleteSnapshot")]
        public long? DeleteSnapshot{ get; set; }

        /// <summary>
        /// Specifies auto mount and initialization of the data disk when creating a cloud disk. this parameter cannot be imported simultaneously with the Encrypt parameter because encrypted disks do not support auto mount or initialization.
        /// </summary>
        [JsonProperty("AutoMountConfiguration")]
        public AutoMountConfiguration AutoMountConfiguration{ get; set; }

        /// <summary>
        /// Specifies the cloud disk backup point quota.
        /// </summary>
        [JsonProperty("DiskBackupQuota")]
        public ulong? DiskBackupQuota{ get; set; }

        /// <summary>
        /// Specifies whether to enable burst performance when creating a CLOUD disk. currently only supports extreme cbs (CLOUD_TSSD) and enhanced SSD CLOUD disk (CLOUD_HSSD) with CLOUD disk size greater than or equal to 460GiB.
        /// </summary>
        [JsonProperty("BurstPerformance")]
        public bool? BurstPerformance{ get; set; }

        /// <summary>
        /// Specifies the CBS encryption type. valid values are ENCRYPT_V1 and ENCRYPT_V2, representing first generation and second generation encryption technology respectively. the two encryption technologies are incompatible. it is recommended to prioritize using second generation encryption technology ENCRYPT_V2. first generation encryption is only supported on some outdated models. this parameter is valid only when creating an encrypted cloud disk.
        /// </summary>
        [JsonProperty("EncryptType")]
        public string EncryptType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamSimple(map, prefix + "DiskChargeType", this.DiskChargeType);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskName", this.DiskName);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "SnapshotId", this.SnapshotId);
            this.SetParamSimple(map, prefix + "DiskCount", this.DiskCount);
            this.SetParamSimple(map, prefix + "ThroughputPerformance", this.ThroughputPerformance);
            this.SetParamSimple(map, prefix + "KmsKeyId", this.KmsKeyId);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "Shareable", this.Shareable);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "Encrypt", this.Encrypt);
            this.SetParamObj(map, prefix + "DiskChargePrepaid.", this.DiskChargePrepaid);
            this.SetParamSimple(map, prefix + "DeleteSnapshot", this.DeleteSnapshot);
            this.SetParamObj(map, prefix + "AutoMountConfiguration.", this.AutoMountConfiguration);
            this.SetParamSimple(map, prefix + "DiskBackupQuota", this.DiskBackupQuota);
            this.SetParamSimple(map, prefix + "BurstPerformance", this.BurstPerformance);
            this.SetParamSimple(map, prefix + "EncryptType", this.EncryptType);
        }
    }
}

