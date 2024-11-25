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

namespace TencentCloud.Tke.V20220501.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataDisk : AbstractModel
    {
        
        /// <summary>
        /// Cloud disk type
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// File system (ext3/ext4/xfs).
        /// 
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("FileSystem")]
        public string FileSystem{ get; set; }

        /// <summary>
        /// Cloud disk size (GB)
        /// 
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// Whether to automatically format and mount disks.
        /// 
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("AutoFormatAndMount")]
        public bool? AutoFormatAndMount{ get; set; }

        /// <summary>
        /// Mount device name or partition name
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("DiskPartition")]
        public string DiskPartition{ get; set; }

        /// <summary>
        /// Mounting directory
        /// 
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("MountTarget")]
        public string MountTarget{ get; set; }

        /// <summary>
        /// This parameter is used to create an encrypted cloud disk, with the value fixed as ENCRYPT.
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("Encrypt")]
        public string Encrypt{ get; set; }

        /// <summary>
        /// Custom key for purchasing encrypted disks. When this parameter is input, the Encrypt input parameter cannot be left empty.
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }

        /// <summary>
        /// Snapshot ID. If it is input, a cloud disk will be created based on this snapshot. The snapshot must be a data disk snapshot.
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("SnapshotId")]
        public string SnapshotId{ get; set; }

        /// <summary>
        /// Cloud disk performance (unit: MB/s), which can be used to purchase additional performance for cloud disks.
        /// Note: This field may return "null", indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ThroughputPerformance")]
        public ulong? ThroughputPerformance{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "FileSystem", this.FileSystem);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "AutoFormatAndMount", this.AutoFormatAndMount);
            this.SetParamSimple(map, prefix + "DiskPartition", this.DiskPartition);
            this.SetParamSimple(map, prefix + "MountTarget", this.MountTarget);
            this.SetParamSimple(map, prefix + "Encrypt", this.Encrypt);
            this.SetParamSimple(map, prefix + "KmsKeyId", this.KmsKeyId);
            this.SetParamSimple(map, prefix + "SnapshotId", this.SnapshotId);
            this.SetParamSimple(map, prefix + "ThroughputPerformance", this.ThroughputPerformance);
        }
    }
}

