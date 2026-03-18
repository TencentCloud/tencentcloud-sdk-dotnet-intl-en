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
        /// Globally unique CMK ID
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// Alias that makes a key more recognizable and understandable
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// Key creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// CMK description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// CMK status. Valid values: Enabled, Disabled, PendingDelete, PendingImport, Archived.
        /// </summary>
        [JsonProperty("KeyState")]
        public string KeyState{ get; set; }

        /// <summary>
        /// CMK purpose. Valid values: `ENCRYPT_DECRYPT`, `ASYMMETRIC_DECRYPT_RSA_2048`, `ASYMMETRIC_DECRYPT_SM2`, `ASYMMETRIC_SIGN_VERIFY_SM2`, `ASYMMETRIC_SIGN_VERIFY_RSA_2048`, and `ASYMMETRIC_SIGN_VERIFY_ECC`.
        /// </summary>
        [JsonProperty("KeyUsage")]
        public string KeyUsage{ get; set; }

        /// <summary>
        /// CMK type. 2: FIPS-compliant; 4: SM-CRYPTO
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// Creator
        /// </summary>
        [JsonProperty("CreatorUin")]
        public ulong? CreatorUin{ get; set; }

        /// <summary>
        /// Whether key rotation is enabled
        /// </summary>
        [JsonProperty("KeyRotationEnabled")]
        public bool? KeyRotationEnabled{ get; set; }

        /// <summary>
        /// CMK creator. The value of this parameter is `user` if the CMK is created by the user, or the corresponding service name if it is created automatically by an authorized Tencent Cloud service.
        /// </summary>
        [JsonProperty("Owner")]
        public string Owner{ get; set; }

        /// <summary>
        /// Time of next rotation if key rotation is enabled
        /// </summary>
        [JsonProperty("NextRotateTime")]
        public ulong? NextRotateTime{ get; set; }

        /// <summary>
        /// The time when scheduled deletion occurs.
        /// </summary>
        [JsonProperty("DeletionDate")]
        public ulong? DeletionDate{ get; set; }

        /// <summary>
        /// CMK key material type. the type created by KMS is TENCENT_KMS. the user-imported type is EXTERNAL.
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// Valid when Origin is EXTERNAL. indicates the validity date of the key material. 0 means no expiration.
        /// </summary>
        [JsonProperty("ValidTo")]
        public ulong? ValidTo{ get; set; }

        /// <summary>
        /// Resource ID in the format of `creatorUin/$creatorUin/$keyId`.
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// HSM cluster ID (valid only for exclusive or managed version KMS service instances).
        /// </summary>
        [JsonProperty("HsmClusterId")]
        public string HsmClusterId{ get; set; }

        /// <summary>
        /// Key rotation period (days).
        /// </summary>
        [JsonProperty("RotateDays")]
        public ulong? RotateDays{ get; set; }

        /// <summary>
        /// Last disorderly rotation time (Unix timestamp).
        /// </summary>
        [JsonProperty("LastRotateTime")]
        public ulong? LastRotateTime{ get; set; }

        /// <summary>
        /// Specifies whether the key is a primary replica. valid values: 0 (primary replica), 1 (synced replica).
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
        /// Describes the synchronous result.
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
        /// Member account appId.
        /// </summary>
        [JsonProperty("AccountAppId")]
        public ulong? AccountAppId{ get; set; }

        /// <summary>
        /// Member account UIN
        /// </summary>
        [JsonProperty("AccountUin")]
        public ulong? AccountUin{ get; set; }

        /// <summary>
        /// Member account name.
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName{ get; set; }


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
        }
    }
}

