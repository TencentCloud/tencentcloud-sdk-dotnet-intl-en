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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBackupSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// Actual free total space, in KB.
        /// </summary>
        [JsonProperty("FreeSpace")]
        public ulong? FreeSpace{ get; set; }

        /// <summary>
        /// Actual used space of backups, in KB.
        /// </summary>
        [JsonProperty("ActualUsedSpace")]
        public ulong? ActualUsedSpace{ get; set; }

        /// <summary>
        /// Total number of backup files.
        /// </summary>
        [JsonProperty("BackupFilesTotal")]
        public ulong? BackupFilesTotal{ get; set; }

        /// <summary>
        /// Charged space of the space occupied by backups, in KB.
        /// </summary>
        [JsonProperty("BillingSpace")]
        public ulong? BillingSpace{ get; set; }

        /// <summary>
        /// Data backup usage space, in KB.
        /// </summary>
        [JsonProperty("DataBackupSpace")]
        public ulong? DataBackupSpace{ get; set; }

        /// <summary>
        /// Total number of data backup files.
        /// </summary>
        [JsonProperty("DataBackupCount")]
        public ulong? DataBackupCount{ get; set; }

        /// <summary>
        /// Storage space used by manual backups in data backup, in KB.
        /// </summary>
        [JsonProperty("ManualBackupSpace")]
        public ulong? ManualBackupSpace{ get; set; }

        /// <summary>
        /// Total number of files for manual backups in data backup.
        /// </summary>
        [JsonProperty("ManualBackupCount")]
        public ulong? ManualBackupCount{ get; set; }

        /// <summary>
        /// Storage space used by automatic backups in data backup, in KB.
        /// </summary>
        [JsonProperty("AutoBackupSpace")]
        public ulong? AutoBackupSpace{ get; set; }

        /// <summary>
        /// Total number of files for automatic backups in data backup.
        /// </summary>
        [JsonProperty("AutoBackupCount")]
        public ulong? AutoBackupCount{ get; set; }

        /// <summary>
        /// Backup usage space for logs, in KB.
        /// </summary>
        [JsonProperty("LogBackupSpace")]
        public ulong? LogBackupSpace{ get; set; }

        /// <summary>
        /// Total number of log backup files.
        /// </summary>
        [JsonProperty("LogBackupCount")]
        public ulong? LogBackupCount{ get; set; }

        /// <summary>
        /// Estimated fees, in USD/hour.
        /// </summary>
        [JsonProperty("EstimatedAmount")]
        public float? EstimatedAmount{ get; set; }

        /// <summary>
        /// Total number of local backup files.
        /// </summary>
        [JsonProperty("LocalBackupFilesTotal")]
        public ulong? LocalBackupFilesTotal{ get; set; }

        /// <summary>
        /// Total number of cross-region backup files.
        /// </summary>
        [JsonProperty("CrossBackupFilesTotal")]
        public ulong? CrossBackupFilesTotal{ get; set; }

        /// <summary>
        /// Charged space of the space occupied by cross-region backups, in KB.
        /// </summary>
        [JsonProperty("CrossBillingSpace")]
        public ulong? CrossBillingSpace{ get; set; }

        /// <summary>
        /// Space used by cross-region automatic data backups, in KB.
        /// </summary>
        [JsonProperty("CrossAutoBackupSpace")]
        public ulong? CrossAutoBackupSpace{ get; set; }

        /// <summary>
        /// Total number of files for cross-region automatic data backups.
        /// </summary>
        [JsonProperty("CrossAutoBackupCount")]
        public ulong? CrossAutoBackupCount{ get; set; }

        /// <summary>
        /// Space used by local log backups, in KB.
        /// </summary>
        [JsonProperty("LocalLogBackupSpace")]
        public ulong? LocalLogBackupSpace{ get; set; }

        /// <summary>
        /// Total number of files for local log backups.
        /// </summary>
        [JsonProperty("LocalLogBackupCount")]
        public ulong? LocalLogBackupCount{ get; set; }

        /// <summary>
        /// Space used by cross-region log backups, in KB.
        /// </summary>
        [JsonProperty("CrossLogBackupSpace")]
        public ulong? CrossLogBackupSpace{ get; set; }

        /// <summary>
        /// Total number of files for cross-region log backups.
        /// </summary>
        [JsonProperty("CrossLogBackupCount")]
        public ulong? CrossLogBackupCount{ get; set; }

        /// <summary>
        /// Estimated fees for cross-region backups, in USD/hour.
        /// </summary>
        [JsonProperty("CrossEstimatedAmount")]
        public float? CrossEstimatedAmount{ get; set; }

        /// <summary>
        /// The unique request ID, generated by the server, will be returned for every request (if the request fails to reach the server for other reasons, the request will not obtain a RequestId). RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FreeSpace", this.FreeSpace);
            this.SetParamSimple(map, prefix + "ActualUsedSpace", this.ActualUsedSpace);
            this.SetParamSimple(map, prefix + "BackupFilesTotal", this.BackupFilesTotal);
            this.SetParamSimple(map, prefix + "BillingSpace", this.BillingSpace);
            this.SetParamSimple(map, prefix + "DataBackupSpace", this.DataBackupSpace);
            this.SetParamSimple(map, prefix + "DataBackupCount", this.DataBackupCount);
            this.SetParamSimple(map, prefix + "ManualBackupSpace", this.ManualBackupSpace);
            this.SetParamSimple(map, prefix + "ManualBackupCount", this.ManualBackupCount);
            this.SetParamSimple(map, prefix + "AutoBackupSpace", this.AutoBackupSpace);
            this.SetParamSimple(map, prefix + "AutoBackupCount", this.AutoBackupCount);
            this.SetParamSimple(map, prefix + "LogBackupSpace", this.LogBackupSpace);
            this.SetParamSimple(map, prefix + "LogBackupCount", this.LogBackupCount);
            this.SetParamSimple(map, prefix + "EstimatedAmount", this.EstimatedAmount);
            this.SetParamSimple(map, prefix + "LocalBackupFilesTotal", this.LocalBackupFilesTotal);
            this.SetParamSimple(map, prefix + "CrossBackupFilesTotal", this.CrossBackupFilesTotal);
            this.SetParamSimple(map, prefix + "CrossBillingSpace", this.CrossBillingSpace);
            this.SetParamSimple(map, prefix + "CrossAutoBackupSpace", this.CrossAutoBackupSpace);
            this.SetParamSimple(map, prefix + "CrossAutoBackupCount", this.CrossAutoBackupCount);
            this.SetParamSimple(map, prefix + "LocalLogBackupSpace", this.LocalLogBackupSpace);
            this.SetParamSimple(map, prefix + "LocalLogBackupCount", this.LocalLogBackupCount);
            this.SetParamSimple(map, prefix + "CrossLogBackupSpace", this.CrossLogBackupSpace);
            this.SetParamSimple(map, prefix + "CrossLogBackupCount", this.CrossLogBackupCount);
            this.SetParamSimple(map, prefix + "CrossEstimatedAmount", this.CrossEstimatedAmount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

