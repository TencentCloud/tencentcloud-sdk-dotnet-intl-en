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

    public class KeyMetadata : AbstractModel
    {
        
        /// <summary>
        /// <p>Globally unique ID of the CMK.</p>
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// <p>An alias name as a key that is easier to identify and understand</p>
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// <p>Key creation time</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// <p>Description of the CMK.</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>CMK state, value: Enabled | Disabled | PendingDelete | PendingImport | Archived</p>
        /// </summary>
        [JsonProperty("KeyState")]
        public string KeyState{ get; set; }

        /// <summary>
        /// <p>CMK purpose. Value: ENCRYPT_DECRYPT | ASYMMETRIC_DECRYPT_RSA_2048 | ASYMMETRIC_DECRYPT_SM2 | ASYMMETRIC_SIGN_VERIFY_SM2 | ASYMMETRIC_SIGN_VERIFY_RSA_2048 | ASYMMETRIC_SIGN_VERIFY_ECC</p>
        /// </summary>
        [JsonProperty("KeyUsage")]
        public string KeyUsage{ get; set; }

        /// <summary>
        /// <p>CMK type. 2 means compliant with FIPS 140-2 standard. 4 means compliant with national cryptography standards.</p><p>Enumeration value:</p><ul><li>2: Complies with FIPS 140-2 standard</li><li>4: Complies with national cryptography standards</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// <p>Creator.</p>
        /// </summary>
        [JsonProperty("CreatorUin")]
        public ulong? CreatorUin{ get; set; }

        /// <summary>
        /// <p>Is key rotation function enabled?</p>
        /// </summary>
        [JsonProperty("KeyRotationEnabled")]
        public bool? KeyRotationEnabled{ get; set; }

        /// <summary>
        /// <p>Creator of the CMK. For user-created CMKs, the value is user. For CMKs auto-created by authorized Cloud services, the value is the corresponding product name.</p>
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// <p>The time when the next rotation occurs with key rotation enabled</p>
        /// </summary>
        [JsonProperty("NextRotateTime")]
        public ulong? NextRotateTime{ get; set; }

        /// <summary>
        /// <p>The time when schedule deletion</p>
        /// </summary>
        [JsonProperty("DeletionDate")]
        public ulong? DeletionDate{ get; set; }

        /// <summary>
        /// <p>CMK key material type. TENCENT_KMS for those created by KMS, EXTERNAL for user import.</p>
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// <p>Valid when Origin is EXTERNAL. Indicates the expiration date of the key material. 0 means never expire.</p>
        /// </summary>
        [JsonProperty("ValidTo")]
        public ulong? ValidTo{ get; set; }

        /// <summary>
        /// <p>Resource ID, format: creatorUin/$creatorUin/$keyId</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>HSM Cluster ID (only applicable to KMS exclusive/managed service instance)</p>
        /// </summary>
        [JsonProperty("HsmClusterId")]
        public string HsmClusterId{ get; set; }

        /// <summary>
        /// <p>Key rotation cycle (days)</p>
        /// </summary>
        [JsonProperty("RotateDays")]
        public ulong? RotateDays{ get; set; }

        /// <summary>
        /// <p>Last rotation time (Unix timestamp).</p>
        /// </summary>
        [JsonProperty("LastRotateTime")]
        public ulong? LastRotateTime{ get; set; }

        /// <summary>
        /// <p>Whether the key is the primary replica. 0: primary replica, 1: synced replica.</p>
        /// </summary>
        [JsonProperty("IsSyncReplica")]
        public long? IsSyncReplica{ get; set; }

        /// <summary>
        /// <p>Synchronous original region</p>
        /// </summary>
        [JsonProperty("SourceRegion")]
        public string SourceRegion{ get; set; }

        /// <summary>
        /// <p>Key synchronization state: 0: unsynced, 1: synced successfully, 2: synchronization failed, 3: syncing.</p>
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
        /// <p>Synchronous original cluster. If empty, it is a public cloud public cluster.</p>
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
        /// <p>Member account name</p>
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
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "KeyState", this.KeyState);
            this.SetParamSimple(map, prefix + "KeyUsage", this.KeyUsage);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "CreatorUin", this.CreatorUin);
            this.SetParamSimple(map, prefix + "KeyRotationEnabled", this.KeyRotationEnabled);
            this.SetParamSimple(map, prefix + "Owner", this.Owner);
            this.SetParamSimple(map, prefix + "NextRotateTime", this.NextRotateTime);
            this.SetParamSimple(map, prefix + "DeletionDate", this.DeletionDate);
            this.SetParamSimple(map, prefix + "Origin", this.Origin);
            this.SetParamSimple(map, prefix + "ValidTo", this.ValidTo);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "HsmClusterId", this.HsmClusterId);
            this.SetParamSimple(map, prefix + "RotateDays", this.RotateDays);
            this.SetParamSimple(map, prefix + "LastRotateTime", this.LastRotateTime);
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

