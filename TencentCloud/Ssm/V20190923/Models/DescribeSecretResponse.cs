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

namespace TencentCloud.Ssm.V20190923.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSecretResponse : AbstractModel
    {
        
        /// <summary>
        /// Name of the Secret.
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// Description of the Secret.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// ID of the KMS CMK used for encryption.
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }

        /// <summary>
        /// Creator UIN.
        /// </summary>
        [JsonProperty("CreateUin")]
        public ulong? CreateUin{ get; set; }

        /// <summary>
        /// Credential status: Enabled, Disabled, PendingDelete, Creating, Failed.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Deletion time, formatted as a Unix timestamp. For a Secret that is not in `PendingDelete` status, this value is 0.
        /// </summary>
        [JsonProperty("DeleteTime")]
        public ulong? DeleteTime{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// `0`: user-defined secret; `1`: database credential; `2`: SSH key secret.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SecretType")]
        public long? SecretType{ get; set; }

        /// <summary>
        /// Tencent Cloud service name.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// Tencent Cloud service instance ID.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResourceID")]
        public string ResourceID{ get; set; }

        /// <summary>
        /// Whether to enable rotation. `True`: enable rotation; `False`: disable rotation.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RotationStatus")]
        public bool? RotationStatus{ get; set; }

        /// <summary>
        /// Rotation frequency in days by default.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RotationFrequency")]
        public long? RotationFrequency{ get; set; }

        /// <summary>
        /// Secret name. This field is only valid when the `SecretType` is set to `2` (SSH key secret).
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// Project ID. This field is only valid when the `SecretType` is set to `2` (SSH key secret).
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProjectID")]
        public long? ProjectID{ get; set; }

        /// <summary>
        /// ID of the CVM instance associated with the SSH key. ID. This field is only valid when the `SecretType` is set to `2` (SSH key secret).
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AssociatedInstanceIDs")]
        public string[] AssociatedInstanceIDs{ get; set; }

        /// <summary>
        /// UIN of the Tencent Cloud API key. This field is valid when the secret type is Tencent Cloud API key secret.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TargetUin")]
        public ulong? TargetUin{ get; set; }

        /// <summary>
        /// Additional configuration of the Secret
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AdditionalConfig")]
        public string AdditionalConfig{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


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
            this.SetParamSimple(map, prefix + "SecretType", this.SecretType);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "ResourceID", this.ResourceID);
            this.SetParamSimple(map, prefix + "RotationStatus", this.RotationStatus);
            this.SetParamSimple(map, prefix + "RotationFrequency", this.RotationFrequency);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "ProjectID", this.ProjectID);
            this.SetParamArraySimple(map, prefix + "AssociatedInstanceIDs.", this.AssociatedInstanceIDs);
            this.SetParamSimple(map, prefix + "TargetUin", this.TargetUin);
            this.SetParamSimple(map, prefix + "AdditionalConfig", this.AdditionalConfig);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

