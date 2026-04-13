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

    public class OriginCertificateVerify : AbstractModel
    {
        
        /// <summary>
        /// Origin certificate verification mode. valid values: <li>disable: disable origin certificate verification.</li> <li>custom_ca: use designated trusted ca certificate for verification.</li>.
        /// </summary>
        [JsonProperty("VerificationMode")]
        public string VerificationMode{ get; set; }

        /// <summary>
        /// Specifies the trusted CA certificate list. the origin certificate must be issued by this CA to pass verification. note: this parameter is required only when VerificationMode is custom_CA. input this parameter to specify the trusted CA certificate information.
        /// OriginCertificateVerify specifies CertId of the corresponding certificate as an input parameter in ModifyHostsCertificate. only need to go to the SSL certificate service list (https://console.cloud.tencent.com/SSL) to check CertId.	
        /// </summary>
        [JsonProperty("CustomCACerts")]
        public CertificateInfo[] CustomCACerts{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VerificationMode", this.VerificationMode);
            this.SetParamArrayObj(map, prefix + "CustomCACerts.", this.CustomCACerts);
        }
    }
}

