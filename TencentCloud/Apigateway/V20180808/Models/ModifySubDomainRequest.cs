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

namespace TencentCloud.Apigateway.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySubDomainRequest : AbstractModel
    {
        
        /// <summary>
        /// Unique service ID.
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// Custom domain name for which the path mapping is to be modified.
        /// </summary>
        [JsonProperty("SubDomain")]
        public string SubDomain{ get; set; }

        /// <summary>
        /// Whether to change to the default path mapping. true: use the default path mapping. false: use the custom path mapping.
        /// </summary>
        [JsonProperty("IsDefaultMapping")]
        public bool? IsDefaultMapping{ get; set; }

        /// <summary>
        /// Certificate ID, which is required when the HTTPS protocol is included.
        /// </summary>
        [JsonProperty("CertificateId")]
        public string CertificateId{ get; set; }

        /// <summary>
        /// Modified custom domain name protocol type. Valid values: http, https, http&https.
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// Modified path mapping list.
        /// </summary>
        [JsonProperty("PathMappingSet")]
        public PathMapping[] PathMappingSet{ get; set; }

        /// <summary>
        /// Network type. Valid values: INNER, OUTER.
        /// </summary>
        [JsonProperty("NetType")]
        public string NetType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "SubDomain", this.SubDomain);
            this.SetParamSimple(map, prefix + "IsDefaultMapping", this.IsDefaultMapping);
            this.SetParamSimple(map, prefix + "CertificateId", this.CertificateId);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamArrayObj(map, prefix + "PathMappingSet.", this.PathMappingSet);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
        }
    }
}

