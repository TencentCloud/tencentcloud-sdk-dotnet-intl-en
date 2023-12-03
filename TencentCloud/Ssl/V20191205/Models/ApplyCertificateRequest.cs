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

    public class ApplyCertificateRequest : AbstractModel
    {
        
        /// <summary>
        /// Validation type. `DNS_AUTO`: automatic DNS validation; `DNS`: manual DNS validation; `FILE`: file validation
        /// </summary>
        [JsonProperty("DvAuthMethod")]
        public string DvAuthMethod{ get; set; }

        /// <summary>
        /// Domain name
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// Certificate type. Currently, the only supported value is 2, which indicates TrustAsia TLS RSA CA.
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// Email address
        /// </summary>
        [JsonProperty("ContactEmail")]
        public string ContactEmail{ get; set; }

        /// <summary>
        /// Mobile number
        /// </summary>
        [JsonProperty("ContactPhone")]
        public string ContactPhone{ get; set; }

        /// <summary>
        /// Validity period. The default value is 12 months, which is the only supported value currently.
        /// </summary>
        [JsonProperty("ValidityPeriod")]
        public string ValidityPeriod{ get; set; }

        /// <summary>
        /// Encryption algorithm. RSA and ECC are supported.
        /// </summary>
        [JsonProperty("CsrEncryptAlgo")]
        public string CsrEncryptAlgo{ get; set; }

        /// <summary>
        /// Key pair parameters. RSA supports only 2048. ECC supports only prime256v1. When the encryption algorithm is set to ECC, this parameter is mandatory.
        /// </summary>
        [JsonProperty("CsrKeyParameter")]
        public string CsrKeyParameter{ get; set; }

        /// <summary>
        /// CSR encryption password
        /// </summary>
        [JsonProperty("CsrKeyPassword")]
        public string CsrKeyPassword{ get; set; }

        /// <summary>
        /// Alias
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// Original certificate ID, which is used to apply for a new certificate.
        /// </summary>
        [JsonProperty("OldCertificateId")]
        public string OldCertificateId{ get; set; }

        /// <summary>
        /// Benefit package ID, which is used to expand the free certificate package
        /// </summary>
        [JsonProperty("PackageId")]
        public string PackageId{ get; set; }

        /// <summary>
        /// Whether to delete the automatic domain name verification record after issuance, which is no by default. This parameter can be passed in only for domain names of the DNS_AUTO verification type.
        /// </summary>
        [JsonProperty("DeleteDnsAutoRecord")]
        public bool? DeleteDnsAutoRecord{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DvAuthMethod", this.DvAuthMethod);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "ContactEmail", this.ContactEmail);
            this.SetParamSimple(map, prefix + "ContactPhone", this.ContactPhone);
            this.SetParamSimple(map, prefix + "ValidityPeriod", this.ValidityPeriod);
            this.SetParamSimple(map, prefix + "CsrEncryptAlgo", this.CsrEncryptAlgo);
            this.SetParamSimple(map, prefix + "CsrKeyParameter", this.CsrKeyParameter);
            this.SetParamSimple(map, prefix + "CsrKeyPassword", this.CsrKeyPassword);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "OldCertificateId", this.OldCertificateId);
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamSimple(map, prefix + "DeleteDnsAutoRecord", this.DeleteDnsAutoRecord);
        }
    }
}

