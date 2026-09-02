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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupLog : AbstractModel
    {
        
        /// <summary>
        /// Index.
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// Index start time.
        /// </summary>
        [JsonProperty("IndexStartTime")]
        public long? IndexStartTime{ get; set; }

        /// <summary>
        /// Index end time.
        /// </summary>
        [JsonProperty("IndexEndTime")]
        public long? IndexEndTime{ get; set; }

        /// <summary>
        /// Compressed size after backup, in MB.
        /// </summary>
        [JsonProperty("BackupSize")]
        public long? BackupSize{ get; set; }

        /// <summary>
        /// Log status. 0: backup incomplete; 1: backup file; 2: restoration in progress; 3: restored; 4: deleted.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Remaining restore time in minutes. Minutes must be converted by the frontend.
        /// </summary>
        [JsonProperty("RestoreProcessRemindTime")]
        public long? RestoreProcessRemindTime{ get; set; }

        /// <summary>
        /// Time until which restored logs are retained.
        /// </summary>
        [JsonProperty("RestoreRemindTime")]
        public long? RestoreRemindTime{ get; set; }

        /// <summary>
        /// Restoration index size.
        /// </summary>
        [JsonProperty("RestoreIndexSize")]
        public long? RestoreIndexSize{ get; set; }

        /// <summary>
        /// End time of the recovery log execution.
        /// </summary>
        [JsonProperty("RestoreEndTime")]
        public long? RestoreEndTime{ get; set; }

        /// <summary>
        /// appId to which the backup belongs
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// Asset ID to which the backup belongs
        /// </summary>
        [JsonProperty("AssetId")]
        public ulong? AssetId{ get; set; }

        /// <summary>
        /// Account nickname
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// uin of the account to which the asset belongs
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "IndexStartTime", this.IndexStartTime);
            this.SetParamSimple(map, prefix + "IndexEndTime", this.IndexEndTime);
            this.SetParamSimple(map, prefix + "BackupSize", this.BackupSize);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RestoreProcessRemindTime", this.RestoreProcessRemindTime);
            this.SetParamSimple(map, prefix + "RestoreRemindTime", this.RestoreRemindTime);
            this.SetParamSimple(map, prefix + "RestoreIndexSize", this.RestoreIndexSize);
            this.SetParamSimple(map, prefix + "RestoreEndTime", this.RestoreEndTime);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
        }
    }
}

