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

namespace TencentCloud.Kms.V20190118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataKeyMetadata : AbstractModel
    {
        
        /// <summary>
        /// DataKey globally unique id.
        /// </summary>
        [JsonProperty("DataKeyId")]
        public string DataKeyId{ get; set; }

        /// <summary>
        /// Globally unique id of the CMK.
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// CMK name.
        /// </summary>
        [JsonProperty("KeyName")]
        public string KeyName{ get; set; }

        /// <summary>
        /// Key name as a more recognizable and understandable data key.
        /// </summary>
        [JsonProperty("DataKeyName")]
        public string DataKeyName{ get; set; }

        /// <summary>
        /// Specifies the length of the data key in bytes.
        /// </summary>
        [JsonProperty("NumberOfBytes")]
        public ulong? NumberOfBytes{ get; set; }

        /// <summary>
        /// Key key creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// DataKey description.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// DataKey status. valid values: Enabled, Disabled, PendingDelete.
        /// </summary>
        [JsonProperty("KeyState")]
        public string KeyState{ get; set; }

        /// <summary>
        /// Creator.
        /// </summary>
        [JsonProperty("CreatorUin")]
        public ulong? CreatorUin{ get; set; }

        /// <summary>
        /// Specifies the creator of the data key. valid values: user (user-created) or product name (auto-created by authorized cloud services).
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// The time when schedule deletion.
        /// </summary>
        [JsonProperty("DeletionDate")]
        public ulong? DeletionDate{ get; set; }

        /// <summary>
        /// Specifies the key material type of DataKey. valid values: TENCENT_KMS (created by KMS), EXTERNAL (user import).
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// HSM cluster ID (only applicable to KMS exclusive/managed service instance).
        /// </summary>
        [JsonProperty("HsmClusterId")]
        public string HsmClusterId{ get; set; }

        /// <summary>
        /// Resource ID in the format of `creatorUin/$creatorUin/$dataKeyId`.
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// Whether the key is a primary replica. valid values: `0` (primary), `1` (synced replica).
        /// </summary>
        [JsonProperty("IsSyncReplica")]
        public long? IsSyncReplica{ get; set; }

        /// <summary>
        /// Synchronous original region.
        /// </summary>
        [JsonProperty("SourceRegion")]
        public string SourceRegion{ get; set; }

        /// <summary>
        /// The state of key synchronization. valid values: 0 (unsynced), 1 (synchronization successful), 2 (synchronization failed), 3 (synchronizing).
        /// </summary>
        [JsonProperty("SyncStatus")]
        public long? SyncStatus{ get; set; }

        /// <summary>
        /// Sresult description}.
        /// </summary>
        [JsonProperty("SyncMessages")]
        public string SyncMessages{ get; set; }

        /// <summary>
        /// Start time of synchronization.
        /// </summary>
        [JsonProperty("SyncStartTime")]
        public ulong? SyncStartTime{ get; set; }

        /// <summary>
        /// Specifies the synchronous end time.
        /// </summary>
        [JsonProperty("SyncEndTime")]
        public ulong? SyncEndTime{ get; set; }

        /// <summary>
        /// Synchronous original cluster. if empty, it is a public cloud public cluster.
        /// </summary>
        [JsonProperty("SourceHsmClusterId")]
        public string SourceHsmClusterId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataKeyId", this.DataKeyId);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "KeyName", this.KeyName);
            this.SetParamSimple(map, prefix + "DataKeyName", this.DataKeyName);
            this.SetParamSimple(map, prefix + "NumberOfBytes", this.NumberOfBytes);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "KeyState", this.KeyState);
            this.SetParamSimple(map, prefix + "CreatorUin", this.CreatorUin);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
            this.SetParamSimple(map, prefix + "DeletionDate", this.DeletionDate);
            this.SetParamSimple(map, prefix + "Origin", this.Origin);
            this.SetParamSimple(map, prefix + "HsmClusterId", this.HsmClusterId);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "IsSyncReplica", this.IsSyncReplica);
            this.SetParamSimple(map, prefix + "SourceRegion", this.SourceRegion);
            this.SetParamSimple(map, prefix + "SyncStatus", this.SyncStatus);
            this.SetParamSimple(map, prefix + "SyncMessages", this.SyncMessages);
            this.SetParamSimple(map, prefix + "SyncStartTime", this.SyncStartTime);
            this.SetParamSimple(map, prefix + "SyncEndTime", this.SyncEndTime);
            this.SetParamSimple(map, prefix + "SourceHsmClusterId", this.SourceHsmClusterId);
        }
    }
}

