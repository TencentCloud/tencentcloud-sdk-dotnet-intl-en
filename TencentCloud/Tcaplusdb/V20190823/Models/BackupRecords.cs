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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupRecords : AbstractModel
    {
        
        /// <summary>
        /// Table group ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// Table name
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// Backup source
        /// </summary>
        [JsonProperty("BackupType")]
        public string BackupType{ get; set; }

        /// <summary>
        /// File tag: TCAPLUS_FULL or OSDATA
        /// </summary>
        [JsonProperty("FileTag")]
        public string FileTag{ get; set; }

        /// <summary>
        /// Number of shards
        /// </summary>
        [JsonProperty("ShardCount")]
        public ulong? ShardCount{ get; set; }

        /// <summary>
        /// Backup batch date
        /// </summary>
        [JsonProperty("BackupBatchTime")]
        public string BackupBatchTime{ get; set; }

        /// <summary>
        /// Total size of backup files
        /// </summary>
        [JsonProperty("BackupFileSize")]
        public ulong? BackupFileSize{ get; set; }

        /// <summary>
        /// Backup success rate
        /// </summary>
        [JsonProperty("BackupSuccRate")]
        public string BackupSuccRate{ get; set; }

        /// <summary>
        /// Backup file expiration time
        /// </summary>
        [JsonProperty("BackupExpireTime")]
        public string BackupExpireTime{ get; set; }

        /// <summary>
        /// Business ID
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "BackupType", this.BackupType);
            this.SetParamSimple(map, prefix + "FileTag", this.FileTag);
            this.SetParamSimple(map, prefix + "ShardCount", this.ShardCount);
            this.SetParamSimple(map, prefix + "BackupBatchTime", this.BackupBatchTime);
            this.SetParamSimple(map, prefix + "BackupFileSize", this.BackupFileSize);
            this.SetParamSimple(map, prefix + "BackupSuccRate", this.BackupSuccRate);
            this.SetParamSimple(map, prefix + "BackupExpireTime", this.BackupExpireTime);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
        }
    }
}

