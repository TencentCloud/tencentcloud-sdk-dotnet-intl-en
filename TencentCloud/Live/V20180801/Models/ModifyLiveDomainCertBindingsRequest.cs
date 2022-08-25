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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyLiveDomainCertBindingsRequest : AbstractModel
    {
        
        /// <summary>
        /// The playback domains to bind and whether to enable HTTPS for them.
        /// If neither `CloudCertId` nor the public/private key is specified, and a domain is already bound with a certificate, this API will only update the HTTPS configuration of the domain and, if the certificate is a self-owned certificate, upload it to Tencent Cloud.
        /// </summary>
        [JsonProperty("DomainInfos")]
        public LiveCertDomainInfo[] DomainInfos{ get; set; }

        /// <summary>
        /// The SSL certificate ID assigned by Tencent Cloud.
        /// For details, see https://intl.cloud.tencent.com/document/api/400/41665?from_cn_redirect=1
        /// </summary>
        [JsonProperty("CloudCertId")]
        public string CloudCertId{ get; set; }

        /// <summary>
        /// The public key of the certificate.
        /// You can specify either `CloudCertId` or the public/private key. If both are specified, the private and public key parameters will be ignored. If you pass in only the public and private keys, the corresponding certificate will be uploaded to Tencent Cloud SSL Certificate Service, which will generate a `CloudCertId` for the certificate.
        /// </summary>
        [JsonProperty("CertificatePublicKey")]
        public string CertificatePublicKey{ get; set; }

        /// <summary>
        /// The private key of the certificate.
        /// You can specify either `CloudCertId` or the public/private key. If both are specified, the private and public key parameters will be ignored. If you pass in only the public and private keys, the corresponding certificate will be uploaded to Tencent Cloud SSL Certificate Service, which will generate a `CloudCertId` for the certificate.
        /// </summary>
        [JsonProperty("CertificatePrivateKey")]
        public string CertificatePrivateKey{ get; set; }

        /// <summary>
        /// The remarks for the certificate in Tencent Cloud SSL Certificate Service. This parameter will be ignored if `CloudCertId` is specified.
        /// </summary>
        [JsonProperty("CertificateAlias")]
        public string CertificateAlias{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "DomainInfos.", this.DomainInfos);
            this.SetParamSimple(map, prefix + "CloudCertId", this.CloudCertId);
            this.SetParamSimple(map, prefix + "CertificatePublicKey", this.CertificatePublicKey);
            this.SetParamSimple(map, prefix + "CertificatePrivateKey", this.CertificatePrivateKey);
            this.SetParamSimple(map, prefix + "CertificateAlias", this.CertificateAlias);
        }
    }
}

