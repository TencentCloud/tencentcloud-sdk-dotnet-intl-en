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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PhoneVerificationRequest : AbstractModel
    {
        
        /// <summary>
        /// Identity card number.
        /// </summary>
        [JsonProperty("IdCard")]
        public string IdCard{ get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Mobile number.
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// Users with encryption requirements can import the CiphertextBlob of kms. Read the <a href="https://www.tencentcloud.com/document/product/1007/47180?from_cn_redirect=1">data encryption</a> document about encrypting data.
        /// </summary>
        [JsonProperty("CiphertextBlob")]
        public string CiphertextBlob{ get; set; }

        /// <summary>
        /// When using the encryption service, fill in the field to be encrypted.
        /// -This API can fill in one or more of encrypted IdCard, Name, and Phone.
        /// </summary>
        [JsonProperty("EncryptList")]
        public string[] EncryptList{ get; set; }

        /// <summary>
        /// Users with encryption requirements import the initial vector for CBC encryption.
        /// </summary>
        [JsonProperty("Iv")]
        public string Iv{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdCard", this.IdCard);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "CiphertextBlob", this.CiphertextBlob);
            this.SetParamArraySimple(map, prefix + "EncryptList.", this.EncryptList);
            this.SetParamSimple(map, prefix + "Iv", this.Iv);
        }
    }
}

