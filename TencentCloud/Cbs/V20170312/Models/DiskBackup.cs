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

    public class DiskBackup : AbstractModel
    {
        
        /// <summary>
        /// Cloud disk backup point ID.
        /// </summary>
        [JsonProperty("DiskBackupId")]
        public string DiskBackupId{ get; set; }

        /// <summary>
        /// ID of the cloud disk with which the backup point is associated.
        /// </summary>
        [JsonProperty("DiskId")]
        public string DiskId{ get; set; }

        /// <summary>
        /// Specifies the disk capacity in GiB.
        /// </summary>
        [JsonProperty("DiskSize")]
        public ulong? DiskSize{ get; set; }

        /// <summary>
        /// Cloud disk type. value ranges from...to...<br>.
        /// <Li>SYSTEM_DISK: specifies the system disk.</li>.
        /// <Li>DATA_DISK: specifies the data disk.</li>.
        /// </summary>
        [JsonProperty("DiskUsage")]
        public string DiskUsage{ get; set; }

        /// <summary>
        /// Backup point name.
        /// </summary>
        [JsonProperty("DiskBackupName")]
        public string DiskBackupName{ get; set; }

        /// <summary>
        /// <P>Specifies the status of the cloud disk backup point. valid values:</p>.
        /// <ul>
        /// <Li>NORMAL: specifies the scaling group is in normal state.</li>.
        /// <Li>CREATING: creating.</li>.
        /// <Li>ROLLBACKING: indicates the rollback is in progress.</li>.
        /// </ul>
        /// </summary>
        [JsonProperty("DiskBackupState")]
        public string DiskBackupState{ get; set; }

        /// <summary>
        /// Specifies the creation percentage of the cloud disk backup point.
        /// </summary>
        [JsonProperty("Percent")]
        public ulong? Percent{ get; set; }

        /// <summary>
        /// Creation time of the cloud disk backup point.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Indicates whether the cloud disk is encrypted. valid values:<br><li>false: non-encrypted disk</li><li>true: encrypted disk</li>.
        /// </summary>
        [JsonProperty("Encrypt")]
        public bool? Encrypt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DiskBackupId", this.DiskBackupId);
            this.SetParamSimple(map, prefix + "DiskId", this.DiskId);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "DiskUsage", this.DiskUsage);
            this.SetParamSimple(map, prefix + "DiskBackupName", this.DiskBackupName);
            this.SetParamSimple(map, prefix + "DiskBackupState", this.DiskBackupState);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Encrypt", this.Encrypt);
        }
    }
}

