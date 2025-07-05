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

    public class ModifyHostsCertificateRequest : AbstractModel
    {
        
        /// <summary>
        /// ID of the site.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// Domain names that you need to modify the certificate configuration
        /// </summary>
        [JsonProperty("Hosts")]
        public string[] Hosts{ get; set; }

        /// <summary>
        /// Certificate configuration mode. Values:
        /// <li>`disable`: (Default) Do not configure the certificate</li>
        /// <li>`eofreecert`: Use a free certificate provided by EdgeOne</li>
        /// <li>`sslcert`: Configure an SSL certificate.</li>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// SSL certificate configuration. This parameter is effective only when the mode is sslcert. You only need to provide the CertId of the corresponding certificate. You can check the CertId from the [SSL Certificate List](https://console.cloud.tencent.com/ssl).
        /// </summary>
        [JsonProperty("ServerCertInfo")]
        public ServerCertInfo[] ServerCertInfo{ get; set; }

        /// <summary>
        /// Whether the certificate is managed by EdgeOne. Values:
        /// <li>`none`: Not managed by EdgeOne</li>
        /// <li>`apply`: Managed by EdgeOne</li>
        /// Default value: `none`.
        /// </summary>
        [JsonProperty("ApplyType")]
        [System.Obsolete]
        public string ApplyType{ get; set; }

        /// <summary>
        /// In the mutual authentication scenario, this field represents the client's CA certificate, which is deployed inside the EO node and used for the client to authenticate the EO node. By default, it is disabled. If it is left blank, it indicates retaining the original configuration.
        /// </summary>
        [JsonProperty("ClientCertInfo")]
        public MutualTLS ClientCertInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArraySimple(map, prefix + "Hosts.", this.Hosts);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamArrayObj(map, prefix + "ServerCertInfo.", this.ServerCertInfo);
            this.SetParamSimple(map, prefix + "ApplyType", this.ApplyType);
            this.SetParamObj(map, prefix + "ClientCertInfo.", this.ClientCertInfo);
        }
    }
}

