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

    public class SnapshotGroup : AbstractModel
    {
        
        /// <summary>
        /// Specifies the snapshot group ID.
        /// </summary>
        [JsonProperty("SnapshotGroupId")]
        public string SnapshotGroupId{ get; set; }

        /// <summary>
        /// Snapshot group type. NORMAL: common snapshot group, non-consistent snapshot.
        /// </summary>
        [JsonProperty("SnapshotGroupType")]
        public string SnapshotGroupType{ get; set; }

        /// <summary>
        /// Specifies whether the snapshot group contains a system disk snapshot.
        /// </summary>
        [JsonProperty("ContainRootSnapshot")]
        public bool? ContainRootSnapshot{ get; set; }

        /// <summary>
        /// Specifies the snapshot ID list included in the snapshot group.
        /// </summary>
        [JsonProperty("SnapshotIdSet")]
        public string[] SnapshotIdSet{ get; set; }

        /// <summary>
        /// <ul>
        /// <Li>NORMAL: specifies the scaling group is in normal state.</li>.
        /// <Li>CREATING: creating.</li>.
        /// <Li>ROLLBACKING: indicates the rollback is in progress.</li>.
        /// </ul>
        /// </summary>
        [JsonProperty("SnapshotGroupState")]
        public string SnapshotGroupState{ get; set; }

        /// <summary>
        /// Specifies the snapshot group creation progress.
        /// </summary>
        [JsonProperty("Percent")]
        public ulong? Percent{ get; set; }

        /// <summary>
        /// Specifies the snapshot group creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Latest modification time of the snapshot group.
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// Specifies the image list associated with the snapshot group.
        /// </summary>
        [JsonProperty("Images")]
        public Image[] Images{ get; set; }

        /// <summary>
        /// Specifies the snapshot group name.
        /// </summary>
        [JsonProperty("SnapshotGroupName")]
        public string SnapshotGroupName{ get; set; }

        /// <summary>
        /// Number of images associated with the snapshot group.
        /// </summary>
        [JsonProperty("ImageCount")]
        public ulong? ImageCount{ get; set; }

        /// <summary>
        /// Specifies whether the snapshot group has permanent retention.
        /// </summary>
        [JsonProperty("IsPermanent")]
        public bool? IsPermanent{ get; set; }

        /// <summary>
        /// Specifies the snapshot group expiration time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DeadlineTime")]
        public string DeadlineTime{ get; set; }

        /// <summary>
        /// Source automatic snapshot policy ID.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AutoSnapshotPolicyId")]
        public string AutoSnapshotPolicyId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SnapshotGroupId", this.SnapshotGroupId);
            this.SetParamSimple(map, prefix + "SnapshotGroupType", this.SnapshotGroupType);
            this.SetParamSimple(map, prefix + "ContainRootSnapshot", this.ContainRootSnapshot);
            this.SetParamArraySimple(map, prefix + "SnapshotIdSet.", this.SnapshotIdSet);
            this.SetParamSimple(map, prefix + "SnapshotGroupState", this.SnapshotGroupState);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamArrayObj(map, prefix + "Images.", this.Images);
            this.SetParamSimple(map, prefix + "SnapshotGroupName", this.SnapshotGroupName);
            this.SetParamSimple(map, prefix + "ImageCount", this.ImageCount);
            this.SetParamSimple(map, prefix + "IsPermanent", this.IsPermanent);
            this.SetParamSimple(map, prefix + "DeadlineTime", this.DeadlineTime);
            this.SetParamSimple(map, prefix + "AutoSnapshotPolicyId", this.AutoSnapshotPolicyId);
        }
    }
}

