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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupInfo : AbstractModel
    {
        
        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Backup mode. 0: automatic backup; 1: manual backup
        /// </summary>
        [JsonProperty("BackupType")]
        public ulong? BackupType{ get; set; }

        /// <summary>
        /// Backup name
        /// </summary>
        [JsonProperty("BackupName")]
        public string BackupName{ get; set; }

        /// <summary>
        /// Backup remarks.
        /// </summary>
        [JsonProperty("BackupDesc")]
        public string BackupDesc{ get; set; }

        /// <summary>
        /// Backup file size. Unit: KB.
        /// </summary>
        [JsonProperty("BackupSize")]
        public ulong? BackupSize{ get; set; }

        /// <summary>
        /// Backup start time.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Backup end time.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Backup status. 1: backing up; 2: backed up successful
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Backup method. 0: logical backup; 1: physical backup
        /// </summary>
        [JsonProperty("BackupMethod")]
        public ulong? BackupMethod{ get; set; }

        /// <summary>
        /// Backup record ID.
        /// </summary>
        [JsonProperty("BackId")]
        public long? BackId{ get; set; }

        /// <summary>
        /// Backup deletion time.
        /// </summary>
        [JsonProperty("DeleteTime")]
        public string DeleteTime{ get; set; }

        /// <summary>
        /// Region for cross-region backup.
        /// </summary>
        [JsonProperty("BackupRegion")]
        public string BackupRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "BackupType", this.BackupType);
            this.SetParamSimple(map, prefix + "BackupName", this.BackupName);
            this.SetParamSimple(map, prefix + "BackupDesc", this.BackupDesc);
            this.SetParamSimple(map, prefix + "BackupSize", this.BackupSize);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "BackId", this.BackId);
            this.SetParamSimple(map, prefix + "DeleteTime", this.DeleteTime);
            this.SetParamSimple(map, prefix + "BackupRegion", this.BackupRegion);
        }
    }
}

