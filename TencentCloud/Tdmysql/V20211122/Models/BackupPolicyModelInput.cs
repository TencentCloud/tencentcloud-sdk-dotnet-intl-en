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

    public class BackupPolicyModelInput : AbstractModel
    {
        
        /// <summary>
        /// <P>Backup end time.</p>.
        /// </summary>
        [JsonProperty("BackupEndTime")]
        public string BackupEndTime{ get; set; }

        /// <summary>
        /// <P>Backup method: physical physical backup, snapshot snapshot backup</p>.
        /// </summary>
        [JsonProperty("BackupMethod")]
        public string BackupMethod{ get; set; }

        /// <summary>
        /// <P>Backup start time</p>.
        /// </summary>
        [JsonProperty("BackupStartTime")]
        public string BackupStartTime{ get; set; }

        /// <summary>
        /// <P>Whether full backup is enabled</p>.
        /// </summary>
        [JsonProperty("EnableFull")]
        public long? EnableFull{ get; set; }

        /// <summary>
        /// <P>Whether to enable log backup</p>.
        /// </summary>
        [JsonProperty("EnableLog")]
        public long? EnableLog{ get; set; }

        /// <summary>
        /// <P>Full backup retention time can currently only be set to 7 days.</p>.
        /// </summary>
        [JsonProperty("FullRetentionPeriod")]
        public long? FullRetentionPeriod{ get; set; }

        /// <summary>
        /// <p>Instance ID.</p>.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <P>Log retention days. currently, can only set retention to 7 days.</p>.
        /// </summary>
        [JsonProperty("LogRetentionPeriod")]
        public long? LogRetentionPeriod{ get; set; }

        /// <summary>
        /// <P>Days of the week to perform backup.</p>.
        /// </summary>
        [JsonProperty("PeriodTime")]
        public string PeriodTime{ get; set; }

        /// <summary>
        /// <p>Storage type: COS, SNAPSHOT</p>valid values: <ul><li> COS: COS storage</li><li> SNAPSHOT: cloud disk SNAPSHOT</li></ul>.
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackupEndTime", this.BackupEndTime);
            this.SetParamSimple(map, prefix + "BackupMethod", this.BackupMethod);
            this.SetParamSimple(map, prefix + "BackupStartTime", this.BackupStartTime);
            this.SetParamSimple(map, prefix + "EnableFull", this.EnableFull);
            this.SetParamSimple(map, prefix + "EnableLog", this.EnableLog);
            this.SetParamSimple(map, prefix + "FullRetentionPeriod", this.FullRetentionPeriod);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LogRetentionPeriod", this.LogRetentionPeriod);
            this.SetParamSimple(map, prefix + "PeriodTime", this.PeriodTime);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
        }
    }
}

