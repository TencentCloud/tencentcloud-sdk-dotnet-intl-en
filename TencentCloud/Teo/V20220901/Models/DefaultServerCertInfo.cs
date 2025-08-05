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

    public class DefaultServerCertInfo : AbstractModel
    {
        
        /// <summary>
        /// Specifies the server certificate ID.
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
        /// <li>`default`: Default certificate;</li>
        /// 
        /// <li>`upload`: External certificate;</li>
        /// 
        /// <li>`managed`: Tencent Cloud managed certificate.</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Certificate expiration time.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Certificate Validation Time.
        /// </summary>
        [JsonProperty("EffectiveTime")]
        public string EffectiveTime{ get; set; }

        /// <summary>
        /// Common name of the cert.
        /// </summary>
        [JsonProperty("CommonName")]
        public string CommonName{ get; set; }

        /// <summary>
        /// Specifies the SAN domain of the certificate.
        /// </summary>
        [JsonProperty("SubjectAltName")]
        public string[] SubjectAltName{ get; set; }

        /// <summary>
        /// Deployment state. valid values:.
        /// <li>processing: deployment in progress;</li>.
        /// <Li>Deployed: deployed</li>.
        /// <Li>`Failed`: deployment failed</li>.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Indicates the failure reason when the Status is failed.
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// Certificate algorithm.
        /// </summary>
        [JsonProperty("SignAlgo")]
        public string SignAlgo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "EffectiveTime", this.EffectiveTime);
            this.SetParamSimple(map, prefix + "CommonName", this.CommonName);
            this.SetParamArraySimple(map, prefix + "SubjectAltName.", this.SubjectAltName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "SignAlgo", this.SignAlgo);
        }
    }
}

