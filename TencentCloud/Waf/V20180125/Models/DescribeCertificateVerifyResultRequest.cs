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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCertificateVerifyResultRequest : AbstractModel
    {
        
        /// <summary>
        /// Domain name
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Certificate type. 0: Do not check international standard certificates; 1: The certificate is a self-owned certificate; 2: The certificate is a managed certificate.
        /// </summary>
        [JsonProperty("CertType")]
        public long? CertType{ get; set; }

        /// <summary>
        /// When CertType is 1, this parameter is required, indicating the self-owned certificate chain
        /// </summary>
        [JsonProperty("Certificate")]
        public string Certificate{ get; set; }

        /// <summary>
        /// When CertType is 2, this parameter must be filled, indicating the certificate ID hosted on Tencent Cloud's SSL platform
        /// </summary>
        [JsonProperty("CertID")]
        public string CertID{ get; set; }

        /// <summary>
        /// When CertType=1, this parameter is required, indicating the private key of the self-owned certificate.
        /// </summary>
        [JsonProperty("PrivateKey")]
        public string PrivateKey{ get; set; }

        /// <summary>
        /// SM certificate type. 0: Do not check SM certificates; 1: The certificate is a self-owned SM certificate; 2: The certificate is a managed SM certificate.
        /// </summary>
        [JsonProperty("GmCertType")]
        public long? GmCertType{ get; set; }

        /// <summary>
        /// When GmCertType is 1, this parameter needs to be set, indicating the certificate chain of the self-owned SM certificate.
        /// </summary>
        [JsonProperty("GmCert")]
        public string GmCert{ get; set; }

        /// <summary>
        /// When GmCertType is 1, this parameter needs to be set, indicating the private key of the self-owned SM certificate.
        /// </summary>
        [JsonProperty("GmPrivateKey")]
        public string GmPrivateKey{ get; set; }

        /// <summary>
        /// When GmCertType is 1, this parameter needs to be set, indicating the encryption certificate of the self-owned SM certificate.
        /// </summary>
        [JsonProperty("GmEncCert")]
        public string GmEncCert{ get; set; }

        /// <summary>
        /// When GmCertType is 1, this parameter needs to be set, indicating the private key of the encryption certificate for the self-owned SM certificate.
        /// </summary>
        [JsonProperty("GmEncPrivateKey")]
        public string GmEncPrivateKey{ get; set; }

        /// <summary>
        /// When GmCertType is 2, this parameter needs to be set, indicating the ID of the certificate managed by the Tencent Cloud SSL platform.
        /// </summary>
        [JsonProperty("GmSSLId")]
        public string GmSSLId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
            this.SetParamSimple(map, prefix + "Certificate", this.Certificate);
            this.SetParamSimple(map, prefix + "CertID", this.CertID);
            this.SetParamSimple(map, prefix + "PrivateKey", this.PrivateKey);
            this.SetParamSimple(map, prefix + "GmCertType", this.GmCertType);
            this.SetParamSimple(map, prefix + "GmCert", this.GmCert);
            this.SetParamSimple(map, prefix + "GmPrivateKey", this.GmPrivateKey);
            this.SetParamSimple(map, prefix + "GmEncCert", this.GmEncCert);
            this.SetParamSimple(map, prefix + "GmEncPrivateKey", this.GmEncPrivateKey);
            this.SetParamSimple(map, prefix + "GmSSLId", this.GmSSLId);
        }
    }
}

