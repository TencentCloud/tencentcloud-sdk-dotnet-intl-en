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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupSummaryItem : AbstractModel
    {
        
        /// <summary>
        /// Instance ID.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Number of automatic data backups of an instance.
        /// </summary>
        [JsonProperty("AutoBackupCount")]
        public long? AutoBackupCount{ get; set; }

        /// <summary>
        /// Capacity of automatic data backups of an instance.
        /// </summary>
        [JsonProperty("AutoBackupVolume")]
        public long? AutoBackupVolume{ get; set; }

        /// <summary>
        /// Number of manual data backups of an instance.
        /// </summary>
        [JsonProperty("ManualBackupCount")]
        public long? ManualBackupCount{ get; set; }

        /// <summary>
        /// Capacity of manual data backups of an instance.
        /// </summary>
        [JsonProperty("ManualBackupVolume")]
        public long? ManualBackupVolume{ get; set; }

        /// <summary>
        /// Total number of data backups of an instance (including automatic backups and manual backups).
        /// </summary>
        [JsonProperty("DataBackupCount")]
        public long? DataBackupCount{ get; set; }

        /// <summary>
        /// Total capacity of data backups of an instance.
        /// </summary>
        [JsonProperty("DataBackupVolume")]
        public long? DataBackupVolume{ get; set; }

        /// <summary>
        /// Number of log backups of an instance.
        /// </summary>
        [JsonProperty("BinlogBackupCount")]
        public long? BinlogBackupCount{ get; set; }

        /// <summary>
        /// Capacity of log backups of an instance.
        /// </summary>
        [JsonProperty("BinlogBackupVolume")]
        public long? BinlogBackupVolume{ get; set; }

        /// <summary>
        /// Total capacity of backups of an instance (including data backups and log backups).
        /// </summary>
        [JsonProperty("BackupVolume")]
        public long? BackupVolume{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "AutoBackupCount", this.AutoBackupCount);
            this.SetParamSimple(map, prefix + "AutoBackupVolume", this.AutoBackupVolume);
            this.SetParamSimple(map, prefix + "ManualBackupCount", this.ManualBackupCount);
            this.SetParamSimple(map, prefix + "ManualBackupVolume", this.ManualBackupVolume);
            this.SetParamSimple(map, prefix + "DataBackupCount", this.DataBackupCount);
            this.SetParamSimple(map, prefix + "DataBackupVolume", this.DataBackupVolume);
            this.SetParamSimple(map, prefix + "BinlogBackupCount", this.BinlogBackupCount);
            this.SetParamSimple(map, prefix + "BinlogBackupVolume", this.BinlogBackupVolume);
            this.SetParamSimple(map, prefix + "BackupVolume", this.BackupVolume);
        }
    }
}

