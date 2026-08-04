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
        /// <p>Globally unique ID of the DataKey</p>
        /// </summary>
        [JsonProperty("DataKeyId")]
        public string DataKeyId{ get; set; }

        /// <summary>
        /// <p>Globally unique ID of the CMK.</p>
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// <p>CMK name</p>
        /// </summary>
        [JsonProperty("KeyName")]
        public string KeyName{ get; set; }

        /// <summary>
        /// <p>Data key name that is easier to identify and understand as a key</p>
        /// </summary>
        [JsonProperty("DataKeyName")]
        public string DataKeyName{ get; set; }

        /// <summary>
        /// <p>Length of the data key, in bytes</p>
        /// </summary>
        [JsonProperty("NumberOfBytes")]
        public ulong? NumberOfBytes{ get; set; }

        /// <summary>
        /// <p>Key creation time</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// <p>Description of DataKey</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>DataKey state, value: Enabled | Disabled | PendingDelete</p>
        /// </summary>
        [JsonProperty("KeyState")]
        public string KeyState{ get; set; }

        /// <summary>
        /// <p>Creator.</p>
        /// </summary>
        [JsonProperty("CreatorUin")]
        public ulong? CreatorUin{ get; set; }

        /// <summary>
        /// <p>Creator of the data key. For user-created keys, it is user; for keys automatically created by authorized cloud services, it is the corresponding product name.</p>
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// <p>Schedule deletion time</p>
        /// </summary>
        [JsonProperty("DeletionDate")]
        public ulong? DeletionDate{ get; set; }

        /// <summary>
        /// <p>DataKey key material type. For keys created by KMS: TENCENT_KMS. For keys of user import type: EXTERNAL.</p>
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// <p>HSM Cluster ID (only applicable to KMS exclusive edition/managed version service instances)</p>
        /// </summary>
        [JsonProperty("HsmClusterId")]
        public string HsmClusterId{ get; set; }

        /// <summary>
        /// <p>Resource ID, format: creatorUin/$creatorUin/$dataKeyId</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>Whether the key is a primary replica. 0: primary replica, 1: synced replica.</p>
        /// </summary>
        [JsonProperty("IsSyncReplica")]
        public long? IsSyncReplica{ get; set; }

        /// <summary>
        /// <p>Synchronous original region</p>
        /// </summary>
        [JsonProperty("SourceRegion")]
        public string SourceRegion{ get; set; }

        /// <summary>
        /// <p>Key synchronization status. 0: unsynced, 1: synchronization successful, 2: synchronization failure, 3: syncing.</p>
        /// </summary>
        [JsonProperty("SyncStatus")]
        public long? SyncStatus{ get; set; }

        /// <summary>
        /// <p>Synchronous result description</p>
        /// </summary>
        [JsonProperty("SyncMessages")]
        public string SyncMessages{ get; set; }

        /// <summary>
        /// <p>Start time of synchronization</p>
        /// </summary>
        [JsonProperty("SyncStartTime")]
        public ulong? SyncStartTime{ get; set; }

        /// <summary>
        /// <p>Synchronous end time</p>
        /// </summary>
        [JsonProperty("SyncEndTime")]
        public ulong? SyncEndTime{ get; set; }

        /// <summary>
        /// <p>Synchronous primitive cluster. If empty, it is a public cloud public cluster.</p>
        /// </summary>
        [JsonProperty("SourceHsmClusterId")]
        public string SourceHsmClusterId{ get; set; }

        /// <summary>
        /// <p>Member account appId</p>
        /// </summary>
        [JsonProperty("AccountAppId")]
        public ulong? AccountAppId{ get; set; }

        /// <summary>
        /// <p>member account uin</p>
        /// </summary>
        [JsonProperty("AccountUin")]
        public ulong? AccountUin{ get; set; }

        /// <summary>
        /// <p>Enter the member account name.</p>
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName{ get; set; }

        /// <summary>
        /// <p>Creator UIN</p>
        /// </summary>
        [JsonProperty("CreatorUinString")]
        public string CreatorUinString{ get; set; }


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
            this.SetParamSimple(map, prefix + "AccountAppId", this.AccountAppId);
            this.SetParamSimple(map, prefix + "AccountUin", this.AccountUin);
            this.SetParamSimple(map, prefix + "AccountName", this.AccountName);
            this.SetParamSimple(map, prefix + "CreatorUinString", this.CreatorUinString);
        }
    }
}

