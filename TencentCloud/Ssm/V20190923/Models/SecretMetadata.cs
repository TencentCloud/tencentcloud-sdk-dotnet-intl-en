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

namespace TencentCloud.Ssm.V20190923.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SecretMetadata : AbstractModel
    {
        
        /// <summary>
        /// Credential name
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// Credential description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// KMS `KeyId` used to encrypt the credential
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }

        /// <summary>
        /// Creator UIN
        /// </summary>
        [JsonProperty("CreateUin")]
        public ulong? CreateUin{ get; set; }

        /// <summary>
        /// Credential status: Enabled, Disabled, PendingDelete, Creating, Failed.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Credential deletion date, which takes effect for credentials in `PendingDelete` status and is in UNIX timestamp format
        /// </summary>
        [JsonProperty("DeleteTime")]
        public ulong? DeleteTime{ get; set; }

        /// <summary>
        /// Credential creation time in UNIX timestamp format
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// Type of the KMS CMK used to encrypt the credential. `DEFAULT` represents the default key created by Secrets Manager, and `CUSTOMER` represents the user-specified key
        /// </summary>
        [JsonProperty("KmsKeyType")]
        public string KmsKeyType{ get; set; }

        /// <summary>
        /// 1: enable rotation; 0: disable rotation
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RotationStatus")]
        public long? RotationStatus{ get; set; }

        /// <summary>
        /// Start time of the next rotation in UNIX timestamp format
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("NextRotationTime")]
        public ulong? NextRotationTime{ get; set; }

        /// <summary>
        /// 0: custom secret;1: database credential;2: SSH key secret;3: cloud API key secret;4: Redis secret;Note: This field may return `null`, indicating no valid value can be obtained.
        /// </summary>
        [JsonProperty("SecretType")]
        public long? SecretType{ get; set; }

        /// <summary>
        /// Tencent Cloud service name, which takes effect only when `SecretType` is 1 (Tencent Cloud service credential)
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// Secret name. This field is only valid when the `SecretType` is set to `2` (SSH key secret).
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// Project ID. This field is only valid when the `SecretType` is set to `2` (SSH key secret).
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProjectID")]
        public long? ProjectID{ get; set; }

        /// <summary>
        /// ID of the CVM instance associated with the SSH key. ID. This field is only valid when the `SecretType` is set to `2` (SSH key secret).
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AssociatedInstanceIDs")]
        public string[] AssociatedInstanceIDs{ get; set; }

        /// <summary>
        /// UIN of the Tencent Cloud API key. This field is valid when the secret type is Tencent Cloud API key secret.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TargetUin")]
        public ulong? TargetUin{ get; set; }

        /// <summary>
        /// Rotation frequency in days. It takes effect when the rotation feature is enabled. 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RotationFrequency")]
        public long? RotationFrequency{ get; set; }

        /// <summary>
        /// ID of Tencent Cloud resource corresponding with the Secret. 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResourceID")]
        public string ResourceID{ get; set; }

        /// <summary>
        /// The rotation start time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RotationBeginTime")]
        public string RotationBeginTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecretName", this.SecretName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "KmsKeyId", this.KmsKeyId);
            this.SetParamSimple(map, prefix + "CreateUin", this.CreateUin);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "DeleteTime", this.DeleteTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "KmsKeyType", this.KmsKeyType);
            this.SetParamSimple(map, prefix + "RotationStatus", this.RotationStatus);
            this.SetParamSimple(map, prefix + "NextRotationTime", this.NextRotationTime);
            this.SetParamSimple(map, prefix + "SecretType", this.SecretType);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "ProjectID", this.ProjectID);
            this.SetParamArraySimple(map, prefix + "AssociatedInstanceIDs.", this.AssociatedInstanceIDs);
            this.SetParamSimple(map, prefix + "TargetUin", this.TargetUin);
            this.SetParamSimple(map, prefix + "RotationFrequency", this.RotationFrequency);
            this.SetParamSimple(map, prefix + "ResourceID", this.ResourceID);
            this.SetParamSimple(map, prefix + "RotationBeginTime", this.RotationBeginTime);
        }
    }
}

