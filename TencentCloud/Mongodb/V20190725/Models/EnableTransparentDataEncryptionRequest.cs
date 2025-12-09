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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnableTransparentDataEncryptionRequest : AbstractModel
    {
        
        /// <summary>
        /// Instance ID. For example, cmgo-p8vn****. Log in to the[TencentDB for MongoDB console](https://console.cloud.tencent.com/mongodb) to copy the instance ID from the instance list. Currently, the supported general versions include 4.4 and 5.0, and Cloud Disk Edition is not supported.
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        ///  Region where the [Key Management Service (KMS)](https://www.tencentcloud.comom/document/product/573/18809?from_cn_redirect=1) instance is located. For example, ap-shanghai.
        /// </summary>
        [JsonProperty("KmsRegion")]
        public string KmsRegion{ get; set; }

        /// <summary>
        /// Key ID. If the parameter is left unspecified, there is no specific key ID, Tencent Cloud will generate the key automatically.
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "KmsRegion", this.KmsRegion);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
        }
    }
}

