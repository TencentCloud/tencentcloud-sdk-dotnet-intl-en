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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReplaceCertificateRequest : AbstractModel
    {
        
        /// <summary>
        /// Certificate ID
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// Validation type. `DNS_AUTO`: automatic DNS validation; `DNS`: manual DNS validation; `FILE`: file validation
        /// </summary>
        [JsonProperty("ValidType")]
        public string ValidType{ get; set; }

        /// <summary>
        /// Type. `Original`: original certificate CSR; `Upload`: uploaded manually; `Online`: generated online. The default value is original.
        /// </summary>
        [JsonProperty("CsrType")]
        public string CsrType{ get; set; }

        /// <summary>
        /// CSR content, required when uploading manually.
        /// </summary>
        [JsonProperty("CsrContent")]
        public string CsrContent{ get; set; }

        /// <summary>
        /// Password of the key
        /// </summary>
        [JsonProperty("CsrkeyPassword")]
        public string CsrkeyPassword{ get; set; }

        /// <summary>
        /// Reissue reason
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// The CSR encryption algorithm. Valid values: `RSA` (default), `ECC1`, and `SM2`.
        /// This parameter is available for selection only when the value of `CsrType` is `Online`.
        /// </summary>
        [JsonProperty("CertCSREncryptAlgo")]
        public string CertCSREncryptAlgo{ get; set; }

        /// <summary>
        /// The CSR encryption parameters. When `CsrEncryptAlgo` is set to `RSA`, `2048` (default) and `4096` are available for selection; and when`CsrEncryptAlgo` is set to `ECC`, `prime256v1` (default) and `secp384r1` are available for selection. 
        /// </summary>
        [JsonProperty("CertCSRKeyParameter")]
        public string CertCSRKeyParameter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamSimple(map, prefix + "ValidType", this.ValidType);
            this.SetParamSimple(map, prefix + "CsrType", this.CsrType);
            this.SetParamSimple(map, prefix + "CsrContent", this.CsrContent);
            this.SetParamSimple(map, prefix + "CsrkeyPassword", this.CsrkeyPassword);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "CertCSREncryptAlgo", this.CertCSREncryptAlgo);
            this.SetParamSimple(map, prefix + "CertCSRKeyParameter", this.CertCSRKeyParameter);
        }
    }
}

