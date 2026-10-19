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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBackupEncryptRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Instance ID. Log in to the Redis console and copy it from the instance list.</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>Whether backup encryption is enabled.</p><p>Default value: false</p>
        /// </summary>
        [JsonProperty("BackupEncrypt")]
        public bool? BackupEncrypt{ get; set; }

        /// <summary>
        /// <p>Encryption key type.</p><p>Enumeration value:</p><ul><li>0: Tencent Cloud hosted (default)</li><li>1: User-customized KMS key</li></ul><p>Default value: 0</p>
        /// </summary>
        [JsonProperty("EncryptKeyType")]
        public long? EncryptKeyType{ get; set; }

        /// <summary>
        /// <p>Key ID of KMS.</p><p>Parameter format: xxxxxxx-xxxx-xxxx-xxxx-xxxxxxx</p>
        /// </summary>
        [JsonProperty("KmsKeyId")]
        public string KmsKeyId{ get; set; }

        /// <summary>
        /// <p>Regional information.</p><p>Parameter format: ap-xxxx</p><p>For reference: <a href="https://www.tencentcloud.com/document/api/573/34406?from_cn_redirect=1#.E5.9C.B0.E5.9F.9F.E5.88.97.E8.A1.A8">Supported region list for KMS</a></p>
        /// </summary>
        [JsonProperty("KmsRegion")]
        public string KmsRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "BackupEncrypt", this.BackupEncrypt);
            this.SetParamSimple(map, prefix + "EncryptKeyType", this.EncryptKeyType);
            this.SetParamSimple(map, prefix + "KmsKeyId", this.KmsKeyId);
            this.SetParamSimple(map, prefix + "KmsRegion", this.KmsRegion);
        }
    }
}

