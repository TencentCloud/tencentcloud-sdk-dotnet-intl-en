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

    public class MigrateTask : AbstractModel
    {
        
        /// <summary>
        /// Migration task ID
        /// </summary>
        [JsonProperty("MigrateId")]
        public ulong? MigrateId{ get; set; }

        /// <summary>
        /// Migration task name
        /// </summary>
        [JsonProperty("MigrateName")]
        public string MigrateName{ get; set; }

        /// <summary>
        /// User ID of migration task
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// Migration task region
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// Migration source type. 1: TencentDB for SQL Server, 2: CVM-based self-created SQL Server database; 3: SQL Server backup restoration, 4: SQL Server backup restoration (in COS mode)
        /// </summary>
        [JsonProperty("SourceType")]
        public long? SourceType{ get; set; }

        /// <summary>
        /// Migration task creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Migration task start time
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Migration task end time
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Migration task status (1: initializing, 4: migrating, 5: migration failed, 6: migration succeeded, 7: suspended, 8: deleted, 9: suspending, 10: completing, 11: suspension failed, 12: completion failed)
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Information
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// Whether migration task has been checked (0: not checked, 1: check succeeded, 2: check failed, 3: checking)
        /// </summary>
        [JsonProperty("CheckFlag")]
        public ulong? CheckFlag{ get; set; }

        /// <summary>
        /// Migration task progress in %
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }

        /// <summary>
        /// Migration task progress details
        /// </summary>
        [JsonProperty("MigrateDetail")]
        public MigrateDetail MigrateDetail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MigrateId", this.MigrateId);
            this.SetParamSimple(map, prefix + "MigrateName", this.MigrateName);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "CheckFlag", this.CheckFlag);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamObj(map, prefix + "MigrateDetail.", this.MigrateDetail);
        }
    }
}

