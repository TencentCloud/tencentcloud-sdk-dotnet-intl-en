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

    public class BackupDownloadTask : AbstractModel
    {
        
        /// <summary>
        /// Task creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Backup file name.
        /// </summary>
        [JsonProperty("BackupName")]
        public string BackupName{ get; set; }

        /// <summary>
        /// Shard name.
        /// </summary>
        [JsonProperty("ReplicaSetId")]
        public string ReplicaSetId{ get; set; }

        /// <summary>
        /// Backup data size, in bytes.
        /// </summary>
        [JsonProperty("BackupSize")]
        public long? BackupSize{ get; set; }

        /// <summary>
        /// Task status.
        /// - 0: wait for execution.
        /// - 1: downloading.
        /// - 2: download completed.
        /// - 3: download failed.
        /// - 4: wait for retry.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Task progress percentage.
        /// </summary>
        [JsonProperty("Percent")]
        public long? Percent{ get; set; }

        /// <summary>
        /// Duration, in seconds.
        /// </summary>
        [JsonProperty("TimeSpend")]
        public long? TimeSpend{ get; set; }

        /// <summary>
        /// Download link for backup data.
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// Backup method.
        /// - 0: logical backup.
        /// - 1: physical backup.
        /// - 3: snapshot backup.
        /// **Note**:
        /// 1. The General Edition instance supports logical and physical backup. The Cloud Disk Edition instance supports physical and snapshot backup, but does not support logical backup currently.
        /// 2. Physical backup is not supported when storage encryption is enabled for the instance.
        /// </summary>
        [JsonProperty("BackupMethod")]
        public long? BackupMethod{ get; set; }

        /// <summary>
        /// Specified remarks for initiating backup tasks.
        /// </summary>
        [JsonProperty("BackupDesc")]
        public string BackupDesc{ get; set; }

        /// <summary>
        /// Region information.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Bucket information.
        /// </summary>
        [JsonProperty("Bucket")]
        public string Bucket{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "BackupName", this.BackupName);
            this.SetParamSimple(map, prefix + "ReplicaSetId", this.ReplicaSetId);
            this.SetParamSimple(map, prefix + "BackupSize", this.BackupSize);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Percent", this.Percent);
            this.SetParamSimple(map, prefix + "TimeSpend", this.TimeSpend);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "BackupDesc", this.BackupDesc);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Bucket", this.Bucket);
        }
    }
}

