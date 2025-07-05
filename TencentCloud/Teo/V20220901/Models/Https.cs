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

    public class Https : AbstractModel
    {
        
        /// <summary>
        /// Whether to enable HTTP2. Values:
        /// <li>`on`: Enable</li>
        /// <li>`off`: Disable</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Http2")]
        public string Http2{ get; set; }

        /// <summary>
        /// Whether to enable OCSP. Values:
        /// <li>`on`: Enable</li>
        /// <li>`off`: Disable</li>
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OcspStapling")]
        public string OcspStapling{ get; set; }

        /// <summary>
        /// TLS version. Valid values: 
        /// <li>`TLSv1`: TLSv1 version;</li>
        /// <li>`TLSV1.1`: TLSv1.1 version;</li>
        /// <li>`TLSV1.2`: TLSv1.2 version;</li>
        /// <li>`TLSv1.3`: TLSv1.3 version.</li>Only consecutive versions can be enabled at the same time. 
        /// Note: This field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TlsVersion")]
        public string[] TlsVersion{ get; set; }

        /// <summary>
        /// HSTS Configuration
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Hsts")]
        public Hsts Hsts{ get; set; }

        /// <summary>
        /// The certificate configuration.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertInfo")]
        public ServerCertInfo[] CertInfo{ get; set; }

        /// <summary>
        /// Whether the certificate is managed by EdgeOne. Values:
        /// <li>`apply`: Managed by EdgeOne.</li>
        /// <li>`none`: Not managed by EdgeOne.</li>If it is left empty, the default value `none` is used.
        /// Note: This field may return `null`, indicating that no valid value can be obtained.
        /// </summary>
        [JsonProperty("ApplyType")]
        public string ApplyType{ get; set; }

        /// <summary>
        /// The cipher suite, with values:
        /// <li>loose-v2023: Provides high compatibility with general security, and supports TLS 1.0-1.3 cipher suites;</li>
        /// <li>general-v2023: Provides relatively high compatibility with moderate security, and supports TLS 1.2-1.3 cipher suites;</li>
        /// <li>strict-v2023: Provides high security, disables all cipher suites with security risks, and supports TLS 1.2-1.3 cipher suites.</li>
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("CipherSuite")]
        public string CipherSuite{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Http2", this.Http2);
            this.SetParamSimple(map, prefix + "OcspStapling", this.OcspStapling);
            this.SetParamArraySimple(map, prefix + "TlsVersion.", this.TlsVersion);
            this.SetParamObj(map, prefix + "Hsts.", this.Hsts);
            this.SetParamArrayObj(map, prefix + "CertInfo.", this.CertInfo);
            this.SetParamSimple(map, prefix + "ApplyType", this.ApplyType);
            this.SetParamSimple(map, prefix + "CipherSuite", this.CipherSuite);
        }
    }
}

