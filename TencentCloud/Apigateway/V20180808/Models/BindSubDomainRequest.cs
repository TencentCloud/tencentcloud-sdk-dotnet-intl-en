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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BindSubDomainRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique service ID.
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// Custom domain name to be bound.
        /// </summary>
        [JsonProperty("SubDomain")]
        public string SubDomain{ get; set; }

        /// <summary>
        /// Protocol supported by service. Valid values: http, https, http&https.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Network type. Valid values: OUTER, INNER.
        /// </summary>
        [JsonProperty("NetType")]
        public string NetType{ get; set; }

        /// <summary>
        /// Whether the default path mapping is used. The default value is `true`. If the value is `false`, the custom path mapping will be used and `PathMappingSet` will be required in this case.
        /// </summary>
        [JsonProperty("IsDefaultMapping")]
        public bool? IsDefaultMapping{ get; set; }

        /// <summary>
        /// Default domain name.
        /// </summary>
        [JsonProperty("NetSubDomain")]
        public string NetSubDomain{ get; set; }

        /// <summary>
        /// Unique certificate ID of the custom domain name to be bound. The certificate can be uploaded if `Protocol` is `https` or `http&https`.
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// Custom domain name path mapping. It can contain up to 3 `Environment` values which can be set to only `test`, `prepub`, and `release`, respectively.
        /// </summary>
        [JsonProperty("PathMappingSet")]
        public PathMapping[] PathMappingSet{ get; set; }

        /// <summary>
        /// Whether to force HTTP requests to redirect to HTTPS. Default value: `false`. When this parameter is `true`, API Gateway will redirect all requests using the custom domain name over the HTTP protocol to the HTTPS protocol for forwarding.
        /// </summary>
        [JsonProperty("IsForcedHttps")]
        public bool? IsForcedHttps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "SubDomain", this.SubDomain);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
            this.SetParamSimple(map, prefix + "IsDefaultMapping", this.IsDefaultMapping);
            this.SetParamSimple(map, prefix + "NetSubDomain", this.NetSubDomain);
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamArrayObj(map, prefix + "PathMappingSet.", this.PathMappingSet);
            this.SetParamSimple(map, prefix + "IsForcedHttps", this.IsForcedHttps);
        }
    }
}

