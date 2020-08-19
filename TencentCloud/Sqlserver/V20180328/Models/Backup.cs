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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Backup : AbstractModel
    {
        
        /// <summary>
        /// Filename
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// File size in KB
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// Backup start time
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Backup end time
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Download address for private network
        /// </summary>
        [JsonProperty("InternalAddr")]
        public string InternalAddr{ get; set; }

        /// <summary>
        /// Download address for public network
        /// </summary>
        [JsonProperty("ExternalAddr")]
        public string ExternalAddr{ get; set; }

        /// <summary>
        /// Unique ID of backup file, which will be used by the `RestoreInstance` API
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// Backup file status (0: creating, 1: succeeded, 2: failed)
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// List of databases for multi-database backup
        /// </summary>
        [JsonProperty("DBs")]
        public string[] DBs{ get; set; }

        /// <summary>
        /// Backup policy (0: instance backup, 1: multi-database backup)
        /// </summary>
        [JsonProperty("Strategy")]
        public long? Strategy{ get; set; }

        /// <summary>
        /// Backup mode. 0: scheduled, 1: manual
        /// </summary>
        [JsonProperty("BackupWay")]
        public long? BackupWay{ get; set; }

        /// <summary>
        /// Backup name, which can be customized.
        /// </summary>
        [JsonProperty("BackupName")]
        public string BackupName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "InternalAddr", this.InternalAddr);
            this.SetParamSimple(map, prefix + "ExternalAddr", this.ExternalAddr);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "DBs.", this.DBs);
            this.SetParamSimple(map, prefix + "Strategy", this.Strategy);
            this.SetParamSimple(map, prefix + "BackupWay", this.BackupWay);
            this.SetParamSimple(map, prefix + "BackupName", this.BackupName);
        }
    }
}

