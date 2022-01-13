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

    public class AdvanceHttps : AbstractModel
    {
        
        /// <summary>
        /// Custom TLS data switch
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CustomTlsStatus")]
        public string CustomTlsStatus{ get; set; }

        /// <summary>
        /// Specifies the TLS version. Valid values: `TLSv1`, `TLSV1.1`, `TLSV1.2`, and `TLSv1.3`. Only consecutive versions can be enabled at the same time.
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TlsVersion")]
        public string[] TlsVersion{ get; set; }

        /// <summary>
        /// Custom encryption suite
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Cipher")]
        public string Cipher{ get; set; }

        /// <summary>
        /// Origin authentication type
        /// `off`: disable authentication
        /// `oneWay`: authenticate the origin 
        /// `twoWay`: two-way authentication
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("VerifyOriginType")]
        public string VerifyOriginType{ get; set; }

        /// <summary>
        /// Information of the origin-pull certificate
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CertInfo")]
        public ServerCert CertInfo{ get; set; }

        /// <summary>
        /// Information of the origin server certificate
        /// Note: this field may return `null`, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("OriginCertInfo")]
        public ClientCert OriginCertInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CustomTlsStatus", this.CustomTlsStatus);
            this.SetParamArraySimple(map, prefix + "TlsVersion.", this.TlsVersion);
            this.SetParamSimple(map, prefix + "Cipher", this.Cipher);
            this.SetParamSimple(map, prefix + "VerifyOriginType", this.VerifyOriginType);
            this.SetParamObj(map, prefix + "CertInfo.", this.CertInfo);
            this.SetParamObj(map, prefix + "OriginCertInfo.", this.OriginCertInfo);
        }
    }
}

