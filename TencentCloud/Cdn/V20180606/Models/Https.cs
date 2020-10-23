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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Https : AbstractModel
    {
        
        /// <summary>
        /// HTTPS configuration switch
        /// on: enabled
        /// off: disabled
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// HTTP2 configuration switch
        /// on: enabled
        /// off: disabled
        /// Enabling HTTPS acceleration for the first time will enable HTTP2 configuration by default.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Http2")]
        public string Http2{ get; set; }

        /// <summary>
        /// OCSP configuration switch
        /// on: enabled
        /// off: disabled
        /// This is disabled by default
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OcspStapling")]
        public string OcspStapling{ get; set; }

        /// <summary>
        /// Client certificate authentication feature
        /// on: enabled
        /// off: disabled
        /// This is disabled by default. The client certificate information is needed when enabled. This is still in beta and not generally available yet.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VerifyClient")]
        public string VerifyClient{ get; set; }

        /// <summary>
        /// Server certificate configuration information
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertInfo")]
        public ServerCert CertInfo{ get; set; }

        /// <summary>
        /// Client certificate configuration information
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClientCertInfo")]
        public ClientCert ClientCertInfo{ get; set; }

        /// <summary>
        /// Spdy configuration switch
        /// on: enabled
        /// off: disabled
        /// This is disabled by default
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Spdy")]
        public string Spdy{ get; set; }

        /// <summary>
        /// HTTPS certificate deployment status
        /// closed: already closed
        /// deploying: in deployment
        /// deployed: successfully deployed
        /// failed: deployment failed
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SslStatus")]
        public string SslStatus{ get; set; }

        /// <summary>
        /// HSTS configuration
        /// </summary>
        [JsonProperty("Hsts")]
        public Hsts Hsts{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Http2", this.Http2);
            this.SetParamSimple(map, prefix + "OcspStapling", this.OcspStapling);
            this.SetParamSimple(map, prefix + "VerifyClient", this.VerifyClient);
            this.SetParamObj(map, prefix + "CertInfo.", this.CertInfo);
            this.SetParamObj(map, prefix + "ClientCertInfo.", this.ClientCertInfo);
            this.SetParamSimple(map, prefix + "Spdy", this.Spdy);
            this.SetParamSimple(map, prefix + "SslStatus", this.SslStatus);
            this.SetParamObj(map, prefix + "Hsts.", this.Hsts);
        }
    }
}

