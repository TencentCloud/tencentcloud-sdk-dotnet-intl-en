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

    public class BackupPolicyModelOutPut : AbstractModel
    {
        
        /// <summary>
        /// <p>Backup end time</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BackupEndTime")]
        public string BackupEndTime{ get; set; }

        /// <summary>
        /// <p>Backup method</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BackupMethod")]
        public string BackupMethod{ get; set; }

        /// <summary>
        /// <p>Backup start time</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BackupStartTime")]
        public string BackupStartTime{ get; set; }

        /// <summary>
        /// <p>Engine type</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DBType")]
        public string DBType{ get; set; }

        /// <summary>
        /// <p>Engine version</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DBVersion")]
        public string DBVersion{ get; set; }

        /// <summary>
        /// <p>Whether full backup is enabled</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnableFull")]
        public long? EnableFull{ get; set; }

        /// <summary>
        /// <p>Whether to enable log backup</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EnableLog")]
        public long? EnableLog{ get; set; }

        /// <summary>
        /// <p>Expected next backup time</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExpectedNextBackupPeriod")]
        public string ExpectedNextBackupPeriod{ get; set; }

        /// <summary>
        /// <p>Full backup retention time</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("FullRetentionPeriod")]
        public long? FullRetentionPeriod{ get; set; }

        /// <summary>
        /// <p>Policy ID</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// <p>Instance ID.</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Log retention days</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LogRetentionPeriod")]
        public long? LogRetentionPeriod{ get; set; }

        /// <summary>
        /// <p>Days of the week to perform backup</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PeriodTime")]
        public string PeriodTime{ get; set; }

        /// <summary>
        /// <p>Region</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>Backup cycle type 0:Weekly</p>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("PeriodType")]
        public long? PeriodType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackupEndTime", this.BackupEndTime);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "BackupStartTime", this.BackupStartTime);
            this.SetParamSimple(map, prefix + "DBType", this.DBType);
            this.SetParamSimple(map, prefix + "DBVersion", this.DBVersion);
            this.SetParamSimple(map, prefix + "EnableFull", this.EnableFull);
            this.SetParamSimple(map, prefix + "EnableLog", this.EnableLog);
            this.SetParamSimple(map, prefix + "ExpectedNextBackupPeriod", this.ExpectedNextBackupPeriod);
            this.SetParamSimple(map, prefix + "FullRetentionPeriod", this.FullRetentionPeriod);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LogRetentionPeriod", this.LogRetentionPeriod);
            this.SetParamSimple(map, prefix + "PeriodTime", this.PeriodTime);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "PeriodType", this.PeriodType);
        }
    }
}

