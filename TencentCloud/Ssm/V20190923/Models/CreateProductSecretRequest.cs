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

    public class CreateProductSecretRequest : AbstractModel
    {
        
        /// <summary>
        /// Credential name, which must be unique in the same region. It can contain 128 bytes of letters, digits, hyphens, and underscores and must begin with a letter or digit.
        /// </summary>
        [JsonProperty("SecretName")]
        public string SecretName{ get; set; }

        /// <summary>
        /// Prefix of the user account name, which is specified by you and can contain up to 8 characters.
        /// Supported character sets include:
        /// Digits: [0, 9].
        /// Lowercase letters: [a, z].
        /// Uppercase letters: [A, Z].
        /// Special symbols: underscore.
        /// The prefix must begin with a letter.
        /// </summary>
        [JsonProperty("UserNamePrefix")]
        public string UserNamePrefix{ get; set; }

        /// <summary>
        /// Name of the Tencent Cloud service bound to the credential, such as `Mysql`. The `DescribeSupportedProducts` API can be used to get the names of the supported Tencent Cloud services.
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// Tencent Cloud service instance ID.
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// Domain name of the account in the form of IP. You can enter `%`.
        /// </summary>
        [JsonProperty("Domains")]
        public string[] Domains{ get; set; }

        /// <summary>
        /// List of permissions that need to be granted when the credential is bound to a Tencent Cloud service.
        /// </summary>
        [JsonProperty("PrivilegesList")]
        public ProductPrivilegeUnit[] PrivilegesList{ get; set; }

        /// <summary>
        /// Description, which is used to describe the purpose in detail and can contain up to 2,048 bytes.
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Specifies the KMS CMK that encrypts the credential.
        /// If this parameter is left empty, the CMK created by Secrets Manager by default will be used for encryption.
        /// You can also specify a custom KMS CMK created in the same region for encryption.
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }

        /// <summary>
        /// List of tags.
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// User-Defined rotation start time in the format of 2006-01-02 15:04:05.
        /// When `EnableRotation` is `True`, this parameter is required.
        /// </summary>
        [JsonProperty("RotationBeginTime")]
        public string RotationBeginTime{ get; set; }

        /// <summary>
        /// Specifies whether to enable rotation
        /// True - enable
        /// False - do not enable
        /// If this parameter is not specified, `False` will be used by default.
        /// </summary>
        [JsonProperty("EnableRotation")]
        public bool? EnableRotation{ get; set; }

        /// <summary>
        /// Rotation frequency in days. Default value: 1 day.
        /// </summary>
        [JsonProperty("RotationFrequency")]
        public long? RotationFrequency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SecretName", this.SecretName);
            this.SetParamSimple(map, prefix + "UserNamePrefix", this.UserNamePrefix);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamArraySimple(map, prefix + "Domains.", this.Domains);
            this.SetParamArrayObj(map, prefix + "PrivilegesList.", this.PrivilegesList);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "KmsKeyId", this.KmsKeyId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "RotationBeginTime", this.RotationBeginTime);
            this.SetParamSimple(map, prefix + "EnableRotation", this.EnableRotation);
            this.SetParamSimple(map, prefix + "RotationFrequency", this.RotationFrequency);
        }
    }
}

