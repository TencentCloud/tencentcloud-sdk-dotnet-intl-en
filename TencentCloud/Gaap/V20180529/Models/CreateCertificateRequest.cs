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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCertificateRequest : AbstractModel
    {
        
        /// <summary>
        /// Certificate type. Where:
        /// `0`: Basic authentication configuration;
        /// `1`: Client CA certificate;
        /// `2`: Server SSL certificate;
        /// `3`: Origin server CA certificate;
        /// `4`: Connection SSL certificate.
        /// </summary>
        [JsonProperty("CertificateType")]
        public long? CertificateType{ get; set; }

        /// <summary>
        /// Certificate content. URL encoding. Where:
        /// If the certificate type is basic authentication, enter username/password pair for this parameter. Format: “username:password”, for example, root:FSGdT. The password is `htpasswd` or `openssl`, for example, openssl passwd -crypt 123456.
        /// When the certificate type is CA/SSL certificate, enter the certificate content for this parameter in the format of ‘pem’.
        /// </summary>
        [JsonProperty("CertificateContent")]
        public string CertificateContent{ get; set; }

        /// <summary>
        /// Certificate name
        /// </summary>
        [JsonProperty("CertificateAlias")]
        public string CertificateAlias{ get; set; }

        /// <summary>
        /// URL-encoded key content. This parameter is required only when the certificate type is SSL certificate. Its format is `PEM`.
        /// </summary>
        [JsonProperty("CertificateKey")]
        public string CertificateKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertificateType", this.CertificateType);
            this.SetParamSimple(map, prefix + "CertificateContent", this.CertificateContent);
            this.SetParamSimple(map, prefix + "CertificateAlias", this.CertificateAlias);
            this.SetParamSimple(map, prefix + "CertificateKey", this.CertificateKey);
        }
    }
}

