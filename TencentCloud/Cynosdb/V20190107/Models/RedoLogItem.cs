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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RedoLogItem : AbstractModel
    {
        
        /// <summary>
        /// Filename.
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// File size
        /// </summary>
        [JsonProperty("FileSize")]
        public long? FileSize{ get; set; }

        /// <summary>
        /// Backup time
        /// </summary>
        [JsonProperty("BackupTime")]
        public string BackupTime{ get; set; }

        /// <summary>
        /// redoLogId
        /// </summary>
        [JsonProperty("RedoLogId")]
        public long? RedoLogId{ get; set; }

        /// <summary>
        /// Cross-Region information.
        /// </summary>
        [JsonProperty("RedoCrossRegions")]
        public BackupRegionAndIds[] RedoCrossRegions{ get; set; }

        /// <summary>
        /// Status.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Start time.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Completion time.
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// Safe info
        /// </summary>
        [JsonProperty("VaultInfos")]
        public VaultInfo[] VaultInfos{ get; set; }

        /// <summary>
        /// Backup delivery status
        /// </summary>
        [JsonProperty("CopyStatus")]
        public string CopyStatus{ get; set; }

        /// <summary>
        /// Encryption key
        /// </summary>
        [JsonProperty("EncryptKeyId")]
        public string EncryptKeyId{ get; set; }

        /// <summary>
        /// Key region for encryption
        /// </summary>
        [JsonProperty("EncryptRegion")]
        public string EncryptRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "BackupTime", this.BackupTime);
            this.SetParamSimple(map, prefix + "RedoLogId", this.RedoLogId);
            this.SetParamArrayObj(map, prefix + "RedoCrossRegions.", this.RedoCrossRegions);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
            this.SetParamArrayObj(map, prefix + "VaultInfos.", this.VaultInfos);
            this.SetParamSimple(map, prefix + "CopyStatus", this.CopyStatus);
            this.SetParamSimple(map, prefix + "EncryptKeyId", this.EncryptKeyId);
            this.SetParamSimple(map, prefix + "EncryptRegion", this.EncryptRegion);
        }
    }
}

