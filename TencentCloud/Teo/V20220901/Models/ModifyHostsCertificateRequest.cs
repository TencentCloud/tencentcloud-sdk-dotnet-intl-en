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
        /// List of domain names that the certificate will be attached to.
        /// </summary>
        [JsonProperty("Hosts")]
        public string[] Hosts{ get; set; }

        /// <summary>
        /// Certificate information. Note that only `CertId` is required. If it is not specified, the default certificate will be used.
        /// </summary>
        [JsonProperty("ServerCertInfo")]
        public ServerCertInfo[] ServerCertInfo{ get; set; }

        /// <summary>
        /// Whether the certificate is managed by EdgeOne. Values:
        /// <li>`apply`: Managed by EdgeOne.</li>
        /// <li>`none`: Not managed by EdgeOne.</li>If not specified, this field uses the default value `none`.
        /// </summary>
        [JsonProperty("ApplyType")]
        public string ApplyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArraySimple(map, prefix + "Hosts.", this.Hosts);
            this.SetParamArrayObj(map, prefix + "ServerCertInfo.", this.ServerCertInfo);
            this.SetParamSimple(map, prefix + "ApplyType", this.ApplyType);
        }
    }
}

