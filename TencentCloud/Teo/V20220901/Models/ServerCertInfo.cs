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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServerCertInfo : AbstractModel
    {
        
        /// <summary>
        /// Specifies the server certificate ID, which originates from the SSL side. you can check the CertId from the [SSL certificate list](https://console.cloud.tencent.com/SSL).
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// Certificate remark name.
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// Certificate type. valid values:.
        /// <Li>Specifies the default certificate.</li>.
        /// <Li>Upload: user upload;</li>.
        /// <li>managed: tencent cloud hosted.</li>.
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Certificate expiration time.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Specifies the cert deployment time.
        /// </summary>
        [JsonProperty("DeployTime")]
        public string DeployTime{ get; set; }

        /// <summary>
        /// Signature algorithm.
        /// </summary>
        [JsonProperty("SignAlgo")]
        public string SignAlgo{ get; set; }

        /// <summary>
        /// Domain name of the certificate.
        /// </summary>
        [JsonProperty("CommonName")]
        public string CommonName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "DeployTime", this.DeployTime);
            this.SetParamSimple(map, prefix + "SignAlgo", this.SignAlgo);
            this.SetParamSimple(map, prefix + "CommonName", this.CommonName);
        }
    }
}

