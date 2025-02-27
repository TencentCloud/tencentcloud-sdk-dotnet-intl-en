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

    public class CertificateExtra : AbstractModel
    {
        
        /// <summary>
        /// Quantity of configurable domain names for the certificate.
        /// </summary>
        [JsonProperty("DomainNumber")]
        public string DomainNumber{ get; set; }

        /// <summary>
        /// Renew the original certificate id.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OriginCertificateId")]
        public string OriginCertificateId{ get; set; }

        /// <summary>
        /// Original ID of the new certificate
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReplacedBy")]
        public string ReplacedBy{ get; set; }

        /// <summary>
        /// Reissue certificate id.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReplacedFor")]
        public string ReplacedFor{ get; set; }

        /// <summary>
        /// Renewal certificate id.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RenewOrder")]
        public string RenewOrder{ get; set; }

        /// <summary>
        /// Whether it is a China SM certificate.
        /// </summary>
        [JsonProperty("SMCert")]
        public long? SMCert{ get; set; }

        /// <summary>
        /// Company type, valid values: 1 (individual); 2 (company).
        /// </summary>
        [JsonProperty("CompanyType")]
        public long? CompanyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DomainNumber", this.DomainNumber);
            this.SetParamSimple(map, prefix + "OriginCertificateId", this.OriginCertificateId);
            this.SetParamSimple(map, prefix + "ReplacedBy", this.ReplacedBy);
            this.SetParamSimple(map, prefix + "ReplacedFor", this.ReplacedFor);
            this.SetParamSimple(map, prefix + "RenewOrder", this.RenewOrder);
            this.SetParamSimple(map, prefix + "SMCert", this.SMCert);
            this.SetParamSimple(map, prefix + "CompanyType", this.CompanyType);
        }
    }
}

