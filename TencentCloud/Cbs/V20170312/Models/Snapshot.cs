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

    public class Snapshot : AbstractModel
    {
        
        /// <summary>
        /// Snapshot ID.
        /// </summary>
        [JsonProperty("SnapshotId")]
        public string SnapshotId{ get; set; }

        /// <summary>
        /// Location of the snapshot.
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// The type of the cloud disk used to create the snapshot. Value range: <br><li>SYSTEM_DISK: System disk <br><li>DATA_DISK: Data disk.
        /// </summary>
        [JsonProperty("DiskUsage")]
        public string DiskUsage{ get; set; }

        /// <summary>
        /// ID of the cloud disk used to create this snapshot.
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// Size of the cloud disk used to create this snapshot (in GB).
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// Status of the snapshot. Value range: <br><li>NORMAL: Normal <br><li>CREATING: Creating <br><li>ROLLBACKING: Rolling backing <br><li>COPYING_FROM_REMOTE: Copying snapshot across regions.
        /// </summary>
        [JsonProperty("SnapshotState")]
        public string SnapshotState{ get; set; }

        /// <summary>
        /// Snapshot name, the user-defined snapshot alias. Call [ModifySnapshotAttribute](https://intl.cloud.tencent.com/document/product/362/15650?from_cn_redirect=1) to modify this field.
        /// </summary>
        [JsonProperty("SnapshotName")]
        public string SnapshotName{ get; set; }

        /// <summary>
        /// The progress percentage for snapshot creation. This field is always 100 after the snapshot is created successfully.
        /// </summary>
        [JsonProperty("Percent")]
        public ulong? Percent{ get; set; }

        /// <summary>
        /// Creation time of the snapshot.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// The expiration time of the snapshot. If the snapshot is permanently retained, this field is blank.
        /// </summary>
        [JsonProperty("DeadlineTime")]
        public string DeadlineTime{ get; set; }

        /// <summary>
        /// Whether the snapshot is created from an encrypted disk. Value range: <br><li>true: Yes <br><li>false: No.
        /// </summary>
        [JsonProperty("Encrypt")]
        public bool? Encrypt{ get; set; }

        /// <summary>
        /// Whether it is a permanent snapshot. Value range: <br><li>true: Permanent snapshot <br><li>false: Non-permanent snapshot.
        /// </summary>
        [JsonProperty("IsPermanent")]
        public bool? IsPermanent{ get; set; }

        /// <summary>
        /// The destination region to which the snapshot is being replicated. Default value is [ ].
        /// </summary>
        [JsonProperty("CopyingToRegions")]
        public string[] CopyingToRegions{ get; set; }

        /// <summary>
        /// Whether the snapshot is replicated across regions. Value range: <br><li>true: Indicates that the snapshot is replicated across regions. <br><li>false: Indicates that the snapshot belongs to the local region.
        /// </summary>
        [JsonProperty("CopyFromRemote")]
        public bool? CopyFromRemote{ get; set; }

        /// <summary>
        /// List of images associated with snapshot.
        /// </summary>
        [JsonProperty("Images")]
        public Image[] Images{ get; set; }

        /// <summary>
        /// Number of images associated with snapshot.
        /// </summary>
        [JsonProperty("ImageCount")]
        public ulong? ImageCount{ get; set; }

        /// <summary>
        /// Snapshot type. This value can currently be either PRIVATE_SNAPSHOT or SHARED_SNAPSHOT.
        /// </summary>
        [JsonProperty("SnapshotType")]
        public string SnapshotType{ get; set; }

        /// <summary>
        /// Number of snapshots currently shared
        /// </summary>
        [JsonProperty("ShareReference")]
        public ulong? ShareReference{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SnapshotId", this.SnapshotId);
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamSimple(map, prefix + "DiskUsage", this.DiskUsage);
            this.SetParamSimple(map, prefix + "DiskId", this.DiskId);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "SnapshotState", this.SnapshotState);
            this.SetParamSimple(map, prefix + "SnapshotName", this.SnapshotName);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "DeadlineTime", this.DeadlineTime);
            this.SetParamSimple(map, prefix + "Encrypt", this.Encrypt);
            this.SetParamSimple(map, prefix + "IsPermanent", this.IsPermanent);
            this.SetParamArraySimple(map, prefix + "CopyingToRegions.", this.CopyingToRegions);
            this.SetParamSimple(map, prefix + "CopyFromRemote", this.CopyFromRemote);
            this.SetParamArrayObj(map, prefix + "Images.", this.Images);
            this.SetParamSimple(map, prefix + "ImageCount", this.ImageCount);
            this.SetParamSimple(map, prefix + "SnapshotType", this.SnapshotType);
            this.SetParamSimple(map, prefix + "ShareReference", this.ShareReference);
        }
    }
}

