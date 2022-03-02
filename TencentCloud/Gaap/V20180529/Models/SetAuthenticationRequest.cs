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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetAuthenticationRequest : AbstractModel
    {
        
        /// <summary>
        /// Listener ID.
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// The domain name requiring advanced configuration, i.e., the domain name of the listener's forwarding rules.
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Whether to enable the basic authentication:
        /// 0: disable basic authentication;
        /// 1: enable basic authentication.
        /// The default value is 0.
        /// </summary>
        [JsonProperty("BasicAuth")]
        public long? BasicAuth{ get; set; }

        /// <summary>
        /// Whether to enable the connection authentication, which is for the origin server to authenticate GAAP.
        /// 0: disable;
        /// 1: enable.
        /// The default value is 0.
        /// </summary>
        [JsonProperty("GaapAuth")]
        public long? GaapAuth{ get; set; }

        /// <summary>
        /// Whether to enable the origin server authentication, which is for GAAP to authenticate the server.
        /// 0: disable;
        /// 1: enable.
        /// The default value is 0.
        /// </summary>
        [JsonProperty("RealServerAuth")]
        public long? RealServerAuth{ get; set; }

        /// <summary>
        /// Basic authentication configuration ID, which is obtained from the certificate management page.
        /// </summary>
        [JsonProperty("BasicAuthConfId")]
        public string BasicAuthConfId{ get; set; }

        /// <summary>
        /// Connection SSL certificate ID, which is obtained from the certificate management page.
        /// </summary>
        [JsonProperty("GaapCertificateId")]
        public string GaapCertificateId{ get; set; }

        /// <summary>
        /// CA certificate ID of the origin server, which is obtained from the certificate management page. When authenticating the origin server, enter this parameter or the `RealServerCertificateIds` parameter.
        /// </summary>
        [JsonProperty("RealServerCertificateId")]
        public string RealServerCertificateId{ get; set; }

        /// <summary>
        /// This field has been disused. Use ServerNameIndication instead.
        /// </summary>
        [JsonProperty("RealServerCertificateDomain")]
        public string RealServerCertificateDomain{ get; set; }

        /// <summary>
        /// CA certificate IDs of multiple origin servers, which are obtained from the certificate management page. When authenticating the origin servers, enter this parameter or the `RealServerCertificateId` parameter.
        /// </summary>
        [JsonProperty("PolyRealServerCertificateIds")]
        public string[] PolyRealServerCertificateIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "BasicAuth", this.BasicAuth);
            this.SetParamSimple(map, prefix + "GaapAuth", this.GaapAuth);
            this.SetParamSimple(map, prefix + "RealServerAuth", this.RealServerAuth);
            this.SetParamSimple(map, prefix + "BasicAuthConfId", this.BasicAuthConfId);
            this.SetParamSimple(map, prefix + "GaapCertificateId", this.GaapCertificateId);
            this.SetParamSimple(map, prefix + "RealServerCertificateId", this.RealServerCertificateId);
            this.SetParamSimple(map, prefix + "RealServerCertificateDomain", this.RealServerCertificateDomain);
            this.SetParamArraySimple(map, prefix + "PolyRealServerCertificateIds.", this.PolyRealServerCertificateIds);
        }
    }
}

