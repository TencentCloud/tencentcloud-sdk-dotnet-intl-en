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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CertificateInput : AbstractModel
    {
        
        /// <summary>
        /// Authentication type. UNIDIRECTIONAL: one-way authentication; MUTUAL: mutual authentication.
        /// Default value: UNIDIRECTIONAL.
        /// </summary>
        [JsonProperty("SSLMode")]
        public string SSLMode{ get; set; }

        /// <summary>
        /// Whether to enable client authentication for mutual authentication. ON: enable it; OPTIONAL: client certificate not required. Default value: ON.
        /// </summary>
        [JsonProperty("SSLVerifyClient")]
        public string SSLVerifyClient{ get; set; }

        /// <summary>
        /// Server certificate ID. If this parameter is not specified, you need to upload a certificate and specify CertContent (server certificate content), CertKey (server certificate key), and CertName (server certificate name).
        /// </summary>
        [JsonProperty("CertId")]
        public string CertId{ get; set; }

        /// <summary>
        /// ID of a client certificate. When the listener adopts mutual authentication (i.e., SSLMode = mutual), if you leave this parameter empty, you must upload the client certificate, including CertCaContent and CertCaName.
        /// </summary>
        [JsonProperty("CertCaId")]
        public string CertCaId{ get; set; }

        /// <summary>
        /// Name of the uploaded server certificate. If there is no CertId, this parameter is required.
        /// </summary>
        [JsonProperty("CertName")]
        public string CertName{ get; set; }

        /// <summary>
        /// Key of the uploaded server certificate. If there is no CertId, this parameter is required.
        /// </summary>
        [JsonProperty("CertKey")]
        public string CertKey{ get; set; }

        /// <summary>
        /// Content of the uploaded server certificate. If there is no CertId, this parameter is required.
        /// </summary>
        [JsonProperty("CertContent")]
        public string CertContent{ get; set; }

        /// <summary>
        /// Upload client CA certificate name. if SSLMode=MUTUAL and there is no CertCaId, this parameter is required.
        /// </summary>
        [JsonProperty("CertCaName")]
        public string CertCaName{ get; set; }

        /// <summary>
        /// Upload client certificate content. if SSLMode is MUTUAL and there is no CertCaId, this parameter is required.
        /// </summary>
        [JsonProperty("CertCaContent")]
        public string CertCaContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SSLMode", this.SSLMode);
            this.SetParamSimple(map, prefix + "SSLVerifyClient", this.SSLVerifyClient);
            this.SetParamSimple(map, prefix + "CertId", this.CertId);
            this.SetParamSimple(map, prefix + "CertCaId", this.CertCaId);
            this.SetParamSimple(map, prefix + "CertName", this.CertName);
            this.SetParamSimple(map, prefix + "CertKey", this.CertKey);
            this.SetParamSimple(map, prefix + "CertContent", this.CertContent);
            this.SetParamSimple(map, prefix + "CertCaName", this.CertCaName);
            this.SetParamSimple(map, prefix + "CertCaContent", this.CertCaContent);
        }
    }
}

