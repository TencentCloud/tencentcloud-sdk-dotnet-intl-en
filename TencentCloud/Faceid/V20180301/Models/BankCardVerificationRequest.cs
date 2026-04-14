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

    public class BankCardVerificationRequest : AbstractModel
    {
        
        /// <summary>
        /// ID number for account opening.
        /// -The document type must match the Type parameter, for example: input the ID card number for an identity card.
        /// </summary>
        [JsonProperty("IdCard")]
        public string IdCard{ get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Bank card.
        /// </summary>
        [JsonProperty("BankCard")]
        public string BankCard{ get; set; }

        /// <summary>
        /// Document type.
        /// -Please confirm this document is the document type used when opening an account. Document information not used for account opening is not supported for verification.
        /// -Currently default: 0 ID card. Other document types are not currently supported.
        /// </summary>
        [JsonProperty("CertType")]
        public long? CertType{ get; set; }

        /// <summary>
        /// Sensitive data encryption info.
        /// -Users with encryption requirements for incoming information (name, identity card number, bank card number) can use this parameter. For details, please click the left-side link.
        /// </summary>
        [JsonProperty("Encryption")]
        public Encryption Encryption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdCard", this.IdCard);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "BankCard", this.BankCard);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
            this.SetParamObj(map, prefix + "Encryption.", this.Encryption);
        }
    }
}

