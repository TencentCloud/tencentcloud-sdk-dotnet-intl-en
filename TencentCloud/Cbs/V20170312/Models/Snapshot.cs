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

    public class Snapshot : AbstractModel
    {
        
        /// <summary>
        /// Location of the snapshot.
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// Specifies whether the snapshot is for cross-region replication. value range:.
        /// <ul>
        /// <li>true: indicates a snapshot for cross-region replication.</li>.
        /// <li>false: snapshot of the local region.</li>.
        /// </ul>
        /// </summary>
        [JsonProperty("CopyFromRemote")]
        public bool? CopyFromRemote{ get; set; }

        /// <summary>
        /// Snapshot status. valid values:.
        /// <ul>
        /// <Li>NORMAL: specifies the scaling group is normal.</li>.
        /// <Li>CREATING: creating</li>.
        /// <Li>ROLLBACKING: indicates the rollback is in progress.</li>.
        /// <Li>COPYING_FROM_REMOTE: cross geo-replication in progress.</li>.
        /// <Li>CHECKING_COPIED: copying check in progress.</li>.
        /// <Li>TORECYCLE: to be recycled.</li>.
        /// </ul>
        /// </summary>
        [JsonProperty("SnapshotState")]
        public string SnapshotState{ get; set; }

        /// <summary>
        /// Whether it is a permanent snapshot. valid values:.
        /// <ul>
        /// <li>true: permanent snapshot.</li>.
        /// <li>false: non-permanent snapshot.</li>.
        /// </ul>
        /// </summary>
        [JsonProperty("IsPermanent")]
        public bool? IsPermanent{ get; set; }

        /// <summary>
        /// Snapshot name, the user-defined snapshot alias. Call [ModifySnapshotAttribute](https://intl.cloud.tencent.com/document/product/362/15650?from_cn_redirect=1) to modify this field.
        /// </summary>
        [JsonProperty("SnapshotName")]
        public string SnapshotName{ get; set; }

        /// <summary>
        /// The expiration time of the snapshot. If the snapshot is permanently retained, this field is blank.
        /// </summary>
        [JsonProperty("DeadlineTime")]
        public string DeadlineTime{ get; set; }

        /// <summary>
        /// The progress percentage for snapshot creation. This field is always 100 after the snapshot is created successfully.
        /// </summary>
        [JsonProperty("Percent")]
        public ulong? Percent{ get; set; }

        /// <summary>
        /// List of images associated with snapshot.
        /// </summary>
        [JsonProperty("Images")]
        public Image[] Images{ get; set; }

        /// <summary>
        /// Number of snapshots currently shared
        /// </summary>
        [JsonProperty("ShareReference")]
        public ulong? ShareReference{ get; set; }

        /// <summary>
        /// Specifies the SNAPSHOT type. valid values: `PRIVATE_SNAPSHOT` (PRIVATE SNAPSHOT) or `SHARED_SNAPSHOT` (SHARED SNAPSHOT).
        /// </summary>
        [JsonProperty("SnapshotType")]
        public string SnapshotType{ get; set; }

        /// <summary>
        /// Specifies the disk capacity of the CBS for creating this snapshot, in GiB.
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// ID of the cloud disk used to create this snapshot.
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// Destination region of the snapshot currently under cross region replication. if not, return `[]`.
        /// </summary>
        [JsonProperty("CopyingToRegions")]
        public string[] CopyingToRegions{ get; set; }

        /// <summary>
        /// Indicates whether the snapshot is created for an encrypted disk. valid values:.
        /// <ul>
        /// <li>true: specifies the snapshot is created by encrypted disks.</li>.
        /// <li>false: snapshot created for non-encrypted disk.</li>.
        /// </ul>
        /// </summary>
        [JsonProperty("Encrypt")]
        public bool? Encrypt{ get; set; }

        /// <summary>
        /// Creation time of the snapshot.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Number of images associated with snapshot.
        /// </summary>
        [JsonProperty("ImageCount")]
        public ulong? ImageCount{ get; set; }

        /// <summary>
        /// Specifies the cloud disk type of the CBS for creating this snapshot. valid values:.
        /// <ul>
        /// <Li>SYSTEM_DISK: system disk</li>.
        /// <Li>DATA_DISK: specifies the data disk.</li>.
        /// </ul>
        /// </summary>
        [JsonProperty("DiskUsage")]
        public string DiskUsage{ get; set; }

        /// <summary>
        /// Snapshot ID.
        /// </summary>
        [JsonProperty("SnapshotId")]
        public string SnapshotId{ get; set; }

        /// <summary>
        /// The time when the snapshot sharing starts
        /// </summary>
        [JsonProperty("TimeStartShare")]
        public string TimeStartShare{ get; set; }

        /// <summary>
        /// List of tags associated with the snapshot.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamSimple(map, prefix + "CopyFromRemote", this.CopyFromRemote);
            this.SetParamSimple(map, prefix + "SnapshotState", this.SnapshotState);
            this.SetParamSimple(map, prefix + "IsPermanent", this.IsPermanent);
            this.SetParamSimple(map, prefix + "SnapshotName", this.SnapshotName);
            this.SetParamSimple(map, prefix + "DeadlineTime", this.DeadlineTime);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamArrayObj(map, prefix + "Images.", this.Images);
            this.SetParamSimple(map, prefix + "ShareReference", this.ShareReference);
            this.SetParamSimple(map, prefix + "SnapshotType", this.SnapshotType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "DiskId", this.DiskId);
            this.SetParamArraySimple(map, prefix + "CopyingToRegions.", this.CopyingToRegions);
            this.SetParamSimple(map, prefix + "Encrypt", this.Encrypt);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ImageCount", this.ImageCount);
            this.SetParamSimple(map, prefix + "DiskUsage", this.DiskUsage);
            this.SetParamSimple(map, prefix + "SnapshotId", this.SnapshotId);
            this.SetParamSimple(map, prefix + "TimeStartShare", this.TimeStartShare);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

