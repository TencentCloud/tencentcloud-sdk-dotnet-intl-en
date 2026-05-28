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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataBackupStatisticsModel : AbstractModel
    {
        
        /// <summary>
        /// Auto-backup count
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AutoBackupCount")]
        public long? AutoBackupCount{ get; set; }

        /// <summary>
        /// Auto-backup size, in Byte
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AutoBackupSize")]
        public long? AutoBackupSize{ get; set; }

        /// <summary>
        /// Avg backup size per each, in Byte
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AverageSizePerBackup")]
        public long? AverageSizePerBackup{ get; set; }

        /// <summary>
        /// Avg daily backup size, Byte
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AverageSizePerDay")]
        public long? AverageSizePerDay{ get; set; }

        /// <summary>
        /// Manual backup count
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ManualBackupCount")]
        public long? ManualBackupCount{ get; set; }

        /// <summary>
        /// Manual backup size, in Byte
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ManualBackupSize")]
        public long? ManualBackupSize{ get; set; }

        /// <summary>
        /// Number of data backups
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// Data backup size, in Byte
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TotalSize")]
        public long? TotalSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AutoBackupCount", this.AutoBackupCount);
            this.SetParamSimple(map, prefix + "AutoBackupSize", this.AutoBackupSize);
            this.SetParamSimple(map, prefix + "AverageSizePerBackup", this.AverageSizePerBackup);
            this.SetParamSimple(map, prefix + "AverageSizePerDay", this.AverageSizePerDay);
            this.SetParamSimple(map, prefix + "ManualBackupCount", this.ManualBackupCount);
            this.SetParamSimple(map, prefix + "ManualBackupSize", this.ManualBackupSize);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "TotalSize", this.TotalSize);
        }
    }
}

