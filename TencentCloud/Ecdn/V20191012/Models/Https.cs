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

namespace TencentCloud.Ecdn.V20191012.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Https : AbstractModel
    {
        
        /// <summary>
        /// HTTPS configuration switch. Valid values: on, off. If the domain name with HTTPS configuration enabled is being deployed, this switch will be `off`.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// Whether to enable HTTP2. Valid values: on, off.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Http2")]
        public string Http2{ get; set; }

        /// <summary>
        /// Whether to enable the OCSP feature. Valid values: on, off.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OcspStapling")]
        public string OcspStapling{ get; set; }

        /// <summary>
        /// Whether to enable the client certificate verification feature. Valid values: on, off. The client certificate information must be uploaded if this feature is enabled.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VerifyClient")]
        public string VerifyClient{ get; set; }

        /// <summary>
        /// Server certificate configuration information.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertInfo")]
        public ServerCert CertInfo{ get; set; }

        /// <summary>
        /// Client certificate configuration information.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ClientCertInfo")]
        public ClientCert ClientCertInfo{ get; set; }

        /// <summary>
        /// Whether to enable SPDY. Valid values: on, off.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Spdy")]
        public string Spdy{ get; set; }

        /// <summary>
        /// HTTPS certificate deployment status. Valid values: closed (disabled), deploying (deploying), deployed (deployment succeeded), failed (deployment failed). This parameter cannot be used as an input parameter.
        /// Note: this field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("SslStatus")]
        public string SslStatus{ get; set; }

        /// <summary>
        /// Hsts configuration.
        /// </summary>
        [JsonProperty("Hsts")]
        public Hsts Hsts{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
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

